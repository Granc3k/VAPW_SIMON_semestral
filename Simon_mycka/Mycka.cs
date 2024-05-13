using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Simon_mycka
{
    public class Mycka : IDisposable
    {
        public bool VstupVrata { get; private set; }
        public bool VystupVrata { get; private set; }
        public Semafor VstupSemafor { get; private set; }
        public Semafor VystupSemafor { get; private set; }

        private int WorkingCycleMs = 0;
        private Data _MyckaStav { get; set; }
        public Data MyckaStav { get { return _MyckaStav; } private set { var changed = value != _MyckaStav; _MyckaStav = value; if (changed) OnCarWashStateChanged?.Invoke(this, _MyckaStav); } }


        public delegate void ChangedCarWashState(object sender, Data CarWashState);
        public event ChangedCarWashState OnCarWashStateChanged;

        private bool Running { get; set; } = false;
        private bool Washing { get; set; } = false;
        private bool Open { get; set; } = false;
        private bool FinishedWashing { get; set; } = false;
        private bool Finished { get; set; } = false;
        private bool CarInside { get; set; } = false;

        private Thread _thread = new Thread(new ParameterizedThreadStart(ThreadProcedure));

        private static void ThreadProcedure(object obj)
        {
            var mycka = (Mycka)obj;
            var processStopwatch = Stopwatch.StartNew();
            short state = 0;
            mycka.VstupSemafor = Semafor.Red;
            mycka.VystupSemafor = Semafor.Red;
            mycka.VstupVrata = false;
            mycka.VystupVrata = false;
            mycka.MyckaStav = UpdateData(mycka);

            while (mycka.Running)
            {
                Stopwatch timingStopwatch = Stopwatch.StartNew();
                processStopwatch.Stop();
                switch (state)
                {
                    case 0:
                        if (mycka.Open)
                        {
                            mycka.VstupSemafor = Semafor.Green;
                            mycka.VstupVrata = true;
                            mycka.MyckaStav = UpdateData(mycka);
                            state = 1;
                        }
                        break;
                    case 1:
                        if (mycka.CarInside)
                        {
                            mycka.VstupSemafor = Semafor.Red;
                            mycka.VstupVrata = false;
                            mycka.MyckaStav = UpdateData(mycka);
                            mycka.Washing = true;
                            state = 2;
                        }
                        break;
                    case 2:
                        if (mycka.FinishedWashing)
                        {
                            mycka.VystupSemafor = Semafor.Green;
                            mycka.VystupVrata = true;
                            mycka.MyckaStav = UpdateData(mycka);
                            mycka.Finished = true;
                            state = 3;
                        }
                        break;
                    case 3:
                        if (!mycka.Finished)
                        {
                            mycka.VstupSemafor = Semafor.Red;
                            mycka.VystupSemafor = Semafor.Red;
                            mycka.VstupVrata = false;
                            mycka.VystupVrata = false;
                            mycka.MyckaStav = UpdateData(mycka);
                            mycka.Open = false;
                            mycka.FinishedWashing = false;
                            mycka.Finished = false;
                            mycka.CarInside = false;
                            state = 0;
                        }
                        break;
                }
                processStopwatch.Restart();

                timingStopwatch.Stop();
                if (mycka.Washing)
                {
                    var toWaitMs = mycka.WorkingCycleMs - (int)timingStopwatch.ElapsedMilliseconds;
                    toWaitMs = toWaitMs < 1 ? 1 : toWaitMs;
                    try
                    {
                        Thread.Sleep(toWaitMs);
                    }
                    catch (ThreadInterruptedException)
                    {
                        mycka.Dispose();
                    }
                    mycka.Washing = false;
                    mycka.FinishedWashing = true;
                }

            }
        }

        private static Data UpdateData(Mycka self)
        {
            var data = new Data(self.VstupVrata, self.VystupVrata, self.VstupSemafor, self.VystupSemafor);
            return data;
        }

        public static int GetWashDuration(WashStyle style)
        {
            return style switch
            {
                WashStyle.FULL => 10,
                WashStyle.Basic => 5,
                WashStyle.Quick => 2,
                _ => throw new ArgumentException("Invalid wash style"),
            };
        }

        public Mycka()
        {
            Running = true;
            _thread.Start(this);
        }

        public void CarReady()
        {
            if (!Washing)
            {
                Open = true;
            }
        }

        public void Leave()
        {
            if (!Finished)
            {
                throw new InvalidOperationException("Car is not washed");
            }
            Finished = false;
        }

        public void AutoVevnitr()
        {
            if (!Open)
            {
                throw new InvalidOperationException("Door is not open");
            }
            if (CarInside == true)
            {
                throw new InvalidOperationException("Car is already inside");
            }
            CarInside = true;
        }

        public void VyberStylu(WashStyle style)
        {
            int time = 1000 * GetWashDuration(style);
            WorkingCycleMs = time;
        }

        public void Dispose()
        {
            try
            {
                Running = false;
                _thread.Interrupt();
                _thread.Join();
            }
            catch (Exception)
            {

            }
        }
    }
}

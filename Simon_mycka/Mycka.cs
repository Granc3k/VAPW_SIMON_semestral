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

        public bool picture1 { get; private set; }

        public bool picture2 { get; private set; }

        public bool picture3 {  get; private set; }

        private int WorkingCycleMs = 0;
        private Data _MyckaStav { get; set; }
        public Data MyckaStav { get { return _MyckaStav; } private set { var changed = value != _MyckaStav; _MyckaStav = value; if (changed) OnCarWashStateChanged?.Invoke(this, _MyckaStav); } }


        public delegate void ChangedCarWashState(object sender, Data CarWashState);
        public event ChangedCarWashState OnCarWashStateChanged;

        private bool Running { get; set; } = false;
        private bool Washing { get; set; } = false;
        private bool Open { get; set; } = false;
        private bool FinishedWashing {get; set; } = false;
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
            mycka.picture1 = false;
            mycka.picture2 = false;
            mycka.picture3 = false;

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
                            mycka.picture1 = true;
                            mycka.picture3 = false;
                            mycka.MyckaStav = UpdateData(mycka);
                            state = 1;
                        }
                        break;
                    case 1:
                        if (mycka.CarInside)
                        {
                            mycka.VstupSemafor = Semafor.Red;
                            mycka.VstupVrata = false;
                            mycka.picture1 = false;
                            mycka.picture2 = true;
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
                            mycka.picture1 = false;
                            mycka.picture2 = true;
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
                            mycka.picture2 = false;
                            mycka.picture3 = true;
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
            var data = new Data(self.VstupVrata, self.VystupVrata, self.VstupSemafor, self.VystupSemafor, self.picture1, self.picture2, self.picture3);
            return data;
        }

        public static int GetWashDuration(Styl style)
        {
            return style switch
            {
                Styl.Plne => 10,
                Styl.Zakladni => 5,
                Styl.Rychle => 2,
                _ => throw new ArgumentException("Nevalidní styl mytí"),
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
                throw new InvalidOperationException("Auto není umyté");
            }
            Finished = false;
        }

        public void AutoVevnitr()
        {
            if (!Open)
            {
                throw new InvalidOperationException("Vrata nejsou otevřena");
            }
            if (CarInside == true)
            {
                throw new InvalidOperationException("Auto je už uvnitř");
            }
            CarInside = true;
        }

        public void VyberStylu(Styl style)
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

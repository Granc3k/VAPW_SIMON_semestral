using System;
using System.Windows.Forms;
using System.Drawing;
using Simon_mycka;
using Timer = System.Windows.Forms.Timer;
namespace VAPW_SIMON_semestral
{
    public partial class Form1 : Form
    {
        private Mycka mycka;
        Timer timer = new Timer();
        bool handleEvents = true;

        public Form1()
        {
            InitializeComponent();
            mycka = new Mycka();
            mycka.OnCarWashStateChanged += Mycka_OnCarWashStateChanged;
            washStyleComboBox.Items.Add("Rychle");
            washStyleComboBox.Items.Add("Zakladni");
            washStyleComboBox.Items.Add("Plne");
            timer.Interval = 100;
            timer.Tick += new EventHandler(CheckOnTimer);
            timer.Start();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void CheckOnTimer(object? sender, EventArgs e)
        {
            if (handleEvents)
            {    
                vstupVrataLabel.Text = mycka.VstupVrata ? "Otevřeno" : "Zavřeno";
                vystupVrataLabel.Text = mycka.VystupVrata ? "Otevřeno" : "Zavřeno";
                VstupBranaPanel.Visible = mycka.VstupVrata ? false : true;
                VystupBranaPanel.Visible = mycka.VystupVrata ? false : true;
                pictureBox1.Visible = mycka.picture1;
                pictureBox2.Visible = mycka.picture2;
                pictureBox3.Visible = mycka.picture3;
                Semafor1.BackColor = Color.FromName(mycka.VstupSemafor.ToString());
                Semafor2.BackColor = Color.FromName(mycka.VystupSemafor.ToString());
                    
            }
            timer.Start();
            
        }

        private void Mycka_OnCarWashStateChanged(object sender, Data WashState)
        {
            if (!handleEvents)
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        vstupVrataLabel.Text = WashState.VstupVrata ? "Otevřeno" : "Zavřeno";
                        vystupVrataLabel.Text = WashState.VystupVrata ? "Otevřeno" : "Zavřeno";
                        VstupBranaPanel.Visible = WashState.VstupVrata ? false : true;
                        VystupBranaPanel.Visible = WashState.VystupVrata ? false : true;
                        pictureBox1.Visible = WashState.picture1;
                        pictureBox2.Visible = WashState.picture2;
                        pictureBox3.Visible = WashState.picture3;
                        Semafor1.BackColor = Color.FromName(WashState.VstupSemafor.ToString());
                        Semafor2.BackColor = Color.FromName(WashState.VystupSemafor.ToString());
                    });
                }
            }
        }

        private void ShutDownError()
        {
            ErrorLabel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Spustí mycí proces
            ShutDownError();
            try
            {
                mycka.CarReady();
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            ShutDownError();
            try
            {
                // Ukončí mycí proces
                mycka.Leave();
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
        }

        private void carInsideButton_Click(object sender, EventArgs e)
        {
            ShutDownError();
            try
            {
                // Indikuje, že auto je uvnitř myčky
                mycka.AutoVevnitr();
            }
            catch (Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
        }

        private void washStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nastaví styl mytí na základě výběru uživatele
            Styl style = (Styl)Enum.Parse(typeof(Styl), washStyleComboBox.SelectedItem.ToString());
            mycka.VyberStylu(style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeMethod_Click(object sender, EventArgs e)
        {
            var Ligma = new Form2(!handleEvents);
            Ligma.ShowDialog();
            handleEvents = !Ligma.timer;
        }
    }
}

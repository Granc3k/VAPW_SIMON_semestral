using System;
using System.Windows.Forms;
using System.Drawing;
using Simon_mycka;
namespace VAPW_SIMON_semestral
{
    public partial class Form1 : Form
    {
        private Mycka mycka;
        public Form1()
        {
            InitializeComponent();
            mycka = new Mycka();
            mycka.OnCarWashStateChanged += Mycka_OnCarWashStateChanged;
            washStyleComboBox.Items.Add("Quick");
            washStyleComboBox.Items.Add("Basic");
            washStyleComboBox.Items.Add("FULL");
        }

        private void Mycka_OnCarWashStateChanged(object sender, Data CarWashState)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    vstupVrataLabel.Text = CarWashState.VstupVrata ? "Otevřeno" : "Zavřeno";
                    vystupVrataLabel.Text = CarWashState.VystupVrata ? "Otevřeno" : "Zavřeno";
                    Semafor1.BackColor = Color.FromName(CarWashState.VstupSemafor.ToString());
                    Semafor2.BackColor = Color.FromName(CarWashState.VystupSemafor.ToString());
                });
            }
        }
        
        private void killError()
        {
            ErrorLabel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Spustí mycí proces
            killError();
            try
            {
                mycka.CarReady();
            }catch(Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            killError();
            try { 
            // Ukončí mycí proces
                mycka.Leave();
            }catch(Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
}

        private void carInsideButton_Click(object sender, EventArgs e)
        {
            killError();
            try
            {
                // Indikuje, že auto je uvnitř myčky
                mycka.AutoVevnitr();
            }catch(Exception ex)
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = ex.Message;
            }
        }

        private void washStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nastaví styl mytí na základě výběru uživatele
            WashStyle style = (WashStyle)Enum.Parse(typeof(WashStyle), washStyleComboBox.SelectedItem.ToString());
            mycka.VyberStylu(style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

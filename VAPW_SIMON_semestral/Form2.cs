using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPW_SIMON_semestral
{
    public partial class Form2 : Form
    {

        public bool timer { get; set; } = false;
        public Form2(bool _timer)
        {
            InitializeComponent();
            timer = _timer;
            if (!_timer)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }


        private void radioButton1_Click(object sender, EventArgs e)
        {
            //přes delegáta
            timer = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            //přes timer
            timer = true;
            radioButton1.Checked = false;
            radioButton2.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

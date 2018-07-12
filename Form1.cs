using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int secunde;
        int minute;
        int ore;

        public void START()
        {
            secunde++;
            if (secunde < 10)
            {
                lblsecunde.Text = Convert.ToString("0" + secunde);
            }
            else
            {
                lblsecunde.Text = Convert.ToString(secunde);
            }

            if (secunde == 60)
            {
                minute++;
                secunde = 0;

                if (minute < 10)
                {
                    lblminute.Text = Convert.ToString("0" + minute);

                }
                else
                {
                    lblminute.Text = Convert.ToString(minute);
                }



                if (minute == 60)
                {
                    ore++;
                    minute = 0;
                    secunde = 0;
                    if (ore < 10)
                    {
                        lblore.Text = Convert.ToString("0" + ore);
                    }
                    else
                    {
                        lblore.Text = Convert.ToString(ore);
                    }
                }
            }

        }


        public Form1()
        {
            InitializeComponent();
            secunde = 0;
            minute = 0;
            ore = 0;

        }

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            START();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            lblsecunde.Text = "00";
            lblminute.Text = "00";
            lblore.Text = "00";
            secunde = 0;
            minute = 0;
            ore = 0;
        }
    }
}





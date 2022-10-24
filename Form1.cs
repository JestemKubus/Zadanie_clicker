using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_clicker
{
    public partial class Form1 : Form
    {

        private int licznik = 0;
        private int ticks;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            licznik++;
            label2.Text = "Wynik: " + licznik.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            label1.Text = "Timer: " + ticks.ToString();
            if (ticks == 3)
            {
                button2.Text = "Koniec";
                timer1.Stop();
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                licznik = 0;
                label2.Text = "Wynik: " + licznik.ToString();
                label1.Text = "Timer: 0";
                timer1.Stop();
                ticks = 0;
                button2.Enabled = true;       
        }

        
    }
}

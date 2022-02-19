using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszog3
{
    public partial class Form1 : Form
    {
        Haromszog abc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tba.Text) + Convert.ToDouble(tbb.Text) > Convert.ToDouble(tbc.Text) &&
                Convert.ToDouble(tba.Text) + Convert.ToDouble(tbc.Text) > Convert.ToDouble(tbb.Text) &&
                Convert.ToDouble(tbc.Text) + Convert.ToDouble(tbb.Text) > Convert.ToDouble(tba.Text))
            {
                abc = new Haromszog(Convert.ToDouble(tba.Text), Convert.ToDouble(tbb.Text), Convert.ToDouble(tbc.Text));
                tba.Text = "";tbb.Text = "";tbc.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                btnOldalak.Enabled = true;
                btnEgyenloszaru.Enabled = true;
                btnSzabalyos.Enabled = true;
                btnKerulet.Enabled = true;
                btnTerulet.Enabled = true;
            }
            else { MessageBox.Show("Roszz adatok, ezekből nem szerkeszthetünk háromszöget!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "a = " + abc.GetA().ToString() + "   b = " + abc.GetB().ToString() + "  c = " + abc.GetC().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (abc.Egyenloszaru()) { label5.Text = "Egyenlőszárú"; }
            else { label5.Text = "Nem egyenlőszárú"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (abc.Szabalyos()) { label6.Text = "Szabályos"; }
            else { label6.Text = "Nem szabályos"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "A háromszög kerülete: " + abc.Kerulet().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = "A háromszög területe: " + abc.Terulet().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOldalak.Enabled = false;
            btnEgyenloszaru.Enabled = false;
            btnSzabalyos.Enabled = false;
            btnKerulet.Enabled = false;
            btnTerulet.Enabled = false;
        }
    }
}

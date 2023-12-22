using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dich = new Form2();
            dich.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form3 newton = new Form3();
            newton.Show();
        }

        private void slauButton_Click(object sender, EventArgs e)
        {
            Form5 slau = new Form5();
            slau.Show();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Form4 sort = new Form4();
            sort.Show();
        }

        private void intergalsButton_Click(object sender, EventArgs e)
        {
            Form6 integrals = new Form6();
            integrals.Show();
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            Form7 spusk = new Form7();
            spusk.Show();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Form8 square = new Form8();
            square.Show();
        }
    }
}

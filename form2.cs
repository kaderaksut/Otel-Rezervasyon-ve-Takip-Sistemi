using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace otel_rezwrvasyon_projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OdaTiklama(object sender, EventArgs e)
        {
            Button basilan = (Button)sender;

            if (basilan.BackColor == Color.Red)
            {
                basilan.BackColor = Color.Orange;

            }
            else if (basilan.BackColor == Color.Orange)
            {
                basilan.BackColor = Color.Green;

            }
            else
            {
                basilan.BackColor = Color.Red;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

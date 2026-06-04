namespace otel_rezwrvasyon_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ucret = 0;
            int ekstra = 0;
            int odenecektutar = 0;
            string r_ad = textBox1.Text;
            DateTime r_tarih = dateTimePicker1.Value;
            int k_gun = Convert.ToInt32(textBox3.Text);
            if (radioButton1.Checked == true)
            {
                ucret += 2500;
            }
            else if (radioButton2.Checked == true)
            {
                ucret += 5000;
            }

            odenecektutar = ucret * k_gun;
            if (checkBox1.Checked == true)
            {
                ekstra = k_gun * 1000;
                odenecektutar += ekstra;
            }
             
            if (checkBox2.Checked == true)
            {
                ekstra = k_gun * 2000;
                odenecektutar += ekstra;
            }
            
            if (checkBox3.Checked == true)
            {
                ekstra = k_gun * 2000;
                odenecektutar += ekstra;
            }
            KAYITLAR.Items.Add(r_ad + " - " + r_tarih + " - " + odenecektutar + " TL");
            label6.Text = odenecektutar.ToString();
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KAYITLAR.Items.Clear();
            label6.Text = "O TL";

        }
    }
}

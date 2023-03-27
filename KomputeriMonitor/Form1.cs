namespace KomputeriMonitor
{
    public partial class Form1 : Form
    {
        public double cena_ogolna = 0, cena_monitora = 0, cena_komputera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
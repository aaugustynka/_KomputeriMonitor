using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KomputeriMonitor
{
    public partial class Form3 : Form
    {
        double cena = 0;
        Form1 form;
        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.cena_ogolna -= form.cena_monitora;
            form.cena_monitora = cena;
            form.cena_ogolna += form.cena_monitora;
            form.label1.Text = Math.Round(form.cena_ogolna, 2) + " zl";
            this.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena = 0;
            double[] ceny_monitorow = { 2500.99, 3469.99, 2137.99, 5096.99 };
            System.Windows.Forms.ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;
            foreach (int index in indexes)
            {
                cena += ceny_monitorow[index];
            }
            label2.Text = Math.Round(cena, 2) + " zl";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}

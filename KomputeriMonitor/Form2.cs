using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomputeriMonitor
{
    public partial class Form2 : Form
    {
        double cena = 0, cenak = 0, cenadod = 0, cenad = 0;
        Form1 form;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cenad = 189.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.cena_ogolna -= form.cena_komputera;
            form.cena_komputera = cena;
            form.cena_ogolna += form.cena_komputera;
            form.label1.Text = Math.Round(form.cena_ogolna, 2) + " zl";
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cenad = 389.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cenad = 215.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                cenadod += 78.99;
            else
                cenadod -= 78.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                cenadod += 255.99;
            else
                cenadod -= 255.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double[] ceny_kart = { 9999.99, 2167.99, 1453.99, 3456.99, 5678.99 };
            cenak = ceny_kart[comboBox1.SelectedIndex];
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                cenadod += 129.99;
            else
                cenadod -= 129.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                cenadod += 349.99;
            else
                cenadod -= 349.99;
            cena = cenak + cenad + cenadod;
            label3.Text = Math.Round(cena, 2) + " zl";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}

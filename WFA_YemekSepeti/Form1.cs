using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_YemekSepeti
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBirinciYemek_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBirinciYemek.SelectedIndex == cmbIkinciYemek.SelectedIndex)
            {
                MessageBox.Show("lütfen farklı bir yemek seçiniz");
                cmbBirinciYemek.SelectedItem = null;
            }


        }

        private void cmbIkinciYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirinciYemek.SelectedIndex == cmbIkinciYemek.SelectedIndex)
            {
                MessageBox.Show("LÜTFEN FARKLI BİR YEMEK SEÇİNİZ");

                cmbIkinciYemek.SelectedItem = null;
            }


        }
        int result;
        int sonuc1;
        int sonuc2;
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            if (cmbBirinciYemek.SelectedIndex < 0 || cmbIkinciYemek.SelectedIndex < 0)
            {
                MessageBox.Show("LÜTFEN YEMEK SEÇİNİZ");


            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("LÜTFEN PORSİYON BİLGİSİ GİRİNİZ");
            }
           try
            {
                int sayi1 = Int32.Parse(textBox1.Text);
                int sayi2 = Int32.Parse(textBox2.Text);
                if (cmbBirinciYemek.SelectedIndex == 0)
                {
                    sonuc1 = sayi1 * 20;
                }
                else if (cmbBirinciYemek.SelectedIndex == 1)
                {
                    sonuc1 = sayi1 * 10;

                }
                if (cmbIkinciYemek.SelectedIndex == 0)
                {
                    sonuc2 = sayi2 * 20;
                }
                else if (cmbIkinciYemek.SelectedIndex == 1)
                {
                    sonuc2 = sayi2 * 10;
                }
                result = sonuc1 + sonuc2;

                MessageBox.Show("Sipariş Tutarı: " + result.ToString() + " TL");
                cmbIkinciYemek.Text = "";
                cmbBirinciYemek.Text = "";
                textBox1.Clear();
                textBox2.Clear();
            }
            
            catch
            {
                MessageBox.Show("");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            cmbIkinciYemek.Text = "";
            cmbBirinciYemek.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("gidişiniz bizi üzüyor:(");
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yemek Seçiminiz: " + cmbBirinciYemek.Text + " Porsiyon Tercihiniz:" + textBox1.Text + " Adet\n Yemek Seçimizin: " + cmbIkinciYemek.Text + " Porsiyon Tercihinz: " + textBox2.Text + " Adet");
        }
    }
}


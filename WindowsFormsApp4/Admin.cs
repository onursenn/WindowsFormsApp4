using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtGuvenlikKodu.Text!=""&& txtKullanici.Text != "" && txtsifre.Text != "")
            {
                if (txtKullanici.Text == "Admin" && txtsifre.Text == "12345" && txtGuvenlikKodu.Text == txtRandom.Text)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Veri Girişi");

                    int r1, r2, r3, r4;
                    Random rn = new Random();
                    r1 = rn.Next(0, 8);
                    r2 = rn.Next(0, 8);
                    r3 = rn.Next(0, 8);
                    r4 = rn.Next(0, 8);
                    string[] alfabe = { "a", "b", "c", "d", "e", "f", "g", "h" };

                    txtRandom.Text = (alfabe[r1] + r2.ToString() + alfabe[r3] + r4.ToString());
                }

            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın");


                int r1, r2, r3, r4;
                Random rn = new Random();
                r1 = rn.Next(0, 8);
                r2 = rn.Next(0, 8);
                r3 = rn.Next(0, 8);
                r4 = rn.Next(0, 8);
                string[] alfabe = { "a", "b", "c", "d", "e", "f", "g", "h" };

                txtRandom.Text = (alfabe[r1] + r2.ToString() + alfabe[r3] + r4.ToString());
            }


           
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum sf = new sifremiunuttum();
            sf.Show();
            this.Hide();
        }




        

        private void Admin_Load(object sender, EventArgs e)
        {

            int r1, r2, r3, r4;
            Random rn = new Random();
            r1 = rn.Next(0, 8);
            r2 = rn.Next(0, 8);
            r3 = rn.Next(0, 8);
            r4 = rn.Next(0, 8);
            string[] alfabe = { "a", "b", "c", "d","e","f","g","h" };

            txtRandom.Text =( alfabe[r1] + r2.ToString() +alfabe[r3] +r4.ToString());

        }
    }
}

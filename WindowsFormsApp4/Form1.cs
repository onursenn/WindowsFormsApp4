using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSad_Click(object sender, EventArgs e)
        {
            txtDurum.Clear();
            txtOrt.Clear();
            txtAdSad.Clear();
            txtS1.Clear();
            txtS2.Clear();
            txtS3.Clear();
            cmbDers.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtAdSad.Text!="" && txtS1.Text!="" && txtS2.Text != "" && txtS3.Text!=""&& cmbDers.Text != "")
            {
                float s1, s2, s3, ort;
                s1 = float.Parse(txtS1.Text);
                s2 = float.Parse(txtS2.Text);
                s3 = float.Parse(txtS3.Text);
                ort = (s1 + s2 + s3) / 3;

                txtOrt.Text = ort.ToString();

                if (ort <= 49.99)
                {
                    txtDurum.Text = "Kaldı";
                    listBox2.Items.Add(txtAdSad.Text + " " + cmbDers.Text + " " + txtOrt.Text);
                }
                else
                {
                    txtDurum.Text = "Geçti";
                    listBox1.Items.Add(txtAdSad.Text + " " + cmbDers.Text + " " + txtOrt.Text);
                }


            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın");
            }

              

        }
    }
}

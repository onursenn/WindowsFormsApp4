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
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbDogrula.SelectedIndex==0 && txtDogrula.Text== "12345" || cmbDogrula.SelectedIndex==1 && txtDogrula.Text=="Admin" || cmbDogrula.SelectedIndex==2 && txtDogrula.Text=="12345" )
            {
                MessageBox.Show("Şifreniz: 12345");

                Admin frm = new Admin();
                frm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }

          
        }
    }
}

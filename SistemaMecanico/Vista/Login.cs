using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMecanico
{
    public partial class Form1 : Form
    {
        Controlador.Controlador controler = new Controlador.Controlador();
        Vista.MenuPrincipal menp = new Vista.MenuPrincipal();

        public Form1()
        {
            InitializeComponent();
        }

        public void Loguearme()
        {
            string pass=controler.EncriptaPass(txtPassword.Text);
            pass = pass.Substring(0, 30);
           
            if (controler.Loguearme(txtUser.Text, pass))
            {
               
                menp.Show();
                this.Hide();
            }
            else
                MessageBox.Show("VERIFIQUE SUS DATOS");

            txtUser.Text = "";
            txtPassword.Text = "";
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            Loguearme();
           
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text != "") txtPassword.Enabled = true;
            else txtPassword.Enabled = false;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loguearme();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "") btnEntrar.Enabled = true;
            else btnEntrar.Enabled = false;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Loguearme();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        } 
    }
}

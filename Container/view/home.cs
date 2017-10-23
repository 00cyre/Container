using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cont.view
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        valogin objLogin = new valogin();

        private void home_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogar_MouseHover(object sender, EventArgs e)
        {
            btnlogar.BackColor = Color.FromArgb(255, 108, 12);
            btnlogar.ForeColor = Color.White;
        }

        private void btnlogar_MouseLeave(object sender, EventArgs e)
        {
            btnlogar.BackColor = Color.White;
            btnlogar.ForeColor = Color.FromArgb(255, 108, 12);
        }

        private void btnvoltar_MouseHover(object sender, EventArgs e)
        {
            btnvoltar.BackColor = Color.FromArgb(255, 108, 12);
            btnvoltar.ForeColor = Color.White;
        }

        private void btnvoltar_MouseLeave(object sender, EventArgs e)
        {
            btnvoltar.BackColor = Color.White;
            btnvoltar.ForeColor = Color.FromArgb(255, 108, 12);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login log = new login();
            log.ShowDialog();
            this.Visible = true;

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if ((txtemail.Text == "") && (numsenhauser.Text != ""))
            {
                MessageBox.Show("Preencha o email!");
                txtemail.Focus();
            }
            else if ((txtemail.Text != "") && (numsenhauser.Text == ""))
            {
                MessageBox.Show("Preencha a senha!");
                numsenhauser.Focus();
            }
            else if ((txtemail.Text == "") && (numsenhauser.Text == ""))
            {
                MessageBox.Show("Preencha o email e a senha!");
                txtemail.Focus();
                numsenhauser.Focus();
            }
            else
            {
                if (objLogin.ValidarLogin(txtemail.Text, numsenhauser.Text))
                {
                    this.Visible = false;
                    minhaempresa menu = new minhaempresa();
                    menu.ShowDialog();
                    this.Visible = true;

                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

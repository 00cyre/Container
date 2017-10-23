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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            home logar = new home();
            logar.ShowDialog();

            this.Visible = true;
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            cadastrar cad = new cadastrar();
            cad.ShowDialog();

            this.Visible = true;

        }

        private void btncad_MouseLeave(object sender, EventArgs e)
        {
            btncad.BackColor = Color.White;
            btncad.ForeColor = Color.FromArgb(255, 108, 12);
        }

        private void btncad_MouseHover(object sender, EventArgs e)
        {
            btncad.BackColor = Color.FromArgb(255, 108, 12);
            btncad.ForeColor = Color.White;
        }

        private void btnentrar_MouseHover(object sender, EventArgs e)
        {

            btnentrar.BackColor = Color.FromArgb(255, 108, 12);
            btnentrar.ForeColor = Color.White;
        }

        private void btnentrar_MouseLeave(object sender, EventArgs e)
        {
            btnentrar.BackColor = Color.White;
            btnentrar.ForeColor = Color.FromArgb(255, 108, 12);
        }
    }
}

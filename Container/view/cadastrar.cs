using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cont.view
{
    public partial class cadastrar : Form
    {

        public cadastrar()
        {
            InitializeComponent();

        }
        conexaobd bd = new conexaobd();
        string sql;
        string sql2;
        static private string user;
        static private string id;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcomp_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login log = new login();
            log.ShowDialog();
            this.Visible = true;
        }

        private void btncad_MouseHover(object sender, EventArgs e)
        {
            btncad.BackColor = Color.FromArgb(255, 108, 12);
            btncad.ForeColor = Color.White;
        }

        private void btncad_MouseLeave(object sender, EventArgs e)
        {
            btncad.BackColor = Color.White;
            btncad.ForeColor = Color.FromArgb(255, 108, 12);
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

        private void btncad_Click(object sender, EventArgs e)
        {

            int cont = 0;

            if ((txtnome_emp.Text == ""))
            {
                lblnomeemp.BackColor = Color.Red;

            }
            else
            {
                lblnomeemp.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtemail.Text == ""))
            {
                lblemail.BackColor = Color.Red;
            }
            else
            {
                lblemail.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtcidade.Text == ""))
            {
                lblcidade.BackColor = Color.Red;
            }
            else
            {
                lblcidade.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtrua.Text == ""))
            {
                lblrua.BackColor = Color.Red;
            }
            else
            {
                lblrua.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtbairro.Text == ""))
            {
                lblbairro.BackColor = Color.Red;
            }
            else
            {
                lblbairro.BackColor = Color.Transparent;
                cont++;
            }
            if ((numnrua.Text == ""))
            {
                lblnumrua.BackColor = Color.Red;
            }
            else
            {
                lblnumrua.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtnomeres.Text == ""))
            {
                lblnomeresp.BackColor = Color.Red;
                cont++;
            }
            else
            {
                lblnomeresp.BackColor = Color.Transparent;
                cont++;
            }
            if ((numsenha.Text == ""))
            {
                lblsenha.BackColor = Color.Red;
            }
            else
            {
                lblsenha.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtnome_emp.Text == "")
               || (txtemail.Text == "")
               || (txtsite.Text == "")
               || (txtcidade.Text == "")
               || (txtrua.Text == "")
               || (txtbairro.Text == "")
               || (numnrua.Text == "")
               || (txtnomeres.Text == "")
               || (numsenha.Text == ""))
            {
                MessageBox.Show("Os campos destacados de vermelho devem ser preenchidos", "Erro!");
            }
            if ((txtcep.Text.Length != 8))
            {
                MessageBox.Show("Cep inválido! \nDeve conter 8 caracteres", "Erro!");
                lblcep.BackColor = Color.Red;
            }
            else
            {
                lblcep.BackColor = Color.Transparent;
                cont++;
            }
            if ((txtcnpj.Text.Length != 13))
            {
                MessageBox.Show("Cnpj inválido! \nDeve conter 14 caracteres", "Erro!");
                lblcnpj.BackColor = Color.Red;
            }
            else
            {
                lblcnpj.BackColor = Color.Transparent;
                cont++;
            }
            if ((txttel1.Text.Length != 11))
            {
                MessageBox.Show("Telefone celular inválido! \nDeve conter 11 caracteres", "Erro!");
                lbltelefone1.BackColor = Color.Red;
            }
            else
            {
                lbltelefone1.BackColor = Color.Transparent;
                cont++;
            }
            if ((cboestado.Text == ""))
            {
                MessageBox.Show("Escolha um estado!", "Erro!");
                lblestado.BackColor = Color.Red;
            }
            else
            {
                lblestado.BackColor = Color.Transparent;
                cont++;
            }

            if (cont == 12)
            {
                sql = string.Format("insert into empresa values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",txtnome_emp.Text,txtcnpj.Text,txtemail.Text,txttel1.Text,txttel2.Text,txtsite.Text,numsenha.Text,txtrua.Text,txtbairro.Text,numnrua.Text,txtcomp.Text,txtcidade.Text,cboestado.Text,txtcep.Text,txtnomeres.Text);
                bd.AlterarTabelas(sql);
                user = txtnome_emp.Text;
                string sql2 = string.Format("select * from empresa where email = '{0}' and senha = '{1}'", txtemail.Text, numsenha.Text);
                DataTable dt = bd.ConsultarTabelas(sql2);
                if (dt.Rows.Count > 0)
                {
                    id = dt.Rows[0]["id"].ToString();
                    
                }
                else
                {
                    id = "erro";
                }
                MessageBox.Show("Empresa Cadastrado com Sucesso...", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                empresa emp = new empresa();
                emp.ShowDialog();
                this.Visible = true;
               

            }





        }
        public string getUser()
        {
            return user;
        }
        public string getiden()
        {
            return id;
        }



        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void txtnome_emp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

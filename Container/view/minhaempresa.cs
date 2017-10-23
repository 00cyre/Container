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
    public partial class minhaempresa : Form
    {
        public minhaempresa()
        {
            InitializeComponent();
        }
        valogin objLogin = new valogin();
        conexaobd bd = new conexaobd();
        string sql;
        string id;
        private void lbl_perfil_nomeemp_Click(object sender, EventArgs e)
        {

        }
        public void listar(string id)
        {

            sql = string.Format("select nome_produto,preco,imposto,marca from materiais where empresa_id = {0}", id);
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        private void txtnovoorçamento_Click(object sender, EventArgs e)
        {
                
        }

        private void minhaempresa_Shown(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minhaempresa_Load(object sender, EventArgs e)
        {
            lbl_perfil_nomeemp.Text =objLogin.getUsuario();
            id = objLogin.getid();
            listar(id);
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

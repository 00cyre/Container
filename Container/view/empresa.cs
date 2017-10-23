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
    public partial class empresa : Form
    {
        public empresa()
        {
            InitializeComponent();
        }
        conexaobd bd = new conexaobd();
        cadastrar cad = new cadastrar();
        string sql;
        string id;


        public void listar(string id)
        {

            sql = string.Format("select nome_produto,preco,imposto,marca from materiais where empresa_id = {0}", id);
            dtglistar2.DataSource = bd.ConsultarTabelas(sql);
        }


        private void empresa_Load(object sender, EventArgs e)
        {
            lbl_perfil_nomeemp2.Text = cad.getUser();
            id = cad.getiden();
            if (id != "erro")
            {
                listar(id);
            }
            else
            {
                MessageBox.Show("Erro ao carregar id!");
            }
        }
    }
}

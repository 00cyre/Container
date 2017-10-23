using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace cont.view
{
    class valogin
    {
        conexaobd arq = new conexaobd();
        static private string usuario;
        static private string id;


        public bool ValidarLogin(string email, string senha)
        {

            string sql = string.Format("select * from empresa where email = '{0}' and senha = '{1}'", email, senha);
            DataTable dt = arq.ConsultarTabelas(sql);
            if (dt.Rows.Count > 0)
            {
                usuario = dt.Rows[0]["nome_empresa"].ToString();
                id = dt.Rows[0]["id"].ToString();
                return true;
            }
            else
            {
                return false;
            }

        }


        public string getUsuario()
        {
            return usuario;
        }
        public string getid()
        {
            return id;
        }

    }
}

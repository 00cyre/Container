using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cont.view
{
    class conexaobd
    {
        MySqlConnection con;

        //Conectar Com o Banco de dados
        public void ConectarBD()
        {
            try
            {
                con = new MySqlConnection("Persist Security info = false; server = localhost; database = container; user=root;pwd=;");
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Insert-Delete-Update
        public int AlterarTabelas(string sql)
        {
            try
            {
                ConectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        //Select
        public DataTable ConsultarTabelas(string sql)
        {

            try
            {
                ConectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }


        }
    }
}

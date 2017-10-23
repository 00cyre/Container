using System.Data;
using MySql.Data.MySqlClient;
using Container.Model.Helper;

namespace Container.Model
{
    static class Database
    {
        public static MySqlConnection conexao = new MySqlConnection("server = localhost; database=bd_container;user=root;pwd=;");

        private static object executarQuery(MySqlCommand sql)
        {
            try
            {
                conexao.Open();
                return sql.ExecuteScalar() ?? 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private static DataTable executarQuery(MySqlDataAdapter sql)
        {
            try
            {
                conexao.Open();
                DataTable dt = new DataTable();
                sql.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool insert(string tabela, string valores)
        {
            string sql = $"INSERT INTO {tabela} VALUES({valores})";
            MySqlCommand query = new MySqlCommand(sql, conexao);
            return executarQuery(query) != null;
        }

        public static bool delete(string tabela, string condicao = null)
        {
            string sql = $"DELETE FROM {tabela}" + condicao != null ? $" WHERE {condicao}" : "";
            MySqlCommand query = new MySqlCommand(sql, conexao);
            return executarQuery(query) != null;
        }

        public static bool update(string tabela, string valores, string condicao = null)
        {
            string sql = $"UPDATE {tabela} SET {valores}" + condicao != null ? $" WHERE {condicao}" : "";
            MySqlCommand query = new MySqlCommand(sql, conexao);
            return executarQuery(query) != null;
        }

        public static string selectSingleValue(string tabela)
        {
            string sql = "SELECT * FROM " + tabela;
            MySqlCommand query = new MySqlCommand(sql, conexao);
            return executarQuery(query).ToString();
        }

        public static string selectSingleValue(string tabela, string condicao)
        {
            return executarQuery(DatabaseHelper.criarQueryComParametros(tabela, condicao)).ToString();
        }

        public static string selectSingleValue(string valores, string tabela, string condicao)
        {
            return executarQuery(DatabaseHelper.criarQueryComParametros(valores, tabela, condicao)).ToString();
        }

        public static DataTable selectDataTable(string tabela)
        {
            string sql = $"SELECT * FROM {tabela}";
            MySqlDataAdapter query = new MySqlDataAdapter(new MySqlCommand(sql, conexao));
            return executarQuery(query);
        }


        public static DataTable selectDataTable(string tabela, string condicao)
        {
            return executarQuery(new MySqlDataAdapter(DatabaseHelper.criarQueryComParametros(tabela, condicao)));
        }

        public static DataTable selectDataTable(string valores, string tabela, string condicao)
        {
            return executarQuery(new MySqlDataAdapter(DatabaseHelper.criarQueryComParametros(valores, tabela, condicao)));
        }
    }
}

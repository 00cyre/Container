using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Container.Model.Helper
{
    static class DatabaseHelper
    {
        public static MySqlCommand criarQueryComParametros(string tabela, string condicao)
        {
            List<string> parametros = Regex.Split(condicao, "'(.*?)'").ToList();
            parametros = parametros.Where(x => parametros.IndexOf(x) % 2 == 1).ToList();
            string sql = "SELECT * FROM " + tabela + " WHERE " + condicao;
            MySqlCommand query = new MySqlCommand(sql, Database.conexao);
            //montarListaDeParametros(condicao, parametros, query);
            return query;
        }

        public static MySqlCommand criarQueryComParametros(string valores, string tabela, string condicao)
        {
            List<string> parametros = Regex.Split(condicao, "'(.*?)'").ToList();
            parametros = parametros.Where(x => parametros.IndexOf(x) % 2 == 1).ToList();
            string sql = "SELECT " + valores + " FROM " + tabela + " WHERE " + remodelarCondicao(condicao, parametros);
            MySqlCommand query = new MySqlCommand(sql, Database.conexao);
            montarListaDeParametros(condicao, parametros, query);
            return query;
        }

        public static void montarListaDeParametros(string condicao, List<string> parametros, MySqlCommand query)
        {
            for (int i = 0; i < parametros.Count; i++)
            {
                query.Parameters.AddWithValue($"@p{i}p", parametros[i]);
            }
        }

        public static string remodelarCondicao(string condicao, List<string> parametros)
        {
            for (int i = 0; i < parametros.Count; i++)
            {
                condicao = condicao.Replace(parametros[i], $"@p{i}p");
            }
            return condicao;
        }
    }
}

using System;
using System.Data;

namespace Container.Model
{
    class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario(string email)
        {
            DataTable valores = Database.selectDataTable("empresa", $"email='{email}'");
            Id = Convert.ToInt32(valores.Rows[0]["id"]);
            Nome = valores.Rows[0]["nome_empresa"].ToString();
        }

        public Usuario(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
    }
}

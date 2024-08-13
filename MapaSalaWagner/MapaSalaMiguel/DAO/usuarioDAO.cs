using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using model.entidades;
using System.Data;

namespace MapaSala.DAO
{
    public class usuarioDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public usuarioDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(UsuariosEntidade usuario)
        {
            Conexao.Open();
            string query = "Insert into Usuario (Nome, Id, Login, Senha, Ativo) Values (@nome,@Id, @Login, @Senha, @Ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", usuario.Nome);
            SqlParameter parametro2 = new SqlParameter("@Id", usuario.Id);
            SqlParameter parametro3 = new SqlParameter("@Login", usuario.Login);
            SqlParameter parametro4 = new SqlParameter("@Senha", usuario.Senha);
            SqlParameter parametro5 = new SqlParameter("@Ativo", usuario.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
            /*        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }*/
        }
        public DataTable obterusuario()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select From Usuarios Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    UsuariosEntidade usuarios = new UsuariosEntidade();
                    usuarios.Id = Convert.ToInt32(leitura[0]);
                    usuarios.Nome = leitura[1].ToString();
                    usuarios.Senha = leitura[2].ToString();
                    usuarios.Login = leitura[3].ToString();
                    usuarios.Ativo = Convert.ToBoolean(leitura[4]);
                    dt.Rows.Add(usuarios.Linha());

                    return dt;
                }
            }
            return new DataTable();

        }




    }
}


/*        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }*/

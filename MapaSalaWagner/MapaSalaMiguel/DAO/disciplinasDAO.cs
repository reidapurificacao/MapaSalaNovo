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
    public class disciplinasDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public disciplinasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(DisciplinasEntidade disciplina)
        {
            Conexao.Open();
            string query = "Insert into Disciplinas (Nome, ID) Values (@nome,@ID)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", disciplina.nome);
            SqlParameter parametro2 = new SqlParameter("@ID", disciplina.ID);
            SqlParameter parametro3 = new SqlParameter("@sigla", disciplina.sigla);
            SqlParameter parametro4 = new SqlParameter("@ativo", disciplina.ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);

            /*public int ID { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public bool ativo { get; set; }*/
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable obterDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select From Disciplinas Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    DisciplinasEntidade disciplinas = new DisciplinasEntidade();
                    disciplinas.ID = Convert.ToInt32(leitura[0]);
                    disciplinas.nome = leitura[1].ToString();
                    disciplinas.sigla = leitura[2].ToString();
                    disciplinas.ativo = Convert.ToBoolean(leitura[3]);
                    dt.Rows.Add(disciplinas.Linha());

                    return dt;
                }
            }
            return new DataTable();

        }




    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class DisciplinasEntidade
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public bool ativo { get; set; }
        public Object[] Linha()
        {
            return new object[] { ID, nome, sigla, ativo };
        }
    }
}
*/



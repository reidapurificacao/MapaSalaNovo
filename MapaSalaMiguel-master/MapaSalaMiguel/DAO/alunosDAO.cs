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
    public class alunosDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public alunosDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(AlunoEntidade aluno)
        {
            Conexao.Open();
            string query = "Insert into Aluno (nome, apelido, idade, sala, ID) Values (@nome,@apelido, @idade, @sala, @ID)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", aluno.nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", aluno.apelido);
            SqlParameter parametro3 = new SqlParameter("@idade", aluno.idade);
            SqlParameter parametro4 = new SqlParameter("@sala", aluno.sala);
            SqlParameter parametro5 = new SqlParameter("@estudante", aluno.estudante);
            SqlParameter parametro6 = new SqlParameter("@ID", aluno.ID);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable obteralunos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select From Alunos Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(AlunoEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    AlunoEntidade aluno = new AlunoEntidade();
                    aluno.ID = Convert.ToInt32(leitura[0]);
                    aluno.nome = leitura[1].ToString();
                    aluno.idade = Convert.ToInt32(leitura[2]);
                    aluno.sala = Convert.ToInt32(leitura[3]);
                    aluno.estudante = Convert.ToBoolean(leitura[4]);
                    aluno.apelido = leitura[5].ToString();
                    dt.Rows.Add(aluno.Linha());

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
    public class AlunoEntidade
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public int sala { get; set; }
        public bool estudante { get; set; }
        public string apelido { get; set; }

        public Object[] Linha()
        {
            return new object[] { ID, nome, idade, sala, estudante, apelido };
        }
    }//  dados.Rows.Add("123", "Miguel", "16", "5", true, "goleiro");

}
*/


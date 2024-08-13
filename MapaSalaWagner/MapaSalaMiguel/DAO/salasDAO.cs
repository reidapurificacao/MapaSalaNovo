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
    public class salasDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public salasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(SalasEntidades salas)
        {
            Conexao.Open();
            string query = "Insert into Salas (Nome, Ano, Periodo, npcs, ncadeiras ) Values (@nome,@ano, @periodo, @npcs, @ncadeiras)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", salas.Nome);
            SqlParameter parametro2 = new SqlParameter("@ano", salas.ano);
            SqlParameter parametro3 = new SqlParameter("@id", salas.Id);
            SqlParameter parametro4 = new SqlParameter("@periodo", salas.periodo);
            SqlParameter parametro5 = new SqlParameter("@npcs", salas.NumeroComputador);
            SqlParameter parametro6 = new SqlParameter("@ncadeiras", salas.NumeroCadeiras);
            SqlParameter parametro7 = new SqlParameter("@disp", salas.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.Parameters.Add(parametro6);
            comando.Parameters.Add(parametro7);
            comando.ExecuteNonQuery();
            Conexao.Close();
            /* public int Id { get; set; }
        public int ano { get; set; }
        
        public string periodo { get; set; }
        public string Nome { get; set; }
        public int NumeroComputador { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool Disponivel { get; set; }*/
        }
        public DataTable obtersala()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select From Salas Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    SalasEntidades salas = new SalasEntidades();
                    salas.Id = Convert.ToInt32(leitura[0]);
                    salas.ano = Convert.ToInt32(leitura[1]);
                    salas.Nome = leitura[2].ToString();
                    salas.periodo = leitura[3].ToString();
                    salas.NumeroComputador = Convert.ToInt32(leitura[4]);
                    salas.IsLab = Convert.ToBoolean(leitura[5]);
                    salas.NumeroCadeiras = Convert.ToInt32(leitura[6]);
                    salas.Disponivel = Convert.ToBoolean(leitura[7]);
                    dt.Rows.Add(salas.Linha());

                    return dt;
                }
            }
            return new DataTable();

        }




    }
}
/* public int Id { get; set; }
        public int ano { get; set; }
        
        public string periodo { get; set; }
        public string Nome { get; set; }
        public int NumeroComputador { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool Disponivel { get; set; }*/


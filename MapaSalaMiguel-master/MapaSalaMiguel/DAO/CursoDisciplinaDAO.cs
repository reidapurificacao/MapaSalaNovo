using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSalaMiguel.DAO
{
    public void Inserir(CursoDisciplinaEntidade cursoDisciplina)
    {
        Conexao.Open();
        string query = "Insert into CursoDisciplina" + (Curso_Id, Apelido) Values (@nome,@apelido)";
        SqlCommand comando = new SqlCommand(query, Conexao);
        SqlParameter parametro1 = new SqlParameter("@Curso_Id", Objeto.CursoId);
        SqlParameter parametro2 = new SqlParameter("@Disciplina_Id", Objeto.Disciplina);
        SqlParameter parametro2 = new SqlParameter("@Disciplina_Id", Objeto.Periodo);
        comando.Parameters.Add(parametro1);
        comando.Parameters.Add(parametro2);
        comando.ExecuteNonQuery();
        Conexao.Close();
    }
    class CursoDisciplinaDAO
    {
    }
}

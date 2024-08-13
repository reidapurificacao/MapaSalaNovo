using System;
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

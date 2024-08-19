using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class CursosEntidade
    {
        /*txtboxId.Text = "";
            txtboxAno.Text = "";
            txtboxNome.Text = "";
            txtboxPeriodo.Text = "";
            chkboxVagas.Checked = false;*/

        public int Id { get; set; }
        public int Ano { get; set; }
        public string Nome { get; set; }
        public string Periodo { get; set; }
        public bool Vagas { get; set; }
        public Object[] Linha()
        {
            return new object[] { Id, Nome, Ano, Periodo, Vagas };
        }

    }
}

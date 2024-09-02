using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    class CursoDisciplina
    {
        public long id { get; set; }
        public long DisciplinaId { get; set; }
        public long CursoId { get; set; }
        public string Periodo { get; set; }
        public string NomeDisciplina { get; set; }
        public String NomeCurso { get; set; }
    }
}

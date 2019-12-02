using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    class TurmaRequest
    {
        public TurmaModel Turma { get; set; }

        public AnoLetivoModel AnoLetivo { get; set; }

        public CursoModel Curso { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model.Matricula
{
    public class DocumentosModel
    {
        public int IdAlunoDocumento { get; set; }
        public int IdAluno { get; set; }
        public string NmDocumento { get; set; }
        public bool BtEntregue { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AnoLetivoModel
    {
        public int NrAno { get; set; }

        public ulong BtAtivo { get; set; }

        public DateTime DtFim { get; set; }

        public int IdAnoLetivo { get; set; }

        public string TpStatus { get; set; }

        public DateTime DtInicio { get; set; }
    }  
}

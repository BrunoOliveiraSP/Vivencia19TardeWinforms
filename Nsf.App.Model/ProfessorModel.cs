﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class ProfessorModel
    {
        public int IdProfessor { get; set; }

        public int IdLogin { get; set; }

        public string NmProfessor { get; set; }

        public string DsCelular { get; set; }

        public string DsTelefone { get; set; }

        public string DsEstado { get; set; }

        public string DsEmail { get; set; }

        public string DsCvLattes { get; set; }

        public int NrAnoPrimeiroEmprego { get; set; }

        public string DsCpf { get; set; }

        public string DsRg { get; set; }

        public string DsRgOrgao { get; set; }

        public string DsRgEmissor { get; set; }

        public string NmMae { get; set; }

        public string NmPai { get; set; }

        public string TpContratacao { get; set; }

        public bool BtAtivo { get; set; }

        public string DsFaculdade { get; set; }

        public string DsCurso { get; set; }

        public string DsLogin { get; set; }

        public DateTime DtNascimento { get; set; }

        public DateTime DtFaculdadeInicio { get; set; }

        public DateTime DtFaculdadeFim { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class LoginModel
    {
        public int IdLogin { get; set; }

        public int IdRole { get; set; }

        public string DsLogin { get; set; }

        public string DsSenha { get; set; }

        public bool BtTrocar { get; set; }

        public DateTime DtInclusao { get; set; }

        public DateTime DtUltimoLogin { get; set; }

        public bool BtAtivo { get; set; }
    }
}

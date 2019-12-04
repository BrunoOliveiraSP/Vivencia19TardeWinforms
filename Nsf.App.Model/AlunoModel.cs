using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AlunoModel
    {
        public int id_aluno { get; set; }
        public string nm_aluno { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string ds_rg { get; set; }
        public DateTime dt_emissao { get; set; }
        public string ds_orgao { get; set; }
        public string ds_sexo { get; set; }
        public string ds_cpf { get; set; }
        public string ds_etinia { get; set; }
        public string ds_email { get; set; }
        public string ds_celular { get; set; }
        public string ds_escolaridade { get; set; }
        public string nm_escola { get; set; }
        public string tp_escola { get; set; }
        public int ds_como_conheceu { get; set; }
        public int qt_moram_casa { get; set; }
        public int qt_trabalham_casa { get; set; }
        public decimal vl_renda { get; set; }
        public string ds_observacao { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime dt_ultima_alteracao { get; set; }
        public int id_funcionario_alteracao { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client.Abstract
{
    interface ICrud<Tabela>
    {
        void Salvar(Tabela model);
        void Alterar(Tabela model);
        void Remover(int id);
        List<Tabela> ListarTodos();
    }
}

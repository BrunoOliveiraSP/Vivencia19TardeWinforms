using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class SalaVestibularAPI
    {
        public List<Model.SalaVestibularModel> listarTudo()
        {
            HttpClient cliente = new HttpClient();

            string json = cliente.GetAsync("http://localhost:5000/SalaVestibular/ListarTudo/").Result.Content.ReadAsStringAsync().Result;

            List<Model.SalaVestibularModel> teste = JsonConvert.DeserializeObject<List< Model.SalaVestibularModel >>(json);
            return teste;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
   public class AnoLetivoApi
    {
        HttpClient client = new HttpClient();

        public void CadastrarAnoLetivo(Model.AnoLetivoModel ano)
        {
            string json = JsonConvert.SerializeObject(ano);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost/AnoLetivo/", body).Result;
        }

        public List<Model.AnoLetivoModel> ListarTodos()
        {
            string json = client.GetAsync("http://localhost/AnoLetivo/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Model.AnoLetivoModel> lista = JsonConvert.DeserializeObject<List<Model.AnoLetivoModel>>(json);

            return lista;
        }

        public void Remover(int id)
        {
            var resp = client.DeleteAsync("http://localhost/AnoLetivo/" + id).Result;
        }
    }
}

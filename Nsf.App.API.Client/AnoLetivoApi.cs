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
       

        public void CadastrarAnoLetivo(Model.AnoLetivoModel ano)
        {
            HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(ano);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/AnoLetivo/", body).Result;
        }

        public List<Model.AnoLetivoModel> ListarTodos()
        {
            HttpClient client = new HttpClient();
            string json = client.GetAsync("http://localhost:5000/AnoLetivo/ListarTodos")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Model.AnoLetivoModel> lista = JsonConvert.DeserializeObject<List<Model.AnoLetivoModel>>(json);

            return lista;
        }

        public void Remover(int id)
        {
            HttpClient client = new HttpClient();
            var resp = client.DeleteAsync("http://localhost:5000/AnoLetivo/" + id).Result;
        }


    }
}

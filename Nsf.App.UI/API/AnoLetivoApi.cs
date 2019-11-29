using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI.API
{
    class AnoLetivoApi
    {
        HttpClient client = new HttpClient();

        public void CadastrarAnoLetivo (Models.AnoLetivoModel ano)
        {
            string json = JsonConvert.SerializeObject(ano);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost/AnoLetivo/", body).Result;
        }

        public List<Models.AnoLetivoModel> ListarTodos()
        {
            string json = client.GetAsync("http://localhost/AnoLetivo/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result
        }
    }
}

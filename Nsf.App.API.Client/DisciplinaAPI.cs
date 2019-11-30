using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public  class DisciplinaAPI
    {
      

        public void Inserir(Nsf.App.Model.DisciplinaModel model)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(model);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = client.PostAsync("http://localhost:5000/Disciplina", body).Result;
        }
    }
}

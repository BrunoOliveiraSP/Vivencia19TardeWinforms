using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class ExemploAPI
    {
        public List<Nsf.App.Model.ExemploModel> Listar()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Exemplo")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.ExemploModel> lista =
                JsonConvert.DeserializeObject<List<Nsf.App.Model.ExemploModel>>(json);

            return lista;
        }


        public void Inserir(Nsf.App.Model.ExemploModel exemplo)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(exemplo);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Exemplo", body)
                             .Result;

            if (resp.IsSuccessStatusCode == false)
            {
                string jsonResposta = resp.Content
                                          .ReadAsStringAsync()
                                          .Result;

                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(jsonResposta);
                throw new ArgumentException(erro.Mensagem);
            }
        }
    }
}

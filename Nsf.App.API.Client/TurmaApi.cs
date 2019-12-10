using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Nsf.App.API.Client
{
   public  class TurmaApi
   {
        HttpClient client = new HttpClient();

        public Model.TurmaModell Cadastrar(Nsf.App.Model.TurmaModell turma)
        {
            string json = JsonConvert.SerializeObject(turma);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = client.PostAsync("http://localhost:5000/Turma/", body).Result;

            string jsonResposta = LerJson(resposta);
            turma = JsonConvert.DeserializeObject<Model.TurmaModell>(json);
                                                                                    
            return turma;
        }

        public List<Nsf.App.Model.TurmaResponse> ListarTodos()
        {
            string json = client.GetAsync("http://localhost:5000/Turma/")          
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.TurmaResponse> lista = JsonConvert.DeserializeObject<List<Nsf.App.Model.TurmaResponse>>(json);

            return lista;
        }

        public void Remover(int id)
        {
            var resp = client.DeleteAsync("http://localhost:5000/Turma/" + id).Result;
        }

        public void Alterar(Nsf.App.Model.TurmaModell turma)
        {
            string json = JsonConvert.SerializeObject(turma);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Turma/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }

        private void VerificarErro(string respostaAPI)
        {
            if (respostaAPI.Contains("codigoErro"))
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(respostaAPI);
                throw new ArgumentException(erro.Mensagem);
            }
        }
        private string LerJson(HttpResponseMessage resposta)
        {
            string json = resposta.Content.ReadAsStringAsync().Result;

            if(resposta.IsSuccessStatusCode == false)
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(json);
                throw new ArgumentException(erro.Mensagem);
            }
            return json;

        }
   }
}


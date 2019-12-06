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

            var resp = client.PostAsync("http://localhost:5000/AnoLetivo/", body)
                            .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }

        public List<Model.AnoLetivoModel> ListarTodos()
        {
            string json = client.GetAsync("http://localhost:5000/AnoLetivo/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Model.AnoLetivoModel> lista = JsonConvert.DeserializeObject<List<Model.AnoLetivoModel>>(json);

            return lista;
        }

        public void Remover(int id)
        {
            var resp = client.DeleteAsync("http://localhost:5000/AnoLetivo/" + id)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            VerificarErro(resp);
        }

        public void Alterar(Model.AnoLetivoModel ano)
        {
            string json = JsonConvert.SerializeObject(ano);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/AnoLetivo/", body)
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
    }
}

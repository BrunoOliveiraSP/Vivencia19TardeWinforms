using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class MatriculaAPI
    {
        public void Inserir(Nsf.App.Model.MatriculaRequest Matricula)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(Matricula);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Aluno", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }

        

        private void VerificarErro(string respostaApi)
        {
            if (respostaApi.Contains("codigoErro"))
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(respostaApi);
                throw new ArgumentException(erro.Mensagem);
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI.API
{
    class InscricaoAPI
    {
        public void Inserir(Models.InscricaoModel inscricao)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(inscricao);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Inscricao", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(json);
        }

        private void VerificarErro(string respostaAPI)
        {
            if(respostaAPI.Contains("codigoErro"))
            {
                Models.ErrorModel erro = JsonConvert.DeserializeObject<Models.ErrorModel>(respostaAPI);
                throw new ArgumentException(erro.Mensagem);
            }
        }
    }
}

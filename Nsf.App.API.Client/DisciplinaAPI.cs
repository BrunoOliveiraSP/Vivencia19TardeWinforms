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

        public void Inserir(Nsf.App.Model.DisciplinaModel disci)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disci);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Disciplina", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }
        public List<Nsf.App.Model.DisciplinaModel> Listar()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<List<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
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

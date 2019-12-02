using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class InscricaoAPI
    {
        public void Inserir(Model.InscricaoModel inscricao)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(inscricao);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Inscricao", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }

        public List<Model.InscricaoModel> ConsultarTodos()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Inscricao/ConsultarTodos")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            VerificarErro(json);

            return JsonConvert.DeserializeObject<List<Model.InscricaoModel>>(json);
        }
		public List<Model.InscricaoModel> ConsultarNome(string nome,  int ano)
		{
			HttpClient NomeAnoConsulta = new HttpClient();

			string json = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/ConsultarPorNomeEAno/"+ nome + "/" + ano)
										.Result
										.Content
										.ReadAsStringAsync()
										.Result;
			VerificarErro(json);
			return JsonConvert.DeserializeObject<List<Model.InscricaoModel>>(json);
				                    
		}

        public void Alterar(Model.InscricaoModel inscricao)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(inscricao);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Inscricao", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }

        public  void Remover(int id)
        {
            HttpClient client = new HttpClient();

            var resp = client.DeleteAsync("http://localhost:5000/Inscricao/" + id)
                            .Result
                            .Content
                            .ReadAsStringAsync()
                            .Result;

            this.VerificarErro(resp);
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

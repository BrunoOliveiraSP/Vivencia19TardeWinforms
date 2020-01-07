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
        public Model.InscricaoModel Inserir(Model.InscricaoModel inscricao)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(inscricao);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage respostaApi = client.PostAsync("http://localhost:5000/Inscricao", body).Result;
                             

            string resposta = VerificarErro(respostaApi);


            return JsonConvert.DeserializeObject<Model.InscricaoModel>(resposta);
        }
        public List<Model.InscricaoResponse> ConsultarTodos()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.GetAsync("http://localhost:5000/Inscricao").Result;


            string jsonResposta = VerificarErro(respostaApi);

            return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(jsonResposta);
        }
		public List<Model.InscricaoResponse> ConsultarNome(string nome,  int ano)
		{
			HttpClient NomeAnoConsulta = new HttpClient();

            HttpResponseMessage respostaApi = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/Consultar?nome=" + nome + "&ano=" + ano).
                Result;

            string jsonResposta = VerificarErro(respostaApi);
			return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(jsonResposta);
        }
        public Model.InscricaoModel Alterar(Model.InscricaoModel inscricao)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(inscricao);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage respostaApi = client.PutAsync("http://localhost:5000/Inscricao", body)
                             .Result;

            string jsonResposta = VerificarErro(respostaApi);

            return JsonConvert.DeserializeObject<Model.InscricaoModel>(jsonResposta);
        }
        public  void Remover(int id)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.DeleteAsync("http://localhost:5000/Inscricao/" + id)
                            .Result;

            string jsonResposta = VerificarErro(respostaApi);
        }
        public List<Model.InscricaoResponse> ConsultarAnoLetivoLista(int id)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.GetAsync("http://localhost:5000/Inscricao/ConsultarAnoLetivoLista/" + id)
                                        .Result;
            string jsonResposta = VerificarErro(respostaApi);
            return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(jsonResposta);
        }
        private string VerificarErro(HttpResponseMessage respostaAPI)
        {
            string jsonResposta = respostaAPI.Content.ReadAsStringAsync().Result;

            if (respostaAPI.IsSuccessStatusCode == false)
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(jsonResposta);
                throw new ArgumentException(erro.Mensagem);
            }
            return jsonResposta;
        }
    }
}

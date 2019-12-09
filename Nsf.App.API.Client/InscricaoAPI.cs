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

        public List<Model.InscricaoResponse> ConsultarTodos()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Inscricao")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            VerificarErro(json);

            return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(json);
        }
		public List<Model.InscricaoResponse> ConsultarNome(string nome,  int ano)
		{
			HttpClient NomeAnoConsulta = new HttpClient();

            var json = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/ConsultarPorNomeEAno/" + nome + "/" + ano)
                                        .Result
										.Content
										.ReadAsStringAsync()
										.Result;
			VerificarErro(json);
			return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(json);

            
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

        public Model.CursoModel ConsultarCurso(int id)
        {
            HttpClient NomeAnoConsulta = new HttpClient();

            string json = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/ConsultarCurso/" + id)
                                        .Result
                                        .Content
                                        .ReadAsStringAsync()
                                        .Result;
            VerificarErro(json);
            return JsonConvert.DeserializeObject<Model.CursoModel>(json);
        }

        public Model.AnoLetivoModel ConsultarAnoLetivo(int id)
        {
            HttpClient NomeAnoConsulta = new HttpClient();

            string json = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/ConsultarAnoLetivo/" + id)
                                        .Result
                                        .Content
                                        .ReadAsStringAsync()
                                        .Result;
            VerificarErro(json);
            return JsonConvert.DeserializeObject<Model.AnoLetivoModel>(json);
        }

        public List<Model.InscricaoResponse> ConsultarAnoLetivoLista(int id)
        {
            HttpClient NomeAnoConsulta = new HttpClient();

            string json = NomeAnoConsulta.GetAsync("http://localhost:5000/Inscricao/ConsultarAnoLetivoLista/" + id)
                                        .Result
                                        .Content
                                        .ReadAsStringAsync()
                                        .Result;
            VerificarErro(json);
            return JsonConvert.DeserializeObject<List<Model.InscricaoResponse>>(json);
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

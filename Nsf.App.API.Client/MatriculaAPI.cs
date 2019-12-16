using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Nsf.App.API.Client
{
    public class MatriculaAPI
    {
        HttpClient client = new HttpClient();

        public void Inserir(Nsf.App.Model.MatriculaRequest matricula)
        {

            string json = JsonConvert.SerializeObject(matricula);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Matricula", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }

        public void Alterar(Nsf.App.Model.MatriculaRequest matricula)
        {

            string json = JsonConvert.SerializeObject(matricula);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Matricula", body)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            VerificarErro(resp);


        }

        public void Deletar(int id)
        {
            var resp = client.DeleteAsync("http://localhost:5000/Matricula/" + id)
               .Result
               .Content
               .ReadAsStringAsync()
               .Result;

            VerificarErro(resp);
        }

        public List<Model.MatriculaResponse> ListarTodos()
        {

            var resp = client.GetAsync("http://localhost:5000/Matricula/ListarTodos")
               .Result
               .Content
               .ReadAsStringAsync()
               .Result;

            List<Model.MatriculaResponse> lista = JsonConvert.DeserializeObject<List<Model.MatriculaResponse>>(resp);

            return lista;
        }
        public List<Model.MatriculaRequest> ConsultarPorParametros(string nome, string curso, string turma, string ra, int id)
        {
            HttpClient client = new HttpClient();

            var resp = client.GetAsync("http://localhost:5000/Matricula?nome=" + nome + 
                                                                               "&ra=" + ra + 
                                                                               "&curso=" + curso + 
                                                                               "&turma=" + turma +
                                                                               "&Idanoletivo=" + id)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result;

            List<Model.MatriculaRequest> lista = JsonConvert.DeserializeObject<List<Model.MatriculaRequest>>(resp);

            return lista;
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

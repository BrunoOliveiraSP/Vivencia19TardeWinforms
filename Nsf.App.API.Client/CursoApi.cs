using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI.API
{
    public class CursoAPI
    {
        public int Inserir(Nsf.App.Model.CursoModel curso)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");
            
            var resp = client.PostAsync("http://localhost:5000/Curso/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);


            int id  = JsonConvert.DeserializeObject<int>(resp);

           
            
            return id;
        }

        public List<Nsf.App.Model.CursoModel> ConsultarTodos()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Curso/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            this.VerificarErro(json);

            List<Nsf.App.Model.CursoModel> lista = JsonConvert.DeserializeObject<List<Nsf.App.Model.CursoModel>>(json);

            return lista;
        }

        public List<Nsf.App.Model.CursoModel> ConsultarPorCurso(string NmCurso)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Curso/NmCurso/" + NmCurso)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            this.VerificarErro(json);

            List<Nsf.App.Model.CursoModel> lista = JsonConvert.DeserializeObject<List<Nsf.App.Model.CursoModel>>(json);

            return lista;
        }

        public List<Nsf.App.Model.CursoModel> ConsultarPorSigla(string Sigla)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Curso/Sigla/" + Sigla)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            this.VerificarErro(json);

            List<Nsf.App.Model.CursoModel> lista = JsonConvert.DeserializeObject<List<Nsf.App.Model.CursoModel>>(json);

            return lista;

        }

        public void Alterar(Nsf.App.Model.CursoModel curso)
        {

            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Curso/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }


        public void Remover(int id)
        {

            HttpClient client = new HttpClient();
            var resp = client.DeleteAsync("http://localhost:5000/Curso/" + id + "/")
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }

        private void VerificarErro(string respostaApi)
        {
            if(respostaApi.Contains("codigoErro"))
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(respostaApi);
                throw new ArgumentException(erro.Mensagem);
            }
        }

    }
}

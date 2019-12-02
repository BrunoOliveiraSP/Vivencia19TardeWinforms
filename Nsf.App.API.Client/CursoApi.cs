using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class CursoApi
    {
        HttpClient client = new HttpClient();

        public void InserirCurso(Nsf.App.Model.CursoModel curso)
        {
            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Curso/", body).Result;

        }
        public List<Model.CursoModel> ListarTodos()
        {
            string json = client.GetAsync("http://localhost:5000/Curso/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Model.CursoModel> cursos = JsonConvert.DeserializeObject<List<Model.CursoModel>>(json);
            return cursos;
        }

        public List<Model.CursoModel> ConsultarPorNome(string nome)
        {
            string json = client.GetAsync("http://localhost:5000/Curso/nome" + nome)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Model.CursoModel> cursos = JsonConvert.DeserializeObject<List<Model.CursoModel>>(json);
            return cursos;
        }

        public void Remover(int id)
        {
            var resp = client.DeleteAsync("http://localhost:5000/Curso/" + id).Result;
        }
    }
}

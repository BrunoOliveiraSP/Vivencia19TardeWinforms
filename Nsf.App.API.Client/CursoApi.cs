﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class CursoAPI
    {
        HttpClient client = new HttpClient();

        public int Inserir(Nsf.App.Model.CursoModel curso)
        {
            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Curso/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);

            int id = JsonConvert.DeserializeObject<int>(resp);

            return id;
        }

        public List<Nsf.App.Model.CursoModel> ConsultarTodos()
        {
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
            var resp = client.DeleteAsync("http://localhost:5000/Curso/" + id + "/")
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }

        private void VerificarErro(string respostaApi)
        {
            if (respostaApi.Contains("codigoErro"))
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(respostaApi);
                throw new ArgumentException(erro.Mensagem);
            }
        }
        public Model.CursoModel ConsultarCurso(int id)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage respostaApi = client.GetAsync("http://localhost:5000/Curso/ConsultarCurso/" + id)
                                        .Result;

            string jsonResposta = VerificarErroCorreto(respostaApi);

            return JsonConvert.DeserializeObject<Model.CursoModel>(jsonResposta);
        }

        private string VerificarErroCorreto(HttpResponseMessage respostaAPI)
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

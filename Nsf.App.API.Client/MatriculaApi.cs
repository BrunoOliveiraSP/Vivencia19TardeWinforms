﻿using Newtonsoft.Json;
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
        public void Inserir(Nsf.App.Model.MatriculaRequest matricula)
        {
            HttpClient client = new HttpClient();

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
            HttpClient client = new HttpClient();

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
            HttpClient client = new HttpClient();

            var resp = client.DeleteAsync("http://localhost:5000/Matricula/" + id)
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

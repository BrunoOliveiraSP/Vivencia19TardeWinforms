﻿using Newtonsoft.Json;
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

            VerificarErro(resp);
        }

        public List<Models.InscricaoModel> ConsultarTodos()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Inscricao/ConsultarTodos")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            VerificarErro(json);

            return JsonConvert.DeserializeObject<List<Models.InscricaoModel>>(json);
        }

        private void Alterar(Models.InscricaoModel inscricao)
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

        private void Remover(int id)
        {
            HttpClient client = new HttpClient();

            var resp = client.DeleteAsync("http://localhost:5000/Inscricao" + id)
                            .Result
                            .Content
                            .ReadAsStringAsync()
                            .Result;

            this.VerificarErro(resp);
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

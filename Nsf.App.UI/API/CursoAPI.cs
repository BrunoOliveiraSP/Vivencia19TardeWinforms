﻿using Newtonsoft.Json;
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
        public void Inserir(Nsf.App.Model.CursoModel curso)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");
            
            var resp = client.PostAsync("http://localhost:5000/Curso/", body).Result;
        }
    }
}

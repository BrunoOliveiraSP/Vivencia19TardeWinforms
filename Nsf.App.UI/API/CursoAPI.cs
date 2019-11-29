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
        public void Inserir(CursoAPI curso)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(curso);
            StringContent body = new StringContent()
            
            var resp = client.PostAsync("http://localhost:5000/Curso/");
        }
    }
}

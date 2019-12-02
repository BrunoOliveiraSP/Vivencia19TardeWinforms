using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class TurmaApi
    {
        HttpClient client = new HttpClient();

        public void CadastrarTurma(Nsf.App.Model.TurmaModel turma)
        {  
            string json = JsonConvert.SerializeObject(turma);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Turma/", body)
                 .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result; 
        }

        public List<Nsf.App.Model.TurmaModel> ListarTodos()
        {
            string json = client.GetAsync("http://localhost:5000/Turma")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.TurmaModel > lista = JsonConvert.DeserializeObject<List<Nsf.App.Model.TurmaModel >> (json);

            return lista;
        }

        public void Remover(int id)
        {
            var resp = client.DeleteAsync("http://localhost:5000/Turma/" + id).Result;
        }

        public void Alterar(Nsf.App.Model.TurmaModel turma)
        {
            string json = JsonConvert.SerializeObject(turma);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Turma/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;
        }
    }
}

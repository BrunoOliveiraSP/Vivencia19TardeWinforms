using Newtonsoft.Json;
using Nsf.App.API.Client.Abstract;
using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class ProfessorAPI : ICrud<ProfessorModel>
    {
        HttpClient _client;
        public void Alterar(ProfessorModel professor)
        {
            _client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = _client.PutAsync("http://localhost:5000/Professor", body).Result;
        }

        public List<ProfessorModel> ListarTodos()
        {
            _client = new HttpClient();

            var json = _client.GetAsync("http://localhost:5000/Professor").Result.Content.ReadAsStringAsync().Result;

            List<ProfessorModel> professores = JsonConvert.DeserializeObject<List<ProfessorModel>>(json);
            return professores;
        }

        public List<ProfessorModel> ListarPorNome(string nome)
        {
            _client = new HttpClient();

            var json = _client.GetAsync("http://localhost:5000/Professor/Nome/" + nome).Result
                                                                 .Content.ReadAsStringAsync().Result;

            List<ProfessorModel> professores = JsonConvert.DeserializeObject<List<ProfessorModel>>(json);
            return professores;
        }

        public void Remover(int id)
        {
            _client = new HttpClient();
            var resp = _client.DeleteAsync("http://localhost:5000/Atividade/" + id).Result;
        }

        public void Salvar(ProfessorModel professor)
        {
            _client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = _client.PostAsync("http://localhost:5000/Professor", body).Result;
        }
    }
}

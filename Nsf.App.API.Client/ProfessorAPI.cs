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
    public class ProfessorAPI
    {
        HttpClient _client;

        #region|Listar|
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

        public List<LoginModel> ListarPorID(int id)
        {
            _client = new HttpClient();

            var json = _client.GetAsync("http://localhost:5000/Professor/Id/" + id).Result
                                                                .Content.ReadAsStringAsync().Result;

            List<LoginModel> login = JsonConvert.DeserializeObject<List<LoginModel>>(json);
            return login;
        }
        #endregion

        public void Alterar(ProfessorRequest professor)
        {
            _client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = _client.PutAsync("http://localhost:5000/Professor", body).Result;
        }

        public void Remover(int idProfessor, int idLogin)
        {
            _client = new HttpClient();
            var resp = _client.DeleteAsync("http://localhost:5000/Atividade/" + idProfessor + "/" + idLogin).Result;
        }



        public Model.ProfessorRequest Inserir(ProfessorRequest professor)
        {
            _client = new HttpClient();

            string json = JsonConvert.SerializeObject(professor);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = _client.PostAsync("http://localhost:5000/Professor", body).Result;

            return professor;
        }

    }
}

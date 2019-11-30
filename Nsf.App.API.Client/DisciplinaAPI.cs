using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public  class DisciplinaAPI
    {

        public void Inserir(Nsf.App.Model.DisciplinaModel disci)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disci);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Disciplina", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }
       
        
        public List<Nsf.App.Model.DisciplinaModel> Listar()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/ListarTodos")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<List<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
        }


        public List<Nsf.App.Model.DisciplinaModel> Consultar(string nome, string sigla)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/ListarNomeSigla/" + nome + "/" + sigla)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            List<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<List<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
        }


        public void Alterar(Model.DisciplinaModel disciplina)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disciplina);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/AlterarDisciplina", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }

        public void Remover(int id)
        {
            HttpClient client = new HttpClient();
            var resp = client.DeleteAsync("http://localhost:5000/Deletar/" + id).Result;
        }


        private void VerificarErro(string respostaAPI)
        {
            if (respostaAPI.Contains("codigoErro"))
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(respostaAPI);
                throw new ArgumentException(erro.Mensagem);
            }
        }
    }
}

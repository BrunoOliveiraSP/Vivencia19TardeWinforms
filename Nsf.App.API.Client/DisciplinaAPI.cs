using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public  class DisciplinaAPI
    {
        

        public Model.DisciplinaModel Inserir(Nsf.App.Model.DisciplinaModel disci)
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

            disci = JsonConvert.DeserializeObject<Model.DisciplinaModel>(resp);
            return disci;
        }
       
         
        public BindingList<Nsf.App.Model.DisciplinaModel> Listar()
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/ListarTodos/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            BindingList<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<BindingList<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
        }


        public BindingList<Nsf.App.Model.DisciplinaModel> Consultar(string nome, string sigla)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/ListarNomeSigla/" + nome + "/" + sigla + "/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            BindingList<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<BindingList<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
        }


        public void Alterar(Model.DisciplinaModel disciplina)
        {
            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(disciplina);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PutAsync("http://localhost:5000/Disciplina", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
        }

        public void Remover(int id)
        {
            HttpClient client = new HttpClient();
            var resp = client.DeleteAsync("http://localhost:5000/Disciplina/" + id + "/").Result;
        }
        public void InserirCursoDisciplina(Nsf.App.Model.CursoDisciplinaModel cd)
        {

            HttpClient client = new HttpClient();

            string json = JsonConvert.SerializeObject(cd);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = client.PostAsync("http://localhost:5000/Disciplina/InserirCursoDisciplina/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);
        }
        public void RemoverCursoDisciplina(int idcurso)
        {

            HttpClient client = new HttpClient();
            
            var resp = client.DeleteAsync("http://localhost:5000/Disciplina/RemoverDisciplinasCurso" + "/" + idcurso + "/")
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            VerificarErro(resp);

            
        }
        public BindingList<Nsf.App.Model.DisciplinaModel> ListarCursoDisciplina(int id)
        {
            HttpClient client = new HttpClient();

            string json = client.GetAsync("http://localhost:5000/Disciplina/ListarCursoDisciplina/" + id + "/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            BindingList<Nsf.App.Model.DisciplinaModel> lista =
                JsonConvert.DeserializeObject<BindingList<Nsf.App.Model.DisciplinaModel>>(json);

            return lista;
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

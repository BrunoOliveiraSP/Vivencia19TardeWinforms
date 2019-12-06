using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Nsf.App.API.Client
{
    public class SalaAPI
    {
        HttpClient client = new HttpClient();
        public List<Model.SalaModel> ConsultaPorInstituicao(string instituicao)
        {
            string json = client.GetAsync("http://localhost:5000/Sala/ListarNome/" + instituicao)
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;
            List<Model.SalaModel> tabela = JsonConvert.DeserializeObject<List<Model.SalaModel>>(json);
            return tabela;                                      

        }
        public void inserir(Model.SalaModel api)
        {
            HttpClient cliente = new HttpClient();

            string json = JsonConvert.SerializeObject(api);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = cliente.PostAsync("http://localhost:5000/Sala/Inserir/", body).Result;
        }
        public List<Model.SalaModel> ListarTudo()
        {
            

            string json = client.GetAsync("http://localhost:5000/Sala/ListarTudo")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;
            List<Model.SalaModel> tabela = JsonConvert.DeserializeObject<List<Model.SalaModel>>(json);
            return tabela;
        }
        public void Remover(int id)
        {
            

            var resp = client.DeleteAsync("http://localhost:5000/Sala/Remover/" + id).Result;
        }
        public void alterar(Model.SalaModel tabela)
        {
            string json = JsonConvert.SerializeObject(tabela);

            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");
            var res = client.PutAsync("http://localhost/5000/Sala/Alterar", body).Result;

        }
    }
}


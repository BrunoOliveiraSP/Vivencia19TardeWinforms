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
        HttpClient cliente = new HttpClient();
        public void inserir(Model.SalaModel tabela)
        {
            string json = JsonConvert.SerializeObject(tabela);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");



            var res = cliente.PostAsync("http://localhost/5000/Sala/", body).Result.Content.ReadAsStringAsync().Result;



        }
        public void AviriguarErro(string ResApi)
        {
            if (ResApi.Contains("Codifo Do Erro"))
            {
                //Model.ErrorModel erro = JsonConvert.DeserializeObject<Model.ErrorModel>(ResApi);
                //throw new ArgumentException(erro.Mensagem);
            }
        }
        public List<Model.SalaModel> Listar()
        {
            string json = cliente.GetAsync("http://localhost/5000/Sala/").Result.Content.ReadAsStringAsync().Result;
            List<Model.SalaModel> tabela = JsonConvert.DeserializeObject<List<Model.SalaModel>>(json);
            return tabela;


        }

    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.API.Client
{
    public class SalaVestibularAPI
    {
        public List<Model.SalaVestibularModel> listarTudo()
        {
            HttpClient cliente = new HttpClient();

            string json = cliente.GetAsync("http://localhost:5000/SalaVestibular/ListarTudo/").Result.Content.ReadAsStringAsync().Result;

            List<Model.SalaVestibularModel> teste = JsonConvert.DeserializeObject<List< Model.SalaVestibularModel >>(json);
            return teste;
        }
        public void Inserir(Model.SalaVestibularModel api)
        {
            HttpClient cliente = new HttpClient();

            string json = JsonConvert.SerializeObject(api);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = cliente.PostAsync("http://localhost:5000/SalaVestibular/Inserir/", body).Result;
        }
        public void Remover(int id)
        {
            HttpClient cliente = new HttpClient();

            var resp = cliente.DeleteAsync("http://localhost:5000/SalaVestibular/Remover/" + id).Result;
        }
        public void Alterar(Model.SalaVestibularModel sala)
        {
            HttpClient cliente = new HttpClient();

            string json = JsonConvert.SerializeObject(sala);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = cliente.PutAsync("http://localhost:5000/SalaVestibular/Alterar/", body).Result;
        }

    }
}

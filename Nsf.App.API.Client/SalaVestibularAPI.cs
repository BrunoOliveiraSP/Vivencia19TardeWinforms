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
        HttpClient cliente = new HttpClient();

        public List<Model.SalaVestibularModel> listarTudo()
        {

            string json = cliente.GetAsync("http://localhost:5000/SalaVestibular/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            this.VerificarErro(json);
                                                                                                
            List<Model.SalaVestibularModel> teste = JsonConvert.DeserializeObject<List< Model.SalaVestibularModel >>(json);
            return teste;
        }
        public void  Inserir(Model.SalaVestibularModel request)
        {

            string json = JsonConvert.SerializeObject(request);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage resp = cliente.PostAsync("http://localhost:5000/SalaVestibular/", body).Result;



            
        }
           
        public void Remover(int id)
        {

            var resp = cliente.DeleteAsync("http://localhost:5000/SalaVestibular/Remover/" + id).Result;
                             
                             

          
        }
        public void Alterar(Model.SalaVestibularModel sala)
        {           

            string json = JsonConvert.SerializeObject(sala);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            var resp = cliente.PutAsync("http://localhost:5000/SalaVestibular/", body)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;
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

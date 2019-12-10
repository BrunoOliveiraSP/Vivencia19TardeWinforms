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

        public List<Model.SalaVestibualrResponse> listarTudo()
        {

            string json = cliente.GetAsync("http://localhost:5000/SalaVestibular/")
                                .Result
                                .Content
                                .ReadAsStringAsync()
                                .Result;

            this.VerificarErro(json);
                                                                                                
            List<Model.SalaVestibualrResponse> teste = JsonConvert.DeserializeObject<List< Model.SalaVestibualrResponse>>(json);
            return teste;
        }
        public Model.SalaVestibularRequest Inserir(Model.SalaVestibularRequest request)
        {

            string json = JsonConvert.SerializeObject(request);
            StringContent body = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage resp = cliente.PostAsync("http://localhost:5000/SalaVestibular/", body).Result;

            string jsonresposta = LerJsonDeResposta(resp);
            request = JsonConvert.DeserializeObject<Model.SalaVestibularRequest>(jsonresposta);

            return request;
        }
           
        public void Remover(int id)
        {

            var resp = cliente.DeleteAsync("http://localhost:5000/SalaVestibular/Remover/" + id)
                             .Result
                             .Content
                             .ReadAsStringAsync()
                             .Result;

            this.VerificarErro(resp);
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

        private string LerJsonDeResposta(HttpResponseMessage respoosta)
        {
            string jsonResposta = respoosta.Content.ReadAsStringAsync().Result;

            if(respoosta.IsSuccessStatusCode == false)
            {
                Model.ErroModel erro = JsonConvert.DeserializeObject<Model.ErroModel>(jsonResposta);
                throw new ArgumentException(erro.Mensagem);
            }
            return jsonResposta;
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

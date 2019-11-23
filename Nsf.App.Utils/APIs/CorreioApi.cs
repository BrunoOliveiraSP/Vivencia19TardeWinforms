using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Utils.APIs
{
    public class CorreioApi
    {
        public bool BuscarAPICorreio(string cep, out CorreioResponse response)
        {
            response = null;

            try
            {
                WebClient rest = new WebClient();
                rest.Encoding = Encoding.UTF8;

                cep = cep.Trim().Replace("-", "");
                if (cep.Length < 8)
                    return false;

                string resposta = rest.DownloadString("https://viacep.com.br/ws/" + cep + "/json");

                response = JsonConvert.DeserializeObject<CorreioResponse>(resposta);
                if (response == null)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }


    public class CorreioResponse
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
    }

}

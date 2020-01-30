using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace ProjetoContaBancaria.Application
{
    public class ClienteAppService
    {
        public HttpResponseMessage Delete(int id)
        {
            string URL = "http://localhost:19868/api/Conta" + "?id=" + id.ToString();
            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync(URL).Result;


            return response;
        }
        public Cliente Get(string Nom_Consulta)
        {
            throw new NotImplementedException();
        }

        public string Post(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Put(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}

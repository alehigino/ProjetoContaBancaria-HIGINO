using ProjetoContaBancaria.Domain.Entities;
using System.Net.Http;

namespace ProjetoContaBancaria.Application
{
    public class ClienteApplication
    {
        private Contexto contexto;
        private string URLBase = "https://localhost:44342/api/cliente";
        public HttpResponseMessage Delete(int Num_Cpf)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "?Num_Cpf=" + Num_Cpf.ToString();
                return contexto.RequestDelete(URL);
            }
        }

        public HttpResponseMessage Get(string Nom_Consulta)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "?Nom_Consulta=" + Nom_Consulta;
                return contexto.RequestGet(URL);
            }
        }

        public HttpResponseMessage Post(Cliente cliente)
        {
            using (contexto = new Contexto())
            {
                return contexto.RequestPost(URLBase, cliente);
            }
        }

        public HttpResponseMessage Put(Cliente cliente)
        {
            using (contexto = new Contexto())
            {
                return contexto.RequestPut(URLBase, cliente);
            }
        }
        public HttpResponseMessage ConsLogin(string Nom_Consulta, string Nom_Senha)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/conslogin?Nom_Consulta=" + Nom_Consulta + "&Nom_Senha=" + Nom_Senha;
                return contexto.RequestGet(URL);
            }
        }
    }
}

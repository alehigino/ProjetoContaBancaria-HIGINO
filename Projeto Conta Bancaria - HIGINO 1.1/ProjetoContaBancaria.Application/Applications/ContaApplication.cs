using ProjetoContaBancaria.Domain.Entities;
using System.Net.Http;

namespace ProjetoContaBancaria.Application
{
    public class ContaApplication
    {
        private Contexto contexto;
        private string URLBase = "https://localhost:44342/api/conta";

        public HttpResponseMessage Delete(int Num_Conta)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "?Num_Conta=" + Num_Conta.ToString();
                return contexto.RequestDelete(URL);
            }
        }
        public HttpResponseMessage Get(int Num_Conta)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "?Num_Conta=" + Num_Conta.ToString();
                return contexto.RequestGet(URL);
            }
        }
        public HttpResponseMessage Post(Conta conta)
        {
            using (contexto = new Contexto())
            {
                return contexto.RequestPost(URLBase, conta);
            }
        }

        public HttpResponseMessage GetContas(int Num_Cpf)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/getcontas?Num_Cpf=" + Num_Cpf.ToString();
                return contexto.RequestGet(URL);
            }
        }
    }
}

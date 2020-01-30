using ProjetoContaBancaria.Domain.Entities;
using System.Net.Http;

namespace ProjetoContaBancaria.Application.Applications
{
    public class OperacaoApplication
    {
        private Contexto contexto;
        private string URLBase = "https://localhost:44342/api/operacao";

        public HttpResponseMessage Deposito(Operacao operacao)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/deposito";
                return contexto.RequestPost(URL, operacao);
            }
        }
        public HttpResponseMessage Saque(Operacao operacao)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/saque";
                return contexto.RequestPost(URL, operacao);
            }
        }
        public HttpResponseMessage Transferencia(Operacao operacao, int Num_Conta_Env)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/transferencia?Num_Conta_Env=" + Num_Conta_Env.ToString();
                return contexto.RequestPost(URL, operacao);
            }
        }
        public HttpResponseMessage Extrato(int Num_Conta)
        {
            using (contexto = new Contexto())
            {
                string URL = URLBase + "/extrato?Num_Conta=" + Num_Conta.ToString();
                return contexto.RequestGet(URL);
            }
        }
    }
}

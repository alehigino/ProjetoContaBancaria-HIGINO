using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using System.Data.SqlClient;

namespace ProjetoContaBancaria.Repository.Repositories
{
    public class OperacaoRepository : IOperacaoRepository
    {
        private Contexto contexto;
        SqlCommand cmd;
        public string Post(Operacao operacao)
        {
            throw new System.NotImplementedException();
        }

        public void Deposito(Operacao operacao)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "OpDeposito";
                cmd.Parameters.AddWithValue("@Vlr_Valor", operacao.Vlr_Operacao);
                cmd.Parameters.AddWithValue("@Num_Conta", operacao.Num_Conta);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }
        }
        public void Saque(Operacao operacao)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "OpSaque";
                cmd.Parameters.AddWithValue("@Vlr_Valor", operacao.Vlr_Operacao);
                cmd.Parameters.AddWithValue("@Num_Conta", operacao.Num_Conta);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }
        }

        public int Transferencia(Operacao operacao, int Num_Conta_Env)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "OpTransferencia";
                cmd.Parameters.AddWithValue("@Num_Conta_Env", operacao.Num_Conta);
                cmd.Parameters.AddWithValue("@Num_Conta_Rec", operacao.Num_Aux);
                cmd.Parameters.AddWithValue("@Vlr_Valor", operacao.Vlr_Operacao);

                using (contexto = new Contexto())
                {
                    return contexto.ExecutaProcedureRetorno(cmd);
                }
            }
        }
    }
}

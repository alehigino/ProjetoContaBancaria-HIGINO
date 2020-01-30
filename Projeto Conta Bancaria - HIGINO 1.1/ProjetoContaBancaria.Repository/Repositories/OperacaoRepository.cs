using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoContaBancaria.Repository.Repositories
{
    public class OperacaoRepository : IOperacaoRepository
    {
        private Contexto contexto;
        SqlCommand cmd;

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

        public List<Operacao> Extrato(int Num_Conta)
        {
            List<Operacao> operacoes = new List<Operacao>();

            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "OpExtrato";
                cmd.Parameters.AddWithValue("@Num_Conta", Num_Conta);


                using (contexto = new Contexto())
                {
                    SqlDataReader dados = contexto.ExecutaComandoRetorno(cmd);

                    while (dados.Read())
                    {
                        operacoes.Add(new Operacao
                        {
                            Nom_Tipo = dados["Nom_Tipo"].ToString(),
                            Dat_Realizacao = Convert.ToDateTime(dados["Dat_Realizacao"]),
                            Vlr_Operacao = Convert.ToDecimal(dados["Vlr_Operacao"]),
                            Num_Conta = Convert.ToInt32(dados["Num_Conta"])
                        });
                    }
                }
            }
            return operacoes;
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
                cmd.Parameters.AddWithValue("@Num_Conta_Rec", Num_Conta_Env);
                cmd.Parameters.AddWithValue("@Vlr_Valor", operacao.Vlr_Operacao);

                using (contexto = new Contexto())
                {
                    return contexto.ExecutaProcedureRetorno(cmd);
                }
            }
        }
    }
}

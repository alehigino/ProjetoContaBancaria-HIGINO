using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using System;
using System.Data.SqlClient;

namespace ProjetoContaBancaria.Repository.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private Contexto contexto;
        SqlCommand cmd;
        public void Delete(int Num_Conta)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "DelConta";
                cmd.Parameters.AddWithValue("@Num_Conta", Num_Conta);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }
        }

        public Conta Get(int Num_Conta)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "SelDadosConta";
                cmd.Parameters.AddWithValue("@Num_Conta", Num_Conta);

                using (contexto = new Contexto())
                {
                    SqlDataReader dados = contexto.ExecutaComandoRetorno(cmd);

                    if (dados.Read())
                    {
                        var conta = new Conta
                        {
                            Num_Conta = Convert.ToInt32(dados["Num_Conta"]),
                            Vlr_Saldo = Convert.ToDecimal(dados["Vlr_Saldo"]),
                            Dat_Criacao = Convert.ToDateTime(dados["Dat_Criacao"]),
                            Ind_Tipo = Convert.ToChar(dados["Ind_Tipo"]),
                            Num_Cpf = Convert.ToInt32(dados["Num_Cpf"])
                        };
                        return conta;
                    }
                    else
                        return null;
                }
            }
        }

        public string Post(Conta conta)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "InsContas";
                cmd.Parameters.AddWithValue("@Dat_Criacao", conta.Dat_Criacao);
                cmd.Parameters.AddWithValue("@Ind_Tipo", conta.Ind_Tipo);
                cmd.Parameters.AddWithValue("@Num_Cpf", conta.Num_Cpf);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }

            return "";
        }

    }
}

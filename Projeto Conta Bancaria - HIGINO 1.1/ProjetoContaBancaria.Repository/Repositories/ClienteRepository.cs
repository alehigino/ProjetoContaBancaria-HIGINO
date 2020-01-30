using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using System;
using System.Data.SqlClient;

namespace ProjetoContaBancaria.Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private Contexto contexto;
        SqlCommand cmd;
        public void Delete(int Num_Cpf)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "DelCliente";
                cmd.Parameters.AddWithValue("@Num_Cpf", Num_Cpf);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }
        }

        public Cliente Get(string Nom_Consulta)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "SelDados";
                cmd.Parameters.AddWithValue("@Nom_Consulta", Nom_Consulta);

                using (contexto = new Contexto())
                {
                    SqlDataReader dados = contexto.ExecutaComandoRetorno(cmd);

                    if (dados.Read())
                    {
                        var cliente = new Cliente
                        {
                            Num_Cpf = Convert.ToInt32(dados["Num_Cpf"]),
                            Nom_Cliente = dados["Nom_Cliente"].ToString(),
                            Nom_Email = dados["Nom_Cliente"].ToString(),
                            Dat_Nasc = Convert.ToDateTime(dados["Dat_Nasc"]),
                            Ind_Sexo = Convert.ToChar(dados["Ind_Sexo"]),
                            Nom_Login = dados["Nom_Login"].ToString(),
                            Nom_Senha = dados["Nom_Senha"].ToString()
                        };
                        return cliente;
                    }
                    else
                        return null;
                }
            }
        }

        public string Post(Cliente cliente)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "InsClientes";
                cmd.Parameters.AddWithValue("@Num_Cpf", cliente.Num_Cpf);
                cmd.Parameters.AddWithValue("@Nom_Cliente", cliente.Nom_Cliente);
                cmd.Parameters.AddWithValue("@Nom_Email", cliente.Nom_Email);
                cmd.Parameters.AddWithValue("@Dat_Nasc", cliente.Dat_Nasc);
                cmd.Parameters.AddWithValue("@Ind_Sexo", cliente.Ind_Sexo);
                cmd.Parameters.AddWithValue("@Nom_Login", cliente.Nom_Login);
                cmd.Parameters.AddWithValue("@Nom_Senha", cliente.Nom_Senha);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }

            return "";
        }

        public void Put(Cliente cliente)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "UpdClientes";
                cmd.Parameters.AddWithValue("@Nom_Email", cliente.Nom_Email);
                cmd.Parameters.AddWithValue("@Num_Cpf", cliente.Num_Cpf);
                cmd.Parameters.AddWithValue("@Nom_Cliente", cliente.Nom_Cliente);
                cmd.Parameters.AddWithValue("@Dat_Nasc", cliente.Dat_Nasc);
                cmd.Parameters.AddWithValue("@Ind_Sexo", cliente.Ind_Sexo);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(cmd);
                }
            }
        }
        public int VerificaDados(Cliente cliente)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "ConsDados";
                cmd.Parameters.AddWithValue("@Num_Cpf", cliente.Num_Cpf);
                cmd.Parameters.AddWithValue("@Nom_Email", cliente.Nom_Email);
                cmd.Parameters.AddWithValue("@Nom_Login", cliente.Nom_Login);

                using (contexto = new Contexto())
                {
                    return contexto.ExecutaProcedureRetorno(cmd);
                }
            }
        }

        public int ConsLogin(string Nom_Consulta, string Nom_Senha)
        {
            using (cmd = new SqlCommand())
            {
                cmd.CommandText = "ConsLogin";
                cmd.Parameters.AddWithValue("@Nom_Consulta", Nom_Consulta);
                cmd.Parameters.AddWithValue("@Nom_Senha", Nom_Senha);

                using (contexto = new Contexto())
                {
                    return contexto.ExecutaProcedureRetorno(cmd);
                }
            }
        }

    }
}

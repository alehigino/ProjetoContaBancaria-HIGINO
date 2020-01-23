using System;

namespace ProjetoContaBancaria.Domain.Entities
{
	public class Cliente
	{
		public int Num_Cpf { get; set; }
		public string Nom_Cliente { get; set; }
		public string Nom_Email { get; set; }
		public DateTime Dat_Nasc { get; set; }
		public char Ind_Sexo { get; set; }
		public string Nom_Login { get; set; }
		public string Nom_Senha { get; set; }
	}
}

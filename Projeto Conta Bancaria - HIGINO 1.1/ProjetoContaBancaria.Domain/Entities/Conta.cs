using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.Domain.Entities
{
    public class Conta
    {
        public int Num_Conta { get; set; }
        public decimal Vlr_Saldo { get; set; }
        public DateTime Dat_Criacao { get; set; }
        public char Ind_Tipo { get; set; }
        public int Num_Cpf { get; set; }
    }
}

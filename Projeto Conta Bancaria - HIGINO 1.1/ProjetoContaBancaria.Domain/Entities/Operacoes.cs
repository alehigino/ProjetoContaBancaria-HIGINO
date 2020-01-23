using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.Domain.Entities
{
    public class Operacoes
    {
        public char Ind_Tipo { get; set; }
        public DateTime Dat_Realizacao { get; set; }
        public decimal Vlr_Operacao { get; set; }
        public int Num_Conta { get; set; }
    }
}

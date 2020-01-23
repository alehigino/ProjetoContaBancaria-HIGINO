using System;

namespace ProjetoContaBancaria.Domain.Entities
{
    public class Operacao
    {
        public string Nom_Tipo { get; set; }
        public DateTime Dat_Realizacao { get; set; }
        public decimal Vlr_Operacao { get; set; }
        public int Num_Conta { get; set; }
        public int Num_Aux { get; set; }
    }
}

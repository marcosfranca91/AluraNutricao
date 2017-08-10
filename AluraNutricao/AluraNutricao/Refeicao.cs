using System;
using System.Collections.Generic;
using System.Text;

namespace AluraNutricao
{
    public class Refeicao
    {
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Refeicao(string descricao,double calorias)
        {
            this.Descricao = descricao;
            this.Calorias = calorias;
        }
    }
}

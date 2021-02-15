using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Fixacao
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public string Aprovacao()
        {
            if (Media() >= 60.00)
                return "APROVADO";
            else
            {
                double res = 60.00 - Media();
                return "REPROVADO\nFALTARAM " + res.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

        }
        public override string ToString()
        {
            return "NOTA FINAL = " + Media().ToString("F2", CultureInfo.InvariantCulture) + 
                "\n" + Aprovacao();
        }
    }
}

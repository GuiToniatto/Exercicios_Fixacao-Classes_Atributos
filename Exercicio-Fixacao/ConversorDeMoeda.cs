using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ConverterMoeda(double valor, double cotacao)
        {
            return (valor * cotacao) + (valor * cotacao) * Iof / 100;
        }
    }
}

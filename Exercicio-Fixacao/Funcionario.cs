using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public static class Operacoes
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round((peso / (altura * altura)), 2);
        }

        public static String ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            // else if (imc > 18.5 && imc < 25)
            else if (imc < 25)
            {
                return "Peso Normal";
            }
            // else if (imc > 25 && imc < 30)
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            // else if (imc > 30 && imc < 35)
            else if (imc < 35)
            {
                return "Obesidade Grau I";
            }
            // else if (imc > 35 && imc < 40)
            else if (imc < 40)
            {
                return "Obesidade GrauII";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }
    }
}

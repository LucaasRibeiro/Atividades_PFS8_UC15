using CalculadoraIMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass]
    public class ClassificarIMCTest
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            double imc = 28;

            var classificarIMC = Operacoes.ClassificarIMC(imc);

            Assert.AreEqual("Sobrepeso", classificarIMC);
        }
            
     }
}

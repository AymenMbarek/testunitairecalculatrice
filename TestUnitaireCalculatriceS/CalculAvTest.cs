using Calculatrice;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireCalculatriceS
{
    class CalculAvTest
    {
       
        private CalculAvances calav;
        //Valeur absolue test 
        [TestCase(1)]
        public void ValeurAbsolueTest(double x, User user)
        {
            calav = new CalculAvances();

            var result = calav.ValeurAbsolue(x, user);

            Assert.AreEqual(result, awaitedresult);
        }
    }
}

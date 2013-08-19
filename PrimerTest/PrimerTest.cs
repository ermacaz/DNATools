using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DNATools;

namespace PrimerTest
{
    [TestClass]
    public class PrimerTest
    {
        private string sequence = "AGCTAGCTAGCTAGCTAGCAAGCAA";
        
        [TestMethod]
        public void Primer_TmCalc_Test()
        {
            Primer testPrimer = new Primer(sequence);
            double expectedTm = 54.5;
            double na = 50; //50mM Na+

            Assert.AreEqual(expectedTm, testPrimer.Tm(na), 0.5);
        }
    }
}

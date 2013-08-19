using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DNATools;
namespace DNATest
{
    [TestClass]
    public class DNATest
    {
        private const string sequence = "AGTCCGTG";

        [TestMethod]
        public void DNA_Reverse_Test()
        {
            DNA testDNA = new DNA(sequence);
            string expectedReverse = "GTGCCTGA";

            Assert.AreEqual(expectedReverse, testDNA.Reverse());
        }

        [TestMethod]
        public void DNA_Complement_Test()
        {
            DNA testDNA = new DNA(sequence);
            string expectedComplement = "TCAGGCAC";
            Assert.AreEqual(expectedComplement, testDNA.Complement());
        }

        [TestMethod]
        public void DNA_Parallel_Test()
        {
            DNA testDNA = new DNA(sequence);
            string expectedParallel = "CACGGACT";

            Assert.AreEqual(expectedParallel, testDNA.Parallel());
        }

        [TestMethod]
        public void DNA_Translate_test()
        {
            DNA testDNA = new DNA(sequence);
            string expectedTranslate = "SP";
            Assert.AreEqual(expectedTranslate, testDNA.Translate());
        }

        [TestMethod]
        public void DNA_Clean_test()
        {
            string unclean = "a gg tc22 9;.,1\\ccGcA";
            string expectedClean = "AGGTCCCGCA";
            DNA testDNA = new DNA(unclean);

            testDNA.Clean();
            Assert.AreEqual(expectedClean, testDNA.Sequence);
        }

        [TestMethod]
        public void DNA_GCFraction_Test()
        {
            DNA testDNA = new DNA(sequence);
            double expectedGC = 0.625;

            Assert.AreEqual(expectedGC, testDNA.GcFraction());
        }
    }
}

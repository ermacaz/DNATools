using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************
 * Matt Hamada
 * Sequence Tools
 * 2013
 * Primer.cs
 * ******************/
namespace DNATools
{
    /// <summary>
    /// Primer class is a subclass of DNA class.  Can calculate its Tm.
    /// </summary>
    public class Primer : DNA
    {
        public Primer(string newSeq) :base(newSeq)
        {
        }

        public override string ToString()
        {
            return Sequence;
        }

        /// <summary>
        /// Caculates the change in enthalpy of the primer during binding
        /// helper for Tm calculation
        /// Adapted from SantaLucia et. al., Annu. Rev. Biophys. Biomol. Struct. 2004. 33:415–40
        /// </summary>
        /// <returns>A double of the change in enthalpy</returns>
        private double GetH()
        {
            string seq = Sequence;

            double dH = 0;
            Dictionary<string, double> H_values = new Dictionary<string, double>()
            {
                {"GT", -8.40}, // GT_CA
                {"TG", -8.50}, // TG_AC
                {"AG", -7.80}, // AG_TC
                {"CA", -8.50}, // CA_GT
                {"AT", -7.20}, // AT_TA
                {"TC", -8.20}, // TC_GA
                {"AA", -7.90}, // AA_TT
                {"CG", -10.60}, // CG_GC
                {"GA", -8.20}, // GA_CT
                {"CC", -8.00}, // CC_GG
                {"GG", -8.00}, // GG_CC
                {"AC", -8.40}, // AC_TG
                {"TT", -7.90}, // TT_AA
                {"CT", -7.80}, // CT_GA
                {"TA", -7.20}, // TA_AT
                {"GC", -10.60}, // GC_CG
            };
            for (int i = 0; i < seq.Length - 1; i++)
            {
                if (H_values.ContainsKey(seq.Substring(i, 2)))
                    dH += H_values[seq.Substring(i, 2)];

            }
            if (seq[0] == 'A' || seq[0] == 'T')
                dH += 2.3;
            if (seq[seq.Length - 1] == 'A' || seq[seq.Length - 1] == 'T')
                dH += 2.3;
            if (seq[0] == 'G' || seq[0] == 'C')
                dH += 0.1;
            if (seq[seq.Length - 1] == 'G' || seq[seq.Length - 1] == 'C')
                dH += 0.1;

            return dH;
        }

        /// <summary>
        /// Caculates the change in entropy of the primer during binding
        /// helper for Tm calculation
        /// Adapted from SantaLucia et. al., Annu. Rev. Biophys. Biomol. Struct. 2004. 33:415–40
        /// </summary>
        /// <returns>A double of the change in entropy</returns>
        private double GetS()
        {
            string seq = Sequence;
            string seqComp = Complement();
            double deltaS = 0;
            Dictionary<string, double> S_values = new Dictionary<string, double>()
            {
                {"GT", -22.40}, // GT_CA
                {"TG", -22.70}, // TG_AC
                {"AG", -21.00}, // AG_TC
                {"CA", -22.70}, // CA_GT
                {"AT", -20.40}, // AT_TA
                {"TC", -22.20}, // TC_GA
                {"AA", -22.00}, // AA_TT
                {"CG", -27.20}, // CG_GC
                {"GA", -22.20}, // GA_CT
                {"CC", -19.90}, // CC_GG
                {"GG", -19.90}, // GG_CC
                {"AC", -22.40}, // AC_TG
                {"TT", -22.20}, // TT_AA
                {"CT", -21.00}, // CT_GA
                {"TA", -21.30}, // TA_AT
                {"GC", -24.40}, // GC_CG
            };
            for (int i = 0; i < seq.Length - 1; i++)
            {
                if (S_values.ContainsKey(seq.Substring(i, 2).ToUpper()))
                    deltaS += S_values[seq.Substring(i, 2).ToUpper()];

            }
            if (seq[0] == 'A' || seq[0] == 'T')
                deltaS += 4.1;
            if (seq[seq.Length - 1] == 'A' || seq[seq.Length - 1] == 'T')
                deltaS += 4.1;
            if (seq[0] == 'G' || seq[0] == 'C')
                deltaS -= -2.8;
            if (seq[seq.Length - 1] == 'G' || seq[seq.Length - 1] == 'C')
                deltaS -= -2.8;
            if (seq.Equals(seqComp))
                deltaS -= 1.4;

            return deltaS;
        }

        /*calculate tm based on deltaH and deltaS
       First calculates tm for [1M Na+] (tmn) based on SantaLucia,J et. al.
       */
        /// <summary>
        /// Calculate tm based on deltaH and deltaS of binding
        /// First calculates tm for [1M Na+] (tmn) based on SantaLucia,J et. al.
        /// Then adjusts Tm based on a 50mM [Na+] from methods found in Owczarzy et. al Biochem 2004.
        /// </summary>
        /// <param name="na">The sodium ion concentration, in mM</param>
        /// <returns></returns>
        public double Tm(double na)
        {
            double fgc = GcFraction();
            double n = Math.Log(na / 1000.0, 2);
            double x = 1;
            if (Sequence.Equals(Complement()))
                x = 4;
            double tmn = (GetH() * 1000 / (GetS() + 1.987 * Math.Log(0.0000001 / x, Math.E)));

            double tmInv = (1 / tmn) + ((4.29 * fgc) - 3.95) * Math.Pow(10, -5) * n + (9.46 * Math.Pow(10, -6) * Math.Pow(n, 2));
            double tm = (1 / tmInv) - 273.15;
            return tm;
        }
    }


}

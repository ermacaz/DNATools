using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNATools
{
    //takes in list of enzyme strings input on GUI, returns list of ReEnzyme objects 
   
    public class CompareLists
    {
        public static List<ReEnzyme> Listcompare(List<string> str)
        {
            List<ReEnzyme> returnList = new List<ReEnzyme>();
            foreach (string stringEnz in str)
            {
                foreach (ReEnzyme enz in ReEnzyme.EnzCol)
                {
                    string sEnz = stringEnz.ToLower();
                    string eEnz = enz.Name.ToLower();
                    if (sEnz.Equals(eEnz) && !returnList.Any(Reenzyme => Reenzyme.Name == enz.Name))
                        returnList.Add(enz);

                }
            }

            return returnList;
        }

        //takes in list of enzymes in 5-3 order, returns all possible pairs obeying 5->3
        public static List<EnzPair> Pairzymes(List<ReEnzyme> inList, bool singles)
        {
            List<EnzPair> returnList = (from i in inList from j in inList where j == i && singles == false select new EnzPair { EnzF = i, EnzR = j }).ToList();
            foreach (ReEnzyme i in inList)
            {
                for (int j = inList.IndexOf(i) + 1; j < inList.Count; j++)
                {
                    EnzPair temp = new EnzPair { EnzF = i, EnzR = inList[j] };
                    returnList.Add(temp);
                }
            }
            return returnList;
        }
        //takes in list of enzymes in 5-3 order, returns all possible pairs obeying 5->3
        public static List<EnzPair> PairzymesSeparate(List<ReEnzyme> forwards, List<ReEnzyme> reverses)
        {
            return (from i in forwards from j in reverses select new EnzPair { EnzF = i, EnzR = j }).ToList();
        }

        //creates list of primer pairs
        public static List<PrimPair> PairPrimers(List<EnzPair> enzPairs, string pForward, string pReverse, int gcSize)
        {
            string gCclamp = (String.Concat(Enumerable.Repeat("GC", gcSize).ToArray()));
            return enzPairs.Select(pair => new PrimPair { PrimF = gCclamp + pair.EnzF.CutSequence + pForward, PrimR = gCclamp + pair.EnzR.CutSequence + pReverse, EnzF = pair.EnzF.Name, EnzR = pair.EnzR.Name }).ToList();
        }
        //create a list of P_Tpairs which contain primers, tms, and enzymes used
        public static List<PTpairs> PairFinal(List<PrimPair> primerPairs, double na)
        {
            return primerPairs.Select(pair => new PTpairs { Pair = pair, TmF = TmCalc.Tm(pair.PrimF, na), TmR = TmCalc.Tm(pair.PrimR, na) }).ToList();
        }

        public static PTpairs BestPair(List<PTpairs> pairs)
        {
            double lowestDif = 100;
            PTpairs bestPair = pairs[0];
            foreach (PTpairs pair in pairs)
            {
                if (Math.Abs(pair.TmF - pair.TmR) < lowestDif)
                {
                    lowestDif = Math.Abs(pair.TmF - pair.TmR);
                    bestPair = pair;
                }
            }
            return bestPair;
        }

    }
}

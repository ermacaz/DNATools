using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************
 * Matt Hamada
 * Sequence Tools
 * 2013
 * Pairs.cs
 * ******************/
namespace DNATools
{
    /// <summary>
    /// EnzPair class holds two ReEnzyme objects
    /// </summary>
    public class EnzPair
    {
        public ReEnzyme EnzF { get; set; }
        public ReEnzyme EnzR { get; set; }

        public EnzPair(ReEnzyme forward, ReEnzyme reverse)
        {
            EnzF = forward;
            EnzR = reverse;
        }
    }


    
    /// <summary>
    /// Holds pair of primers with corresponding ReEnzyme object pair
    /// </summary>
    public class PrimPair
    {
        public Primer PrimF { get; set; }
        public Primer PrimR { get; set; }
        public ReEnzyme EnzF { get; set; }
        public ReEnzyme EnzR { get; set; }

        public PrimPair(Primer pForward, Primer pReverse, ReEnzyme eForward, ReEnzyme eReverse)
        {
            PrimF = pForward;
            PrimR = pReverse;
            EnzF = eForward;
            EnzR = eReverse;
        }
        
    }

    /// <summary>
    /// Hold a primer pair and their Tms.
    /// </summary>
    public class PTpairs
    {
        public PrimPair Pair { get; set; }
        public double TmF { get; set; }
        public double TmR { get; set; }

        public PTpairs(PrimPair ptPair, double tmf, double tmr)
        {
            Pair = ptPair;
            TmF = tmf;
            TmR = tmr;
        }
    }


}

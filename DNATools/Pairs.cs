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
    }


    
    /// <summary>
    /// Holds pair of primers with corresponding ReEnzyme object pair
    /// </summary>
    public class PrimPair
    {

        public string PrimF { get; set; }
        public string PrimR { get; set; }
        public string EnzF { get; set; }
        public string EnzR { get; set; }
    }

    /// <summary>
    /// Hold a primer pair and their Tms.
    /// </summary>
    public class PTpairs
    {
        public PrimPair Pair { get; set; }
        public double TmF { get; set; }
        public double TmR { get; set; }
    }


}

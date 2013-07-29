using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************
 * Matt Hamada
 * Sequence Tools
 * 2013
 * ReEnzyme.cs
 * ******************/
namespace DNATools
{
    /// <summary>
    /// ReEnzyme objects hold a name and a  cutsequence DNA object.
    /// These objects are generated from enzymes.csv in root folder 
    /// Generated at application start
    /// </summary>
    public class ReEnzyme
    {
        public static List<ReEnzyme> EnzCol = new List<ReEnzyme>();
        public DNA CutSequence { get; set; }
        public string Name { get; set; }

        public ReEnzyme(string name, string cutseq)
        {
            Name = name;
            CutSequence = new DNA(cutseq);
            CutSequence.Clean();
            EnzCol.Add(this);
        }
    }
}

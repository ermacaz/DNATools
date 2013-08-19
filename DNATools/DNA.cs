using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/********************
 * Matt Hamada
 * Sequence Tools
 * 2013
 * DNA.cs
 * ******************/
namespace DNATools
{
    /// <summary>
    /// DNA class. Holds DNA sequence. Can output sequences complement,
    /// reverse, parallel, gc fraction, and protein translation.
    /// </summary>
    public class DNA
    {
        public string Sequence { get; set; }
        
        /// <summary>
        /// Constructor, assigns DNA sequence
        /// </summary>
        /// <param name="newSeq">sequence to assign to DNA object</param>
        public DNA(string newSeq)
        {
            Sequence = newSeq.ToUpper();
            this.Clean();
        }

        //constructor for when instance tries to be created without a string input
        protected DNA()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Complements DNA sequence ATG => TAC
        /// </summary>
        /// <returns>A string with a complemented sequence</returns>
        public string Complement()
        {
            string origin = Sequence;
            origin = origin.Replace('A', 'B');
            origin = origin.Replace('T', 'A');
            origin = origin.Replace('B', 'T');
            origin = origin.Replace('G', 'B');
            origin = origin.Replace('C', 'G');
            origin = origin.Replace('B', 'C');
            
            return origin;
        }

        /// <summary>
        /// Reverse DNA sequence ATG => GTA
        /// </summary>
        /// <returns>A string with the reverse sequence</returns>
        public string Reverse()
        {
            string origin = Sequence;
            int length = origin.Length;
            char[] returnArray = new char[length];
            for (int i = length - 1; i >= 0; i--)
            {
                returnArray[i] = origin[length - 1 - i];
            }
            string returnStr = new string(returnArray);
            return returnStr;
        }

        /// <summary>
        /// Reverse and complement DNA sequence
        /// </summary>
        /// <returns>A string with the parallel sequence</returns>
        public string Parallel()
        {
            DNA temp = new DNA(this.Reverse());
          return temp.Complement();
        }

        /// <summary>
        /// Translates DNA sequence to a protein sequence
        /// Assumes translation starts at base1 and will chop 
        /// </summary>
        /// <returns>A string of the protein sequence</returns>
        public string Translate()
        {
            string seq = Sequence;
            int length = seq.Length;

            //chop end of sequence to make base3,
            if (length % 3 != 0)
            {
                if (length % 3 == 1)
                    seq = seq.Substring(0, length - 1);
                else if (length % 3 == 2)
                    seq = seq.Substring(0, length - 2);
            }
            length = seq.Length;

            //step through sequence and convert to protein
            char[] transArray = new char[((length / 3) + 1)];
            int arrayCounter = 0;
            for (int i = 0; i < length; i = i + 3)
            {
                if (seq.Substring(i, 3) == "TTT" || seq.Substring(i, 3) == "TTC")
                    transArray[arrayCounter] = 'F';
                else if (seq.Substring(i, 3) == "TTA" || seq.Substring(i, 3) == "TTG")
                    transArray[arrayCounter] = 'L';
                else if (seq.Substring(i, 3) == "CTT" || seq.Substring(i, 3) == "CTC" || seq.Substring(i, 3) == "CTA" || seq.Substring(i, 3) == "CTG")
                    transArray[arrayCounter] = 'L';
                else if (seq.Substring(i, 3) == "ATT" || seq.Substring(i, 3) == "ATC" || seq.Substring(i, 3) == "ATA")
                    transArray[arrayCounter] = 'I';
                else if (seq.Substring(i, 3) == "ATG")
                    transArray[arrayCounter] = 'M';
                else if (seq.Substring(i, 3) == "GTT" || seq.Substring(i, 3) == "GTC" || seq.Substring(i, 3) == "GTA" || seq.Substring(i, 3) == "GTG")
                    transArray[arrayCounter] = 'V';
                else if (seq.Substring(i, 3) == "TCT" || seq.Substring(i, 3) == "TCC" || seq.Substring(i, 3) == "TCA" || seq.Substring(i, 3) == "TCG")
                    transArray[arrayCounter] = 'S';
                else if (seq.Substring(i, 3) == "CCT" || seq.Substring(i, 3) == "CCC" || seq.Substring(i, 3) == "CCA" || seq.Substring(i, 3) == "CCG")
                    transArray[arrayCounter] = 'P';
                else if (seq.Substring(i, 3) == "ACT" || seq.Substring(i, 3) == "ACC" || seq.Substring(i, 3) == "ACA" || seq.Substring(i, 3) == "ACG")
                    transArray[arrayCounter] = 'T';
                else if (seq.Substring(i, 3) == "GCT" || seq.Substring(i, 3) == "GCC" || seq.Substring(i, 3) == "GCA" || seq.Substring(i, 3) == "GCG")
                    transArray[arrayCounter] = 'A';
                else if (seq.Substring(i, 3) == "TAT" || seq.Substring(i, 3) == "TAC")
                    transArray[arrayCounter] = 'Y';
                else if (seq.Substring(i, 3) == "CAT" || seq.Substring(i, 3) == "CAC")
                    transArray[arrayCounter] = 'H';
                else if (seq.Substring(i, 3) == "CAA" || seq.Substring(i, 3) == "CAG")
                    transArray[arrayCounter] = 'Q';
                else if (seq.Substring(i, 3) == "AAT" || seq.Substring(i, 3) == "AAC")
                    transArray[arrayCounter] = 'N';
                else if (seq.Substring(i, 3) == "AAA" || seq.Substring(i, 3) == "AAG")
                    transArray[arrayCounter] = 'K';
                else if (seq.Substring(i, 3) == "GAT" || seq.Substring(i, 3) == "GAC")
                    transArray[arrayCounter] = 'D';
                else if (seq.Substring(i, 3) == "GAA" || seq.Substring(i, 3) == "GAG")
                    transArray[arrayCounter] = 'E';
                else if (seq.Substring(i, 3) == "TGT" || seq.Substring(i, 3) == "TGC")
                    transArray[arrayCounter] = 'C';
                else if (seq.Substring(i, 3) == "TGG")
                    transArray[arrayCounter] = 'W';
                else if (seq.Substring(i, 3) == "CGT" || seq.Substring(i, 3) == "CGC" || seq.Substring(i, 3) == "CGA" || seq.Substring(i, 3) == "CGG")
                    transArray[arrayCounter] = 'R';
                else if (seq.Substring(i, 3) == "AGT" || seq.Substring(i, 3) == "AGC")
                    transArray[arrayCounter] = 'S';
                else if (seq.Substring(i, 3) == "AGA" || seq.Substring(i, 3) == "AGG")
                    transArray[arrayCounter] = 'R';
                else if (seq.Substring(i, 3) == "GGT" || seq.Substring(i, 3) == "GGC" || seq.Substring(i, 3) == "GGA" || seq.Substring(i, 3) == "GGG")
                    transArray[arrayCounter] = 'G';
                arrayCounter++;
            }
            var newArray = transArray.Take(arrayCounter).ToArray();
            string returnStr = new string(newArray);
            return returnStr;
        }

        /// <summary>
        /// Removes all non-alpha characters and converts to uppercase
        /// </summary>
        /// <returns>A string of the sequence post cleaning</returns>
        public void Clean()
        {
            string startText = Sequence.ToUpper();
            string returnText = Regex.Replace(startText, @"\P{L}", string.Empty);  // \P{L} is match any point (p) that is a letter (L)uuuu
            returnText = Regex.Replace(returnText, @"[^AGTC]", string.Empty); //remove inalid letters
            Sequence = returnText;

        }

        /// <summary>
        /// Gets the gc fraction of the sequence
        /// </summary>
        /// <returns>A fraction double of the gc content (not a %)</returns>
        public double GcFraction()
        {
            var countC = Sequence.Count(c => c == 'C');
            var countG = Sequence.Count(c => c == 'G');
            return Math.Round((countC + countG) / (double)Sequence.Length, 3);
        }


    }
}

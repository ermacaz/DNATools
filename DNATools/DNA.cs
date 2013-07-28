using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNATools
{
    class DNA
    {
        private string sequence;
        public string Sequence { get; set; }
        
        public DNA(string newSeq)
        {
            Sequence = newSeq.ToLower();
        }

        public DNA Complement()
        {
            string origin = Sequence;
            origin = origin.Replace('a', 'b');
            origin = origin.Replace('t', 'a');
            origin = origin.Replace('b', 't');
            origin = origin.Replace('g', 'b');
            origin = origin.Replace('c', 'g');
            origin = origin.Replace('b', 'c');
            
            return new DNA(origin);
        }
    }
}

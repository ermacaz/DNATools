using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNATools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //load enzymes into memory
            StreamReader enzymeReader = new StreamReader(File.OpenRead("enzymes.csv"));
            while (!enzymeReader.EndOfStream)
            {
                string line = enzymeReader.ReadLine();
                var lineSplit = line.Split(',');
                new ReEnzyme(lineSplit[0], lineSplit[1]);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDNA());
        }
    }
}

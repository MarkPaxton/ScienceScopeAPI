using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LogbookTest
{
    using OpenNETCF.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application2.Run(new CompactLogbookTest());
        }
    }
}
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Linq;

namespace AdoNetAppHomeWork
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}







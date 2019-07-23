using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config_Switcher_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = string.Format("Welcome to the {0} Environment", ConfigurationManager.AppSettings["ApplicationEnvironment"]);
            Console.WriteLine(msg);
            Console.WriteLine("Press Any Key..");
            Console.ReadKey();

        }
    }
}

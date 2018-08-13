using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte email");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte heslo");
            string heslo = Console.ReadLine();

            Seznam.Prihlas(jmeno, heslo);
        }

        
    }
}

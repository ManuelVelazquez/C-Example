using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class Program
    {
        public static List<int> list = new List<int>();
        public static Dictionary<int, string> openWith = new Dictionary<int, string>();
        public static  void Main(string[] args)
        {
           

          
           
            list.Add(25);
            list.Add(30);

            openWith.Add(1, "Mannuel");
            openWith.Add(2, "Jose");


            function();
            
            Console.ReadLine();
        }

        public  static void function()
        {
            foreach (int elemnt in list)
            {
                Console.WriteLine(elemnt);
            }

            if (openWith.ContainsValue("Manuel"))
                Console.WriteLine("Si existe");

        }

       

    }
}

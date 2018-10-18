using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex("[b]");
            //Regex regex = new Regex("[A-z]");
            //Regex regex = new Regex("^[A-z]$");
            //Regex regex = new Regex("^[A-z]{1,3}$");
            //Regex regex = new Regex("^[A-z0-9]{1,3}$");
            //Regex regex = new Regex("^[A-z0-9]{1,}$");
            //Console.WriteLine(regex.IsMatch("ab12345"));

            //Regex regex = new Regex("^[A-z0-9]{1,25}[@][A-z]{1,25}[.][A-z]{1,3}$");
            Regex regex =
                new Regex("^[A-z0-9]{1,25}[@][A-z]{1,25}([.][A-z]{1,3}){1,2}$");
            //Console.WriteLine(regex.IsMatch("ab123@ukr.net"));
            Console.WriteLine(regex.IsMatch("ab123@ukr.net.com"));
        }
    }
}

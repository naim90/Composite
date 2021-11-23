using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Moi = new Person("Jeff");
            Person Frere = new Person("Naim");
            Person Soeur = new Person("Laura");
            Person Cousin1= new Person("Jean");
            Person Cousin2 = new Person("Bob");

            Moi.Descendants = new List<Person>() { Frere,Soeur,Cousin1,Cousin2};

            Console.WriteLine(Moi.ToString());

            Console.Write("_");


        }
    }
}

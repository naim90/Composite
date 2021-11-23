using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Person
    {

        public string Prenom { get; set; }
        public List<Person> Descendants { get; set; }

       public Person(string Prenom)
        {
            this.Prenom = Prenom;
            this.Descendants = new List<Person>();
        }

        public override string ToString()
        {
                       string PrenomPersonne;
                        foreach(var personne in Descendants)
                        {
                            PrenomPersonne=personne.Prenom;
                        }

            return Descendants.ToString();
        }
 
    }




}

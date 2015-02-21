using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member
{

     class Mitarbeiter
     {
         string firstname;
         string lastname;

         public Mitarbeiter(string firstname, string lastname)
         {
             this.firstname = firstname;
             this.lastname = lastname;
         }

         public void Print()
         {
             Console.WriteLine(string.Format("Vorname:{0}, Nachname:{1}",this.firstname, this.lastname));
         }

     }


class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m = new Mitarbeiter("Patrick", "Fatima");
            m.Print();

           
        }
    }
}

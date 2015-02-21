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
         string streetname;

         public Mitarbeiter(string firstname, string lastname,string streetname)
         {
             this.firstname = firstname;
             this.lastname = lastname;
             this.streetname = streetname;

         }

         public void Print()
         {
             Console.WriteLine(string.Format("Vorname:{0}, Nachname:{1}, Streetname:{2}",this.firstname, this.lastname, this.streetname));
         }

     }


class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m = new Mitarbeiter("Patrick", "Fatima", "teststeet");
            m.Print();

           
        }
    }
}

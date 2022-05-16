using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part2.Proxy
{
     public class Person
    {
         private int id;
         private string firstName;
         private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}

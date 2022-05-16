using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part2.Proxy
{
    internal class InteriorOffice : IUpdateMachine, IServiceMachine
    {
        public Person person;

              public void ChangeAddress()
        {
            Console.WriteLine("Your address update!");
        }

        public Person GetInfo()
        {
           
            return person;
        }

        public void PassportRenewal()
        {
            Console.WriteLine("Your passport renewed!");
        }

        public void ShutDown()
        {
            Console.WriteLine("The machine is shut down.");
        }

        public void UpdateVersion()
        {
            Console.WriteLine("The version is update.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part2.Proxy
{
    internal interface IServiceMachine
    {
        public Person GetInfo();
        public void ChangeAddress();
        public void PassportRenewal();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPatterns_Part2.Proxy
{
    internal class ServiceMachine : IServiceMachine
    {
        private IServiceMachine serviceMachine;

        public ServiceMachine(IServiceMachine serviceMachine)
        {
            this.serviceMachine = serviceMachine;
        }

        public Person GetInfo()
        {
            return this.serviceMachine.GetInfo();
        }
        public void ChangeAddress()
        {
            this.serviceMachine.ChangeAddress();
        }


        public void PassportRenewal()
        {
            this.serviceMachine.PassportRenewal();
        }


    }
}

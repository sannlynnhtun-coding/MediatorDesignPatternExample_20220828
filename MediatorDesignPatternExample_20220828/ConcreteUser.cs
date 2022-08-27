using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternExample_20220828
{
    internal class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}

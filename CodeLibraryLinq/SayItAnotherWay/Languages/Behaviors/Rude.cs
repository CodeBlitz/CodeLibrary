using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayItAnotherWay.Languages.Behaviors
{
    class Rude : IBehavior
    {
        public void SayIt()
        {
            Console.WriteLine("So, who are you supposed to be?");
        }
    }
}

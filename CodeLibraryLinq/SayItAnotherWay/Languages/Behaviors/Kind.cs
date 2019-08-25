using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayItAnotherWay.Languages.Behaviors
{
    class Kind : IBehavior
    {
        public void SayIt()
        {
            Console.WriteLine("It is very nice to meet you. How are you?");
        }
    }
}

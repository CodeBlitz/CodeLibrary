using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayItAnotherWay.Languages.Behaviors
{
    class Excited : IBehavior
    {
        public void SayIt()
        {
            Console.WriteLine("Wow, it is great to meet you. I am soo excited to meet you!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayItAnotherWay.Languages
{
    public class English : Language
    {
        public English()
        {
            // Defautl behavior is kind.
            SetBehavior(new SayItAnotherWay.Languages.Behaviors.Kind());
        }

        public override void Introduction()
        {
            Console.WriteLine("I am an English speaker.");
        }
    }
}

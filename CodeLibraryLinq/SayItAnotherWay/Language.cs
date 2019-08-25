using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayItAnotherWay.Languages.Behaviors;

namespace SayItAnotherWay.Languages
{
    public abstract class Language : IBehavior
    {
        private IBehavior languageBehavior;

        // Must implement introduction.
        public abstract void Introduction();

        public void SetBehavior(IBehavior newLanguageBehavior)
        {
            languageBehavior = newLanguageBehavior;
        }

        public void SayIt()
        {
            languageBehavior.SayIt();
        }
    }
}

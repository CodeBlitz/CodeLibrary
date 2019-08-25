using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayItAnotherWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Languages.Language englishSpeaker = new Languages.English();

            englishSpeaker.Introduction();
            englishSpeaker.SayIt();

            Console.WriteLine("Changing to bad mood.");
            englishSpeaker.SetBehavior(new Languages.Behaviors.Rude());
            englishSpeaker.SayIt();

            Console.WriteLine("Press anykey to continue...");
            Console.ReadKey();
            }
    }
}

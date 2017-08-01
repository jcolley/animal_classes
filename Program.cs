using System;

namespace animal_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Retriever myDog = new Retriever("Spot", 20, "run", "long", "golden", 4);
            //Console.WriteLine("TEST: "+myDog.Speak());
            myDog.Speak();
        }
    }
}

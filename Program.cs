using System;

namespace InstrumentsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            guitar myguitar = new guitar("Gibson");
            mandolin Kentucky = new mandolin("Kentucky");
            Ukulele myUkele = new Ukulele("ortega");

            myUkulele.serialNumber = "abc123";

            myguitar.Play();
            Kentucky.Play();
            myUkele.Play();
        }
    }
}

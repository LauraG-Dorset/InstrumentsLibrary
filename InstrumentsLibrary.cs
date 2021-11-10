using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsLibrary
{
    public abstract class Instruments
    {
        public string serialNumber { get; set; }
        public string Name { get; set; }
        public Instruments(string _name)
        {
            Name = _name;
        }
        public abstract void Play();
        public class guitar : Instruments
        {
            public guitar(string _name):base(_name)
            {

            }

            public override void Play()
            {
                //throw new NotImplementedException();
                Console.WriteLine($"I am playing {Name} guitar");
            }
        }
        public class mandolin : Instruments
        {
            public mandolin(string _name) : base(_name)
            {

            }

            public override void Play()
            {
                Console.WriteLine($"I am playing {Name} mandolin");
            }
        }
        public class ukulele: Instruments
        {
            public ukulele(string _name) : base(_name)
            {

            }

            public override void Play()
            {
                Console.WriteLine($"I am playing {Name} mandolin");
            }
        }
    }
}

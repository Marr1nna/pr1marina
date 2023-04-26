using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1marina
{
    internal class Candidate
    {
        private string _name;
        private uint _voice;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public uint Voice
        {
            get { return _voice; }
            private set { _voice = value; }
        }
        public Candidate(string name, uint voice)
        {
            if (name == null)
                throw new NullReferenceException("Name");
            Name = name;
            Voice = voice;
        }
        public uint addVoice (Candidate candidate)
        {
            Console.WriteLine("Name:", candidate.Name);
            Console.WriteLine("Введите количество голосов:");
            uint voices = Convert.ToUInt32(Console.ReadLine());
            candidate.Voice += voices;
            return candidate.Voice;
        }
        void Display()
        {
            Console.WriteLine("Candidate");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Voice:{Voice}");
        }
    }
}

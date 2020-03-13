using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz07
{
    class Pistol : IFirearm
    {
        public void Sound(string weapon, string sound)
        {
            Console.WriteLine($"I am a {weapon} and I go {sound}");
        }

    }
}

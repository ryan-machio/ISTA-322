﻿using System;

namespace Quiz07
{
    interface IFirearm
    {
        void Sound(string weapon, string sound);
    }
    class Pistol : IFirearm
    {
        public void Sound(string weapon, string sound)
        {
            Console.WriteLine($"I am a {weapon} and I go {sound}");
        }

    }
    class Rifle : IFirearm
    {
        public void Sound(string weapon, string sound)
        {
            Console.WriteLine($"I am a {weapon} and I go {sound}");
        }
    }
    class Shotgun : IFirearm
    {
        public void Sound(string weapon, string sound)
        {
            Console.WriteLine($"I am a {weapon} and I go {sound}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFirearm p = new Pistol();
            p.Sound("pistol", "pop");

            IFirearm s = new Shotgun();
            s.Sound("shotgun", "pop");

            IFirearm r = new Rifle();
            r.Sound("rifle", "bang");
        }
    }
}

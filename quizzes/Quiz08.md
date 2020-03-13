using System;

namespace Exercise08Pt2
{
    class FireArms
    {
        public static string name = "N/A";
        public static string caliber = "N/A";
        public static string sound = "N/A";
        public static int count = 0;

        public static string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public static string Caliber
        {
            get
            {
                return caliber;
            }

            set
            {
                caliber = value;
            }
        }
        public string Sound
        {
            get
            {
                return sound;
            }

            set
            {
                sound = value;
            }
        }

        public FireArms(string Name, string Caliber, string Sound)
        {
            name = Name;
            caliber = Caliber;
            sound = Sound;
            count++;
        }

        public override string ToString()
        {
            return ($"I am {Name} that takes {Caliber} rounds.  I go {Sound}.  There are {FireArms.count} firearms.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C# Quiz 8");
            FireArms pistol = new FireArms("pistol", "9mm","pop");
            Console.WriteLine(pistol.ToString());
            FireArms shotgun = new FireArms("shotgun", "12 gauge", "boom");
            Console.WriteLine(shotgun.ToString());
            FireArms rifle = new FireArms("rifle", "5.56", "bang");
            Console.WriteLine(rifle.ToString());
        }
    }
}

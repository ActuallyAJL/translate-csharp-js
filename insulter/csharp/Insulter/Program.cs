using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Insults = new List<string>()
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            List<int> Indexes = new List<int>();

            while (Indexes.Count < 3)
            {
                int Candidate = GetRandomInt(0, Insults.Count - 1);
                if (!Indexes.Contains(Candidate))
                {
                    Indexes.Add(Candidate);
                }
            }

            for (int i = 0; i < Indexes.Count; i++)
            {
                int Index = Indexes[i];
                Console.WriteLine(Insults[Index]);
            }
            int GetRandomInt(int min, int max)
            {
                Random rand = new Random();
                int r = rand.Next(min, max + 1);
                return r;
            }
        }
    }
}

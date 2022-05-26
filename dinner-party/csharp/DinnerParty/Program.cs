using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Guest> Table1 = new List<Guest>();
            List<Guest> Table2 = new List<Guest>();
            List<Guest> Guests = new List<Guest>()
            {
                new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model"),
                new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war"),
                new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner"),
                new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist"),
                new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian"),
                new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"),
                new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"),
                new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977"),
            };

            foreach (Guest guest in Guests)
            {
                List<string> Table1Occupations = Table1.Select(g => g.Occupation).ToList();
                if (Table1Occupations.Contains(guest.Occupation))
                {
                    Table2.Add(guest);
                }
                else
                {
                    Table1.Add(guest);
                }
            }

            Console.WriteLine("Table 1");
            foreach (Guest guest in Table1)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }

            Console.WriteLine("Table 2");
            foreach (Guest guest in Table2)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        }

        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
            public Guest(string n, string o, string b)
            {
                Name = n;
                Occupation = o;
                Bio = b;
            }
        };


    }
}

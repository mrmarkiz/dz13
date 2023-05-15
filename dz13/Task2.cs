using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    internal class Task2
    {
        public static void Run()
        {
            List<FootballPlayer> list = new List<FootballPlayer>()
            {
                new FootballPlayer("Arnau Tenas", 21, 3, 2_000_000),
                new FootballPlayer("Andreas Christensen", 27,7,30_000_000),
                new FootballPlayer("Robert Lewandowski", 34, 10, 40_000_000)
            };
            FootballTeam barc = new FootballTeam(list);
            foreach (FootballPlayer creature in barc)
                Console.WriteLine(creature + "\n");
        }
    }

    internal class FootballTeam : IEnumerable<FootballPlayer>
    {
        public List<FootballPlayer> team;
        public FootballTeam()
        {
            team = new List<FootballPlayer>();
        }
        public FootballTeam(List<FootballPlayer> players)
        {
            team = players;
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return team.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class FootballPlayer
    {
        public string PIB { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public int TotalWorth { get; set; }

        public FootballPlayer(string pib, int age, int experience, int totalworth)
        {
            PIB = pib;
            Age = age;
            Experience = experience;
            TotalWorth = totalworth;
        }

        public override string ToString()
        {
            return $"PIB: {PIB}\nAge: {Age}\nExperience: {Experience} years\nTotal worth:{TotalWorth} euros";
        }
    }
}

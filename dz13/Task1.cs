using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    internal class Task1
    {
        public static void Run()
        {
            List<WaterCreature> list = new List<WaterCreature>()
            {
                new WaterCreature("Octopus", "Cephalopods", "They have bulbous heads, large eyes, and eight very useful arms. “Cephalopod” is Greek for “head-foot,” which makes sense, since their limbs are attached directly to their head."),
                new WaterCreature("Jelly fish", "Medusozoa", "Jellyfish have no brain, heart, bones or eyes. They are made up of a smooth, bag-like body and tentacles armed with tiny, stinging cells. These incredible invertebrates use their stinging tentacles to stun or paralyse prey before gobbling it up. The jellyfish's mouth is found in the centre of its body."),
                new WaterCreature("Clown fish", "Fish", "The body shape of clownfish is perch-like—oval and laterally compressed with an interrupted lateral line. Their body color is a bright orange with three white bars, the middle with a forward bulge centrally. Thick black bands around the white bars separate the orange and white portions of the body.")
            };
            Oceanarium oceanarium = new Oceanarium(list);
            foreach(WaterCreature creature in oceanarium)
                Console.WriteLine(creature + "\n");
        }
    }

    internal class Oceanarium : IEnumerable<WaterCreature>
    {
        public List<WaterCreature> waterCreatureList;
        public Oceanarium()
        {
            waterCreatureList = new List<WaterCreature>();
        }
        public Oceanarium(List<WaterCreature> waterCreatures)
        {
            waterCreatureList = waterCreatures;
        }

        public IEnumerator<WaterCreature> GetEnumerator()
        {
            return waterCreatureList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class WaterCreature
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public string Description { get; set; }

        public WaterCreature(string name, string kind, string description)
        {
            Name = name;
            Kind = kind;
            Description = description;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nKind: {Kind}\nDescription:\n{Description}";
        }
    }
}
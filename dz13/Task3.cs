using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    internal class Task3
    {
        public static void Run()
        {
            List<Worker> list = new List<Worker>()
            {
                new Worker("Mike Johnson", 21, 1, 1200),
                new Worker("Josh Peterson", 19, 0, 700),
                new Worker("Adam Brown", 34, 12, 1600)
            };
            Cafe cafe = new Cafe(list);
            foreach (Worker worker in cafe)
                Console.WriteLine(worker + "\n");
        }
    }

    internal class Cafe : IEnumerable<Worker>
    {
        public List<Worker> staff;
        public Cafe()
        {
            staff = new List<Worker>();
        }
        public Cafe(List<Worker> workers)
        {
            staff = workers;
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return staff.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class Worker
    {
        public string PIB { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }

        public Worker(string pib, int age, int experience, double salary)
        {
            PIB = pib;
            Age = age;
            Experience = experience;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"PIB: {PIB}\nAge: {Age}\nExperience: {Experience} years\nSalary:{Salary} dollars";
        }
    }
}

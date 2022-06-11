using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class base_worker
    {
        public List<base_worker> list;

        public string name;
        public int old;
        public float salary;
        public base_worker(string name, int old, float salary, ref List<base_worker> list)
        {
            this.name = name;
            this.old = old;
            this.salary = salary;

            this.list = list;
            list.Add(this);
        }

        public virtual void DoStuff()
        { Console.WriteLine("Called \"DoStuff\" in base_worker"); }
    }

    class worker : base_worker
    {
        public worker(string name, int old, float salary, ref List<base_worker> list)
            : base(name, old, salary, ref list)
        { }

        public override void DoStuff()
        {
            base.DoStuff();
            float sum = 0;
            list.ForEach((a) => { sum += a.salary; });
            Console.WriteLine($"Summary salary of all worker: {sum}");
        }
    }

    class Manager : base_worker
    {
        public Manager(string name, int old, float salary, ref List<base_worker> list)
            : base(name, old, salary, ref list) {}

        public override void DoStuff()
        {
            base.DoStuff();
            float max = 0;
            for (int i = 0; i < list.Count; i++)
                if (list[i].salary > max)
                    max = list[i].salary;
            Console.WriteLine($"Max salary of all managers: {max}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create workers and managers...");
            List<base_worker> list_w= new List<base_worker>();
            worker w1 = new worker("Koon", 23, 2599, ref list_w);
            worker w2 = new worker("Mon", 99, 1500, ref list_w);
            worker w3 = new worker("Jon", 53, 100, ref list_w);

            List<base_worker> list_m = new List<base_worker>();

            Manager m1 = new Manager("Oldi", 16, 195, ref list_m);
            Manager m2 = new Manager("Miir", 29, 1599, ref list_m);
            Manager m3 = new Manager("Bob", 30, 455, ref list_m);
            Console.WriteLine("Done!\n\n");

            Console.WriteLine("Call in variable {w1} fuction -> DoStuff() (Worker)");
            w1.DoStuff();
            Console.WriteLine("\n\nCall in variable {m1} fuction -> DoStuff() (Manager)");
            m1.DoStuff();
            Console.ReadLine();
        }
    }
}
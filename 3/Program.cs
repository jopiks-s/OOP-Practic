using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class item
    {
        public LinkedList<item> list;
        public int cost { get; set; }
        public float mass { get; set; }
        public float[] Size { get; set; }
        public string Name { get; set; }
        public string FirmName { get; set; }
        public item() { }

        public item(int cost, float mass, float[] Size, string Name, string FirmName, ref LinkedList<item> list, bool add)
        {
            this.cost = cost;
            this.mass = mass;
            this.Size = Size;
            this.Name = Name;
            this.FirmName = FirmName;
            this.list = list;
            if (add)
                Add();
        }

        static public void PrintList(LinkedList<item> list)
        {
            for(LinkedListNode<item>? node = list.First; node != null; node = node.Next)
            {
                node.Value.Print();
            }    
        }
        public void Add()
        {
            list.AddLast(this);
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, FirmName: {FirmName}, Cost: {cost}, Mass: {mass}, Size: x: {Size[0]}, y: {Size[1]}, z: {Size[2]}");
        }
    }

    class product : item
    {
        public string Category { get; set; }
        public string PackageType { get; set; }
        public bool FullAgeAcces { get; set; }
        public bool HealthHurting { get; set; }
        public DateTime CreatingDate { get; set; }
        public TimeSpan TermDuration { get; set; }
        public product(int cost, float mass, float[] Size, string Name, string FirmName, ref LinkedList<item> list, bool add, string Category, string PackageType,
            bool FullAgeAcces, bool HealthHurting, DateTime CreatingDate, TimeSpan TermDuration) : base(cost, mass, Size, Name, FirmName, ref list, add)
        {
            this.Category = Category;
            this.PackageType = PackageType;
            this.FullAgeAcces = FullAgeAcces;
            this.HealthHurting = HealthHurting;
            this.CreatingDate = CreatingDate;
            this.TermDuration = TermDuration;
        }

        public DateTime GetTermOutDate()
        {
            DateTime d1 = CreatingDate;
            d1.AddDays(TermDuration.Days);
            d1.AddDays(TermDuration.Days);
            d1.AddMinutes(TermDuration.Minutes);
            return d1;
        }

        public bool IsOutOfTerm()
        {
            return DateTime.Now < GetTermOutDate();
        }

    }

    class milk_product : product
    {
        public float FatPercent { get; set; }
        public bool Natural { get; set; }

        public milk_product(int cost, float mass, float[] Size, string Name, string FirmName, ref LinkedList<item> list, bool add, string Category, string PackageType,
            bool FullAgeAcces, bool HealthHurting, DateTime CreatingDate, TimeSpan TermDuration, float FatPercent, bool Natural) 
            : base(cost, mass, Size, Name, FirmName, ref list, add, Category, PackageType, FullAgeAcces, HealthHurting, CreatingDate, TermDuration)
        {
            this.FatPercent = FatPercent;
            this.Natural = Natural;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, FirmName: {FirmName}, Cost: {cost}, Mass: {mass}, Size: x: {Size[0]}, y: {Size[1]}, z: {Size[2]} " +
                $"Fat percent: {FatPercent}, Natural: {Natural}");
        }
    }

    class Toy : item
    {
        public int OldTarget { get; set; }
        public bool BoysToy { get; set; }
        public bool PartyToy { get; set; }
        public string PlayCategory { get; set; }

        public Toy() : base() { }

        public Toy(int cost, float mass, float[] Size, string Name, string FirmName, ref LinkedList<item> list, bool add,
            int OldTarget, bool BoysToy, bool PartyToy, string PlayCategory)
            : base(cost, mass, Size, Name, FirmName, ref list, add)
        {
            this.OldTarget = OldTarget;
            this.BoysToy = BoysToy;
            this.PartyToy = PartyToy;
            this.PlayCategory = PlayCategory;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, FirmName: {FirmName}, Cost: {cost}, Mass: {mass}, Size: x: {Size[0]}, y: {Size[1]}, z: {Size[2]}" +
                $", Old Target: {OldTarget}, Sex: {(BoysToy? "Male":"Female")}, Party toy: {PartyToy}, Play Category: {PlayCategory}");
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<item> list = new LinkedList<item>();
            milk_product m1 = new milk_product(50, 950, new float[] { 50, 50, 170 }, "GoodMilk", "AGM", ref list, true, "Lactic", "Solid", false, false, new DateTime(2021, 11, 6), new TimeSpan(6, 0, 0), 2.5F, false);
            milk_product m2 = new milk_product(55, 950, new float[] { 200, 20, 40 }, "MITII", "SVE", ref list, true, "Lactic", "Solid", false, false, new DateTime(2021, 11, 7), new TimeSpan(4, 0, 0), 3.2F, false);
            milk_product m3 = new milk_product(105, 1890, new float[] { 65, 40, 200 }, "LargeMamy", "AGN", ref list, false, "Lactic", "Membrance", false, false, new DateTime(2021, 10, 26), new TimeSpan(10, 0, 0), 1F, true);
            milk_product m4 = new milk_product(28, 450, new float[] { 80, 80, 55 }, "MinyGO", "FLKS", ref list, false, "Lactic", "Membrance", true, false, new DateTime(2021, 11, 11), new TimeSpan(8, 0, 0), 1F, false);

            m3.Add();
            m4.Add();

            item.PrintList(list);
            Console.WriteLine("\n");

            Toy t1 = new Toy(270, 105, new float[] { 220, 110, 80 }, "LOOTGun", "IBM", ref list, false, 10, true, true, "Dynamic, Shooter");
            Toy t2 = new Toy(150, 20, new float[] { 25, 15, 5 }, "PheraCar", "Hoot", ref list, true, 6, true, false, "Strategy, Imagination");
            Toy t3 = new Toy(370, 120, new float[] { 50, 30, 110 }, "PrettyDoll", "MMS", ref list, true, 6, false, false, "Strategy, Imagination");
            Toy t4 = new Toy(200, 200, new float[] { 1100, 1100, 50 }, "MonopolyS+", "KNO", ref list, false, 10, true, true, "Strategy, Tactics");

            t1.Add();
            t4.Add();

            for (LinkedListNode<item>? node = list.First; node != null; node = node.Next)
                node.Value.Print();

            Console.ReadLine();
        }
    }
}

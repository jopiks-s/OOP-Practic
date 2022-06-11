using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class Item
    {
        public static LinkedListNode<Item> FirstNode;
        public int cost { get; set; }
        public float mass { get; set; }
        public float[] Size { get; set; }
        public string Name { get; set; }
        public string FirmName { get; set; }
        public Item() { }

        public Item(int cost, float mass, float[] Size, string Name, string FirmName, LinkedList<Item> list, bool add)
        {
            this.cost = cost;
            this.mass = mass;
            this.Size = Size;
            this.Name = Name;
            this.FirmName = FirmName;

            if (add)
                Add(list);
        }

        static public void PrintList()
        {
            if (FirstNode == null)
                return;

            Console.WriteLine("Output list content:");
            for (LinkedListNode<Item> node = FirstNode; node != null; node = node.Next)
                node.Value.Print();
        }
        public void Add(LinkedList<Item> list = null)
        {
            if (list != null)
            {
                list.AddLast(this);
                FirstNode = list.First;
            }
            else if (FirstNode != null)
            {
                FirstNode.List.AddLast(this);
            }

        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, FirmName: {FirmName}, Cost: {cost}, Mass: {mass}, Size: x: {Size[0]}, y: {Size[1]}, z: {Size[2]}");
        }
    }

    class Product : Item
    {
        public string Category { get; set; }
        public string PackageType { get; set; }
        public bool FullAgeAcces { get; set; }
        public bool HealthHurting { get; set; }
        public DateTime CreatingDate { get; set; }
        public TimeSpan TermDuration { get; set; }
        public Product(int cost, float mass, float[] Size, string Name, string FirmName, LinkedList<Item> list, bool add, string Category, string PackageType,
            bool FullAgeAcces, bool HealthHurting, DateTime CreatingDate, TimeSpan TermDuration) : base(cost, mass, Size, Name, FirmName, list, add)
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

    class MilkProduct : Product
    {
        public float FatPercent { get; set; }
        public bool Natural { get; set; }

        public MilkProduct(int cost, float mass, float[] Size, string Name, string FirmName, LinkedList<Item> list, bool add, string Category, string PackageType,
            bool FullAgeAcces, bool HealthHurting, DateTime CreatingDate, TimeSpan TermDuration, float FatPercent, bool Natural)
            : base(cost, mass, Size, Name, FirmName, list, add, Category, PackageType, FullAgeAcces, HealthHurting, CreatingDate, TermDuration)
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

    class Toy : Item
    {
        public int OldTarget { get; set; }
        public bool BoysToy { get; set; }
        public bool PartyToy { get; set; }
        public string PlayCategory { get; set; }

        public Toy() : base() { }

        public Toy(int cost, float mass, float[] Size, string Name, string FirmName, LinkedList<Item> list, bool add,
            int OldTarget, bool BoysToy, bool PartyToy, string PlayCategory)
            : base(cost, mass, Size, Name, FirmName, list, add)
        {
            this.OldTarget = OldTarget;
            this.BoysToy = BoysToy;
            this.PartyToy = PartyToy;
            this.PlayCategory = PlayCategory;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, FirmName: {FirmName}, Cost: {cost}, Mass: {mass}, Size: x: {Size[0]}, y: {Size[1]}, z: {Size[2]}" +
                $", Old Target: {OldTarget}, Sex: {(BoysToy ? "Male" : "Female")}, Party toy: {PartyToy}, Play Category: {PlayCategory}");
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            LinkedList<Item> list = new LinkedList<Item>();
            Console.WriteLine("Create basic list (MilkProduct)...");
            MilkProduct m1 = new MilkProduct(50, 950, new float[] { 50, 50, 170 }, "GoodMilk", "AGM", list, true, "Lactic", "Solid", false, false, new DateTime(2021, 11, 6), new TimeSpan(6, 0, 0), 2.5F, false);
            MilkProduct m2 = new MilkProduct(55, 950, new float[] { 200, 20, 40 }, "MITII", "SVE", list, true, "Lactic", "Solid", false, false, new DateTime(2021, 11, 7), new TimeSpan(4, 0, 0), 3.2F, false);
            MilkProduct m3 = new MilkProduct(105, 1890, new float[] { 65, 40, 200 }, "LargeMamy", "AGN", list, false, "Lactic", "Membrance", false, false, new DateTime(2021, 10, 26), new TimeSpan(10, 0, 0), 1F, true);
            MilkProduct m4 = new MilkProduct(28, 450, new float[] { 80, 80, 55 }, "MinyGO", "FLKS", list, false, "Lactic", "Membrance", true, false, new DateTime(2021, 11, 11), new TimeSpan(8, 0, 0), 1F, false);
            Console.WriteLine("Done!\n\n");

            m3.Add();
            m4.Add();
            Item.PrintList();

            Console.WriteLine("\n\nAdd (Toy) instances...");
            Toy t1 = new Toy(270, 105, new float[] { 220, 110, 80 }, "LOOTGun", "IBM", list, false, 10, true, true, "Dynamic, Shooter");
            Toy t2 = new Toy(150, 20, new float[] { 25, 15, 5 }, "PheraCar", "Hoot", list, true, 6, true, false, "Strategy, Imagination");
            Toy t3 = new Toy(370, 120, new float[] { 50, 30, 110 }, "PrettyDoll", "MMS", list, true, 6, false, false, "Strategy, Imagination");
            Toy t4 = new Toy(200, 200, new float[] { 1100, 1100, 50 }, "MonopolyS+", "KNO", list, false, 10, true, true, "Strategy, Tactics");
            Console.WriteLine("Done!\n\n");

            t1.Add();
            t4.Add();

            Item.PrintList();

            Console.ReadLine();
        }
    }
}

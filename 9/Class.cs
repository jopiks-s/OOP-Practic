using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    interface ISay
    {
        void Say();
    }

    interface IErase
    {
        void EraseMy();
    }

    interface IMove
    {
        static int velocity = 0;
        static int location = 0;
        void Move();
    }

    interface IMath
    {
        float GetCosine();
    }

    public abstract class item:IComparable<item>, ISay
    {
        public int cost { get; set; }
        public float mass { get; set; }
        public float[] Size { get; set; }
        public string Name { get; set; }
        public string FirmName { get; set; }

        public item(int c, float m, float[] s, string n, string fname)
        {
            cost = c;
            mass = m;
            Size = s;
            Name = n;
            FirmName = fname;
        }

        public int CompareTo(item obj)
        {
            return cost.CompareTo(obj.cost);
        }

        abstract public void Say();
    }

    class product : item, IErase
    {
        public string Category { get; set; }
        public string PackageType { get; set; }
        public bool FullAgeAcces { get; set; }
        public bool HealthHurting { get; set; }

        public virtual void EraseMy()
        {
            cost = 0;
            mass = 0;
            Size = new float[3]{ 0, 0, 0};
            Name = "";
            FirmName = "";
            Category = "";
            PackageType = "";
            FullAgeAcces = false;
            HealthHurting = false;
        }
        public override void Say()
        {
            MessageBox.Show($"Firm name: {FirmName}, Name: {Name}, " +
                $"Price: {cost}, Mass: {mass}, Size: x {Size[0]}, y {Size[1]}, z {Size[2]}, " +
                $"Category: {Category}, Package type: {PackageType}, 18+: {FullAgeAcces}, " +
                $"Health hurting: {HealthHurting}", "Print fuction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public product(int c, float m, float[] s, string n, string fname, string cat, string p, bool age, bool hurt)
            : base(c, m, s, n, fname)
        {
            Category = cat;
            PackageType = p;
            FullAgeAcces = age;
            HealthHurting = hurt;
        }
    }
    class milk_product : product, IMath
    {
        public float FatPercent { get; set; }
        public bool Natural { get; set; }

        public float GetCosine()
        {
            if (Convert.ToInt32(Natural) == 0)
                throw new DivideByZeroException();
            float res = (float)Math.Cos(FatPercent/Convert.ToInt32(Natural));
            MessageBox.Show($"Cosine of {FatPercent + Convert.ToInt32(Natural)}: {res}", "Cosine function", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return res;
        }
        public override void EraseMy()
        {
            base.EraseMy();
            FatPercent = 0;
            Natural = false;
        }
        public override void Say()
        {
            MessageBox.Show($"Firm name: {FirmName}, Name: {Name}, " +
                $"Price: {cost}, Mass: {mass}, Size: x {Size[0]}, y {Size[1]}, z {Size[2]}, " +
                $"Category: {Category}, Package type: {PackageType}, 18+: {FullAgeAcces}, " +
                $"Health hurting: {HealthHurting}, " +
                $"Fat percent: {FatPercent}, Natural: {Natural}", "Print fuction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public milk_product(int c, float m, float[] s, string n, string fname,
            string cat, string p, bool age, bool hurt, float fat, bool nat)
            : base(c, m, s, n, fname, cat, p, age, hurt)
        {
            FatPercent = fat;
            Natural = nat;
        }
    }

    class Toy : item, IMove
    {
        public int OldTarget { get; set; }
        public bool BoysToy { get; set; }
        public bool PartyToy { get; set; }

        public void Move()
        {
            IMove.location += IMove.velocity;
            MessageBox.Show($"My velocity: {IMove.velocity}, my location: {IMove.location}", "Move fuction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void Say()
        {
            MessageBox.Show($"Firm name: {FirmName}, Name: {Name}, " +
                $"Price: {cost}, Mass: {mass}, Size: x {Size[0]}, y {Size[1]}, z {Size[2]}, " +
                $"Old target: {OldTarget}, Sex: {(BoysToy? "Male": "Female")}, " +
                $"Party toy: {PartyToy}", "Print fuction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Toy(int c, float m, float[] s, string n, string fname, int old, bool boy, bool party)
            : base(c, m, s, n, fname)
        {
            IMove.velocity = 10;
            OldTarget = old;
            BoysToy = boy;
            PartyToy = party;
        }
    }
}

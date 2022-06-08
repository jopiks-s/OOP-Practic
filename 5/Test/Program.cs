using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{

    interface IPrint
    {
        void Print();
    }

    abstract class Shape : IPrint
    {
        public string ShapeName { get; set; }
        public abstract int VertexAmount { get; }
        public abstract float GetArea();
        public void Print()
        {
             Console.WriteLine(ToString());
        }

    }

    class Rectangle : Shape
    {
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
            ShapeName = "Прямокутник";
        }
        public float Width { get; set; }
        public float Height { get; set; }
      
        public override int VertexAmount => 4;

        public override float GetArea() => Width * Height;

        public override string ToString()
        {
            return $"Фігура {ShapeName}, ширина : {Width}, Висота : {Height}, Площа : {GetArea()}";
        }

    }

    class Square : Rectangle
    {
        public Square(float side) : base(side, side) 
        {
            ShapeName = "Квадрат";
        }

        public override string ToString()
        {
            return $"Фігура {ShapeName}, довжина сторони : {Width}, Площа : {GetArea()}";
        }
    }

    class Circuit : Shape
    {
        public float Radius { get; set; }

        public Circuit(float radius)
        {
            Radius = radius;
            ShapeName = "Коло";
        }
        public override float GetArea() => (float)Math.PI * Radius * Radius;

        public override int VertexAmount => 0;

        public override string ToString()
        {
            return $"Фігура {ShapeName}, радіус : {Radius}, Площа : {GetArea()}";
        }
    }

    abstract class Triangle : Shape
    {
        public float SideA { get; set; }
        public float SideB { get; set; }
        public float Angle { get; set; }

        protected float RadAngle { get => Angle * (float)Math.PI / 180; }

        public virtual float SideC { get => (float)Math.Sqrt( SideA * SideA + SideB * SideB - 2 * SideA * SideB * Math.Cos(RadAngle));}
        public Triangle(float sideA, float sideB, float angle)
        {
            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }

        public override float GetArea() => SideA * SideB * (float)Math.Sin(RadAngle) / 2;

        public abstract float GetPerimeter();

        public override int VertexAmount => 3;

    }

    class EqTriangle : Triangle
    {

        public EqTriangle(float side) : base(side, side , 60)
        {
            ShapeName = "Рівносторонній трикутник";
        }

        public override int VertexAmount => 3;

        public override float SideC => SideA;
        public override float GetPerimeter() => SideA * 3;

        public override string ToString()
        {
            return $"Фігура {ShapeName}, довжина сторони : {SideA}, Площа : {GetArea()}";
        }

    }

    class IsTriangle : Triangle
    {
        public IsTriangle(float side, float angle) : base(side, side, angle)
        {
            ShapeName = "Рівнобедрений трикутник";
        }

        public override float GetPerimeter() => SideA + SideB + SideC;

        public override string ToString()
        {
            return $"Фігура {ShapeName}, довжина 1 і 2 сторони : {SideA}, кут між 1 і 2 стороною : {Angle} Площа : {GetArea()}";
        }

    }

    class RectTriangle : Triangle
    {
        public RectTriangle(float sideA, float sideB): base(sideA, sideB, 90)
        {
            ShapeName = "Прямокутний трикутник";
        }

        public override float SideC => (float)Math.Sqrt(SideA*SideA + SideB*SideB);
        public override float GetPerimeter() => SideA + SideB + SideC;

        public override string ToString()
        {
            return $"Фігура {ShapeName}, довжина 1 сторони : {SideA}, довжина 2 сторони: {SideB} Площа : {GetArea()}";
        }
    }

    class Pentagon : Shape
    {
        public float Side { get; set; }

        public override int VertexAmount => 5;

        public Pentagon(float side)
        {
            Side = side;
            ShapeName = "Правильний п'ятикутник";
        }

        public override float GetArea()
        {
            return (Side * Side / 4) * (float)Math.Sqrt(25 + 10.0 * Math.Sqrt(5.0));
        }

        public override string ToString()
        {
            return $"Фігура {ShapeName}, довжина сторони : {Side}, Площа : {GetArea()}";
        }
    }

    class Ellipse : Shape
    {
        public float A { get; set; }
        public float B { get; set; }

        public override int VertexAmount => 0;

        public Ellipse(float a, float b)
        {
            A = a;
            B = b;
            ShapeName = "Еліпс";
        }

        public override float GetArea()
        {
            return  (float)Math.PI * A * B;
        }
    }

    class Picture
    {
        Shape[] shpArray;

        private int n = 1;
        public int N { get => n; set { if (value <= 0) return;  n = value; shpArray = new Shape[n]; } }

        public Picture(int arraySize)
        {
            N = arraySize;
        }

        public void FillArray(params Shape[] shapes)
        {
            for (int i = 0; i < shapes.Length && i < n; i++)
            {
                shpArray[i] = shapes[i];
            }
        }

        public void PrintArray()
        {
            foreach (var item in shpArray)
            {
                if(item != null)
                item.Print();
            }
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;



            Circuit circuit = new Circuit(5);
            Square square = new Square(5);
            Pentagon pentagon = new Pentagon(5);

            Picture picture = new Picture(3);
            Console.WriteLine("Заповнення масиву...\n");
            picture.FillArray(circuit, square, pentagon);
            Console.WriteLine("\nВивід масиву фігур : \n");
            picture.PrintArray();

            Picture picture2 = new Picture(3);
            Console.WriteLine("\nЗаповнення масиву трикутників...\n");
            Triangle eqTriangle = new EqTriangle(3);
            Triangle isTriangle = new IsTriangle(3, 45);
            Triangle rectTriangle = new RectTriangle(3, 5);
            picture2.FillArray(eqTriangle, isTriangle, rectTriangle);
            Console.WriteLine("\nВивід масиву трикутників : \n");
            picture2.PrintArray();

            Console.ReadLine();
        }
    }
}

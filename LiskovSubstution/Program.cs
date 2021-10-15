using System;

namespace LiskovSubstution
{
    class Program
    {
        /*
         * Bir derived class, base classın davranışını değiştiremez. Base - Derived birbirlerinin yerini alabilirler.
         * 
         */
        static void Main(string[] args)
        {
            var rect = GetRectangle(5);                  

            Console.WriteLine(rect.GetArea());

            var anotherRect = GetRectangle(5,3);

            Console.WriteLine(anotherRect.GetArea());
        }

        static ICalculateArea GetRectangle(int width)
        {
            return new Square { Width = width };
        }

        static ICalculateArea GetRectangle(int width,int height)
        {
            return new Rectangle() { Width = width, Height = height };
        }

    }

    public interface ICalculateArea
    {
        int GetArea();
    }
    public class Rectangle : ICalculateArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }

    }

    public class Square : ICalculateArea
    {
        public virtual int Width { get; set; }

        public int GetArea()
        {
            return Width * Width;
        }
    }

}

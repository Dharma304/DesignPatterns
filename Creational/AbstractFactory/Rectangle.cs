using System;
namespace MyAbstractFactory
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Rectangle is drawn");
        }
    }
}
using System;
namespace MyAbstractFactory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Circle is drwan");
        }
    }
}
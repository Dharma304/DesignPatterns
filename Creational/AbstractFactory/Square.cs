using System;
namespace MyAbstractFactory
{
    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Square is drwan");
        }
    }
}
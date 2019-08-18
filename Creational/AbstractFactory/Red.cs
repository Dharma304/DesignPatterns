using System;
namespace MyAbstractFactory
{
    public class Red:IColor
    {
        public void Fill()
        {
            System.Console.WriteLine("Red color generated");
        }
    }
}
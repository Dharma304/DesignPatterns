using System;
namespace MyAbstractFactory
{
    public class Blue : IColor
    {
        public void Fill()
        {
            System.Console.WriteLine("Blue color generated");
        }
    }
}
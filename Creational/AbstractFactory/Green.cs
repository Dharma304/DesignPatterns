using System;
namespace MyAbstractFactory
{
    public class Green:IColor
    {
        public void Fill()
        {
            System.Console.WriteLine("Green color generated");
        }

    }
}
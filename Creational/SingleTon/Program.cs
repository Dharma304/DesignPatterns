using System;

namespace DesignPattern.Creational.SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SingleTon.GetSingleTon() == SingleTon.GetSingleTon())
            {
                System.Console.WriteLine("Same instance");
            }
           
        }
    }
}

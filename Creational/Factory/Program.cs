using System;
namespace DesignPattern.Creational.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory ifactory;
            int id;
            Console.WriteLine("Please enter the id:");
            id = Convert.ToInt32(Console.ReadLine());
            ifactory = new Factory().CreateProductByID(id);
            Console.WriteLine(ifactory.CreateProduct());

        }
    }
}

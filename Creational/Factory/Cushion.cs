using System;
namespace DesignPattern.Creational.Factory
{
    public class Cushion : IFactory
    {
        public string CreateProduct()
        {
            return "Cushion product created";
        }

    }
}
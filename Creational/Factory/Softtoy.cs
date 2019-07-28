using System;
namespace DesignPattern.Creational.Factory
{
    public class Softtoy : IFactory
    {
        public string CreateProduct()
        {
            return "Soft toy product created";
        }
    }

}
using System;
namespace DesignPattern.Creational.Factory
{
    public class Craft:IFactory
    {
        public string CreateProduct()
        {
            return "Craft item created";
        }
        
    }
}
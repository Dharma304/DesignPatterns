using System;
namespace MyAbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string Choice)
        {
            if (Choice.ToUpper().Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (Choice.ToUpper().Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
            
        }
    }
}
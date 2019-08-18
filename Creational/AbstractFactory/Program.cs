using System;

namespace MyAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shape = FactoryProducer.GetFactory("SHAPE");
            IShape shapeObj = shape.GetShape("SQUARE");
            shapeObj.Draw();
            shapeObj = shape.GetShape("CIRCLE");
            shapeObj.Draw();
            shapeObj = shape.GetShape("RECTANGLE");
            shapeObj.Draw();
           
           AbstractFactory color= FactoryProducer.GetFactory("COLOR");
           IColor colorObj=color.GetColor("RED");
           colorObj.Fill();
           colorObj=color.GetColor("GREEN");
           colorObj.Fill();
           colorObj=color.GetColor("BLUE");
           colorObj.Fill();



        }
    }
}

using System;
namespace MyAbstractFactory
{
    public abstract class AbstractFactory
    {
      public  abstract IShape GetShape(string shapeType);
      public  abstract IColor GetColor(string colorType); 
    }
}
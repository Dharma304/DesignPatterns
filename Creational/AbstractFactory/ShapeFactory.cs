using System;
namespace MyAbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else
            {
                return null;
            }
        }
        public override IColor GetColor(string colorType)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
namespace MyAbstractFactory
{
    public class ColorFactory:AbstractFactory
    {
        public override IColor GetColor(string colorType)
        {
            if (colorType.ToUpper().Equals("RED"))
            {
                return new Red();
            }
            else if (colorType.ToUpper().Equals("GREEN"))
            {
                return new Green();
            }
            else if (colorType.ToUpper().Equals("BLUE"))
            {
                return new Blue();
            }
            else
            {
                return null;
            }
        }
        public override IShape GetShape(string shapeType) => null;
    }
}
using System.Linq;

namespace OCP
{
    public class AreaCalculator
    {
        public double Area(Shape[] shapes)
        {
            return shapes.Sum(shape => shape.Area());
        }
    }
}

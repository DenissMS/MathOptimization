using System.Drawing;

namespace CourseWork
{
    public class Graph
    {
        public PointF[] Coords;
        public Color DyeColor;

        public Graph(Color dyeColor, PointF[] coords)
        {
            DyeColor = dyeColor;
            Coords = coords;
        }
    }
}

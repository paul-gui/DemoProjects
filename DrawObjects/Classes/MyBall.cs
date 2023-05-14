using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects.Classes
{
    public class MyBall
    {
        public PointF Center { get; set; }
        public float Radius { get; set; }
        public Color Color { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public float Mass { get; set; }

        public PointF GetLocation()
        {
            return new PointF(Center.X - Radius, Center.Y - Radius);
        }

        public SizeF GetSize()
        {
            return new SizeF(Radius * 2, Radius * 2);
        }
    }
}

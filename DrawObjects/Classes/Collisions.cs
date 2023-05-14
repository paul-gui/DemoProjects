using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects.Classes
{
    public class Collisions
    {
        public PointF OneDimentional(float m1, float m2, float u1, float u2)
        {
            PointF v = new PointF
            {
                X = ((m1 - m2) / (m1 + m2)) * u1 + ((2 * m2) / (m1 + m2)) * u2,
                Y = ((2 * m1) / (m1 + m2)) * u1 + ((m2 - m1) / (m1 + m2)) * u2
            };
            return v;
        }
        //public PointF MultiDimensional(PointF v1, PointF v2, float m1, float m2, PointF x1, PointF x2)
        //{
        //    PointF newV = new PointF
        //    {
        //        X = (v1.X * v1.Y - ((2 * m2) / (m1 + m2)) * ((v1.X - v2.X) * (x1.X - x2.X) + (v1.Y - v2.Y) * (x1.Y - x2.Y)) / (Math.Abs(x1.X * x1.Y - x1.X * x2.Y) * Math.Abs(x1.X * x1.Y - x2.X * x2.Y))) * (x1.X * x1.Y - x1.X * x2.Y),
        //        Y = (v2.X * v2.Y - ((2 * m1) / (m1 + m2)) * ((v2.X - v1.X) * (x2.X - x1.X) + (v2.Y - v1.Y) * (x2.Y - x1.Y)) / (Math.Abs(x2.X * x2.Y - x1.X * x1.Y) * Math.Abs(x2.X * x2.Y - x1.X * x1.Y))) * (x2.X * x2.Y - x1.X * x1.Y)
        //    };
        //    return newV;
        //}
        //public PointF MultiDimensional(MyBall ball1, MyBall ball2)
        //{
        //    var angle = Math.Atan2(ball1.Center.Y - ball2.Center.Y, ball1.Center.X - ball2.Center.X);
        //}
    }
}

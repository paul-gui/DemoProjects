using MyDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects.Classes
{
	public static class MyMath
	{
		public static PointF GetIntersection(PointF p1, PointF p2, PointF p3, PointF p4)
		{
			try
			{
				var d = (p1.X - p2.X) * (p3.Y - p4.Y) - (p1.Y - p2.Y) * (p3.X - p4.X);
				PointF inter = new PointF
				{
					X = ((p1.X * p2.Y - p1.Y * p2.X) * (p3.X - p4.X) - (p1.X - p2.X) * (p3.X * p4.Y - p3.Y * p4.X)) / d,
					Y = ((p1.X * p2.Y - p1.Y * p2.X) * (p3.Y - p4.Y) - (p1.Y - p2.Y) * (p3.X * p4.Y - p3.Y * p4.X)) / d,
				};
				return inter;
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public static PointF GetIntersection(float m1, float m2, PointF p1, PointF p2)
		{
			try
			{
				PointF inter = new PointF
				{
					X = ((m1 * p1.X - p1.Y) - (m2 * p2.X - p2.Y)) / (m1 - m2),
					Y = m1 * ((m1 * p1.X - p1.Y) - (m2 * p2.X - p2.Y)) / (m1 - m2) - (m1 * p1.X - p1.Y),
				};
				return inter;
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}
	}
}

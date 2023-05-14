using MyDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects.Classes
{
	public class PointD
	{
		public double X { private get; set; }
		public double Y { get; private set; }

		public PointD() { }

		public PointD(double x, double y)
		{
			X = x;
			Y = y;
		}

		public PointF GetPointF()
		{
			try
			{
				return new PointF(Convert.ToSingle(X), Convert.ToSingle(Y));
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}
	}
}

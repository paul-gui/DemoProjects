using MyDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects.Classes
{
	public class MyLine
	{
		public PointF PointFrom { get; set; }
		public PointF PointTo { get; set; }
		public Color LineColor { get; set; }

		public MyLine(PointF pointFrom, PointF pointTo)
		{
			try
			{
				PointFrom = pointFrom;
				PointTo = pointTo;
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw ex;
			}
		}
	}
}

using MyDLL;
using System;
using System.Drawing;

namespace DrawObjects.Classes
{
	public class MyTransform
	{
		protected Graphics g;
		protected Size s;
		protected Point origin;

		public MyTransform(Graphics g, Size s, Point origin)
		{
			this.g = g;
			this.s = s;
			this.origin = origin;
		}

		protected void DrawTransformLine(Pen p, Point p1, Point p2)
		{
			try
			{
				g.DrawLine(p, PointToScreen(p1), PointToScreen(p2));
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected void DrawTransformLine(Pen p, PointF p1, PointF p2)
		{
			try
			{
				g.DrawLine(p, PointToScreen(p1), PointToScreen(p2));
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected void DrawTransformLine(Pen p, int x1, int y1, int x2, int y2)
		{
			try
			{
				var p1 = new Point(x1, y1);
				var p2 = new Point(x2, y2);
				DrawTransformLine(p, p1, p2);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected void DrawTransformLine(Pen p, float x1, float y1, float x2, float y2)
		{
			try
			{
				var p1 = new PointF(x1, y1);
				var p2 = new PointF(x2, y2);
				DrawTransformLine(p, p1, p2);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected void DrawTransformString(string s, Font font, PointF point, TextPosition textPosition = TextPosition.Top)
		{
			try
			{
				g.DrawString(s, font, new SolidBrush(Color.Black), PointToScreen(point));
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}
		protected void DrawTransformString(string s, Font font, float x, float y, TextPosition textPosition = TextPosition.Top)
		{
			try
			{
				var p = new PointF(x, y);
				g.DrawString(s, font, new SolidBrush(Color.Black), PointToScreen(p));
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected void DrawTransformEllipse(Pen p, PointF o, float radius)
		{
			try
			{
				o = PointToScreen(o);
				RectangleF rectangle = new RectangleF(o.X - radius, o.Y - radius, 2 * radius, 2 * radius);
				g.DrawEllipse(p, rectangle);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected Point PointToScreen(Point p)
		{
			try
			{
				var screenPoint = new Point
				{
					X = p.X + s.Width / 2,
					Y = s.Height / 2 - p.Y
				};

				return screenPoint;
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		protected PointF PointToScreen(PointF p)
		{
			try
			{
				var screenPoint = new PointF
				{
					X = p.X + origin.X,
					Y = origin.Y - p.Y
				};

				Logger.LogInfo($"p: {p.X}, {p.Y}; screenPoint: {screenPoint.X}, {screenPoint.Y}");

				return screenPoint;
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}
	}
}

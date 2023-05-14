using MyDLL;
using DrawObjects.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawObjects.Classes
{
	public class MyDraw : MyTransform
	{
		private readonly float epsilon = 0.001f;
		public MyDraw(Graphics g, Size s, Point origin) : base(g, s, origin) { }

		public void DrawXOY()
		{
			try
			{
				Font font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
				Pen myPen = new Pen(Color.Gray);
				g.DrawLine(myPen, 5, origin.Y, s.Width - 5, origin.Y);    //draw oX
				g.DrawLine(myPen, origin.X, 5, origin.X, s.Height - 5);      //draw oY
				g.DrawLine(myPen, s.Width - 5, origin.Y, s.Width - 10, origin.Y - 3);
				g.DrawLine(myPen, s.Width - 5, origin.Y, s.Width - 10, origin.Y + 3);  //draw oX arrow
				g.DrawLine(myPen, origin.X, 5, origin.X - 3, 10);
				g.DrawLine(myPen, origin.X, 5, origin.X + 3, 10);  //draw oY arrow
				g.DrawString("X", font, new SolidBrush(Color.Black), s.Width - 10, origin.Y + 10);
				g.DrawString("Y", font, new SolidBrush(Color.Black), origin.X + 10, 10);
				g.DrawString("O", font, new SolidBrush(Color.Gray), origin.X - 12, origin.Y + 1);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public void DrawPoint(string letter, PointF point, TextPosition textPosition)
		{
			try
			{
				var font = new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular);
				var size = g.MeasureString(letter, font);
				var brush = new SolidBrush(Color.Red);
				var pointToScreen = PointToScreen(new PointF(point.X, point.Y));
				Pen myPen = new Pen(Color.Red);
				Pen myDottedPen = new Pen(Color.Gray)
				{
					DashStyle = DashStyle.Dash,
				};

				Logger.LogInfo(letter);
				DrawTransformLine(myPen, new PointF(point.X - 2, point.Y - 2), new PointF(point.X + 2, point.Y + 2));
				DrawTransformLine(myPen, new PointF(point.X - 2, point.Y + 2), new PointF(point.X + 2, point.Y - 2));

				if (textPosition == TextPosition.Top)
				{
					DrawTransformString(letter, font, point.X - size.Width / 2, point.Y + size.Height);
				}
				if (textPosition == TextPosition.TopLeft)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y + size.Height);
				}
				if (textPosition == TextPosition.Left)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y + size.Height / 2);
				}
				if (textPosition == TextPosition.BottomLeft)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y);
				}
				if (textPosition == TextPosition.Bottom)
				{
					DrawTransformString(letter, font, point.X - size.Width / 2, point.Y);
				}
				if (textPosition == TextPosition.BottomRight)
				{
					DrawTransformString(letter, font, point.X, point.Y);
				}
				if (textPosition == TextPosition.Right)
				{
					DrawTransformString(letter, font, point.X + size.Width / 10, point.Y + size.Height / 2);
				}
				if (textPosition == TextPosition.TopRight)
				{
					DrawTransformString(letter, font, point.X, point.Y + size.Height);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public void DrawString(string letter, PointF point, TextPosition textPosition)
		{
			try
			{
				var font = new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular);
				var size = g.MeasureString(letter, font);

				Logger.LogInfo(letter);
				if (textPosition == TextPosition.Top)
				{
					DrawTransformString(letter, font, point.X - size.Width / 2, point.Y + size.Height);
				}
				if (textPosition == TextPosition.TopLeft)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y + size.Height);
				}
				if (textPosition == TextPosition.Left)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y + size.Height / 2);
				}
				if (textPosition == TextPosition.BottomLeft)
				{
					DrawTransformString(letter, font, point.X - size.Width, point.Y);
				}
				if (textPosition == TextPosition.Bottom)
				{
					DrawTransformString(letter, font, point.X - size.Width / 2, point.Y);
				}
				if (textPosition == TextPosition.BottomRight)
				{
					DrawTransformString(letter, font, point.X, point.Y);
				}
				if (textPosition == TextPosition.Right)
				{
					DrawTransformString(letter, font, point.X + size.Width / 10, point.Y + size.Height / 2);
				}
				if (textPosition == TextPosition.TopRight)
				{
					DrawTransformString(letter, font, point.X, point.Y + size.Height);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw ex;
			}
		}

		public void DrawLine(Pen p, PointF p1, PointF p2)
		{
			try
			{
				DrawTransformLine(p, p1, p2);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public void DrawTriangleWithCiecleOutside(Pen p, PointF p1, PointF p2, PointF p3)
		{
			try
			{
				var slope1 = (p2.Y - p1.Y) / (p2.X - p1.X);
				var slope2 = (p3.Y - p2.Y) / (p3.X - p2.X);
				DrawLine(p, p1, p2);
				DrawLine(p, p2, p3);
				DrawLine(p, p3, p1);
				PointF center;
				PointF m1 = new PointF
				{
					X = (p1.X + p2.X) / 2,
					Y = (p1.Y + p2.Y) / 2,
				};
				PointF m2 = new PointF
				{
					X = (p2.X + p3.X) / 2,
					Y = (p2.Y + p3.Y) / 2,
				};

				if (Math.Abs(slope1) < epsilon)
				{
					center = MyMath.GetIntersection(new PointF(m1.X, 0), new PointF(m1.X, 10), m2, new PointF(2, (-1 / slope2) * 2 + (m2.Y - (-1 * slope2) * m2.X)));
				}
				else if (Math.Abs(slope2) == 0)
				{
					center = MyMath.GetIntersection(new PointF(m2.X, 0), new PointF(m2.X, 10), m1, new PointF(2, (-1 / slope1) * 2 + (m1.Y - (-1 / slope1) * m1.X)));
				}
				else
				{
					center = MyMath.GetIntersection(-1 / slope1, -1 / slope2, m1, m2);
				}
				DrawPoint("M1", m1, TextPosition.BottomRight);
				DrawPoint("M2", m2, TextPosition.BottomLeft);
				Pen redp = new Pen(Color.Red);
				DrawLine(redp, m1, center);
				DrawLine(redp, m2, center);
				DrawPoint("", center, TextPosition.TopLeft);
				float radius = Convert.ToSingle(Math.Sqrt((center.X - p1.X) * (center.X - p1.X) + (center.Y - p1.Y) * (center.Y - p1.Y)));
				g.DrawEllipse(p, PointToScreen(center).X - radius, PointToScreen(center).Y - radius, 2 * radius, 2 * radius);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public void DrawTriangle(Pen p, PointF p1, PointF p2, PointF p3)
		{
			try
			{
				DrawLine(p, p1, p2);
				DrawLine(p, p2, p3);
				DrawLine(p, p3, p1);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}

		public void DrawTriangleWithCircleInside(Pen p, PointF p1, PointF p2, PointF p3)
		{
			try
			{
				var slope1 = (p2.Y - p1.Y) / (p2.X - p1.X);
				var slope2 = (p3.Y - p2.Y) / (p3.X - p2.X);
				DrawLine(p, p1, p2);
				DrawLine(p, p2, p3);
				DrawLine(p, p3, p1);
				float slopebis1;
				float slopebis2;
				slopebis1 = (slope1 * slope2 - 1 + Convert.ToSingle(Math.Sqrt((slope1 * slope1 + 1) * (slope2 * slope2 + 1)))) / (slope1 + slope2);
				if (slope1 < 0)
				{
					slopebis1 = -1 / slopebis1;
				}
				slope1 = (p3.Y - p1.Y) / (p3.X - p1.X);
				slopebis2 = (slope2 * slope1 - 1 + Convert.ToSingle(Math.Sqrt((slope2 * slope2 + 1) * (slope1 * slope1 + 1)))) / (slope2 + slope1);
				if (slope2 < 0)
				{
					slopebis2 = -1 / slopebis2;
				}
				var o = MyMath.GetIntersection(slopebis1, slopebis2, p2, p3);
				DrawPoint("", o, TextPosition.TopLeft);
				var dist = Convert.ToSingle(Math.Abs((p2.X - p1.X) * (p1.Y - o.Y) - (p1.X - o.X) * (p2.Y - p1.Y))) /
					Convert.ToSingle(Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)));
				DrawTransformEllipse(p, o, dist);
			}
			catch (Exception ex)
			{
				Logger.LogError(ex);
				throw;
			}
		}
	}
}

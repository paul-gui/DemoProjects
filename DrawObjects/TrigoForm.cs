using MyDLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using DrawObjects.Classes;
using System.Collections.Generic;

namespace DrawObjects
{
	public partial class TrigoForm : Form
	{
		private double eps = 1e-4;
		private double maxY = 5;
		public FormType FormType { get; set; }

		private readonly List<MyLine> lines = new List<MyLine>();

		//private List<Tuple<PointF, PointF>> tupleLines = new List<Tuple<PointF, PointF>>();

		public TrigoForm()
		{
			InitializeComponent();

			panel1.Location = new Point(10, 10);
			panel1.Size = new Size(ClientSize.Width - 20, this.ClientSize.Height - 20);
		}

		public void PrepareGraph()
		{
			try
			{
				PointF? prevPoint = null;
				for (var x = -Math.PI * 3; x <= Math.PI * 3 + eps; x += Math.PI / 1000)
				{
					if (FormType == FormType.Sin)
					{
						var y = Math.Sin(x);

						var point = new PointF(Convert.ToSingle(x * 50), Convert.ToSingle(y * 50));

						if (prevPoint == null)
						{
							prevPoint = point;
						}
						else
						{
							lines.Add(new MyLine(prevPoint.Value, point));
							prevPoint = point;
						}
					}

					if (FormType == FormType.Cos)
					{
						var y = Math.Cos(x);

						var point = new PointF(Convert.ToSingle(x * 50), Convert.ToSingle(y * 50));

						if (prevPoint == null)
						{
							prevPoint = point;
						}
						else
						{
							lines.Add(new MyLine(prevPoint.Value, point));
							prevPoint = point;
						}
					}

					if (FormType == FormType.Tan)
					{
						var y = Math.Sin(x) / Math.Cos(x);
						y = Math.Abs(y) > maxY ? Math.Sign(y) * maxY : y;
						var point = new PointF(Convert.ToSingle(x * 50), Convert.ToSingle(y * 50));
						if (prevPoint == null || Math.Sign(y) != Math.Sign(prevPoint.Value.Y) || Math.Abs(y) == maxY)
						{
							prevPoint = point;
						}
						else
						{
							lines.Add(new MyLine(prevPoint.Value, point));
							prevPoint = point;
						}
					}

					if (FormType == FormType.CoTan)
					{
						var y = Math.Cos(x) / Math.Sin(x);
						y = Math.Abs(y) > maxY ? Math.Sign(y) * maxY : y;
						var point = new PointF(Convert.ToSingle(x * 50), Convert.ToSingle(y * 50));
						if (prevPoint == null || Math.Sign(y) != Math.Sign(prevPoint.Value.Y) || Math.Abs(y) == maxY)
						{
							prevPoint = point;
						}
						else
						{
							lines.Add(new MyLine(prevPoint.Value, point));
							prevPoint = point;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Trigo 101");
				Logger.LogError(ex);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics g = e.Graphics;
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				DrawTrigo(g, ((Panel)sender).Size);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Trigo 102");
				Logger.LogError(ex);
			}
		}

		private void TrigoForm_Resize(object sender, EventArgs e)
		{
			try
			{
				panel1.Location = new Point(10, 10);
				panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
				panel1.Invalidate();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Trigo 103");
				Logger.LogError(ex);
			}
		}

		private void DrawTrigo(Graphics g, Size s)
		{
			try
			{
				Pen p = new Pen(Color.Black);
				Pen pdotted = new Pen(Color.Gray)
				{
					DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
				};
				var myDraw = new MyDraw(g, s, new Point(s.Width / 2, s.Height / 2));
				myDraw.DrawXOY();
				if (FormType == FormType.Sin)
				{
					myDraw.DrawPoint("-3π", new PointF(-Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.Top);
					myDraw.DrawPoint("-5π/2", new PointF(-Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), new PointF(-Convert.ToSingle((Math.PI * 5) / 2 * 50), -50));
					myDraw.DrawPoint("-2π", new PointF(-Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.BottomRight);
					myDraw.DrawPoint("-3π/2", new PointF(-Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), TextPosition.Bottom);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), new PointF(-Convert.ToSingle((Math.PI * 3) / 2 * 50), 50));
					myDraw.DrawPoint("-π", new PointF(-Convert.ToSingle(Math.PI * 50), 0), TextPosition.BottomLeft);
					myDraw.DrawPoint("-π/2", new PointF(-Convert.ToSingle(Math.PI / 2 * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI / 2 * 50), 0), new PointF(-Convert.ToSingle(Math.PI / 2 * 50), -50));
					myDraw.DrawPoint("π/2", new PointF(Convert.ToSingle(Math.PI / 2 * 50), 0), TextPosition.Bottom);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI / 2 * 50), 0), new PointF(Convert.ToSingle(Math.PI / 2 * 50), 50));
					myDraw.DrawPoint("π", new PointF(Convert.ToSingle(Math.PI * 50), 0), TextPosition.BottomLeft);
					myDraw.DrawPoint("3π/2", new PointF(Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), new PointF(Convert.ToSingle((Math.PI * 3) / 2 * 50), -50));
					myDraw.DrawPoint("2π", new PointF(Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.BottomRight);
					myDraw.DrawPoint("5π/2", new PointF(Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), TextPosition.Bottom);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), new PointF(Convert.ToSingle((Math.PI * 5) / 2 * 50), 50));
					myDraw.DrawPoint("3π", new PointF(Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.Bottom);
				}
				else if (FormType == FormType.Cos)
				{
					myDraw.DrawPoint("-3π", new PointF(-Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle((Math.PI * 3) * 50), 0), new PointF(-Convert.ToSingle((Math.PI * 3) * 50), -50));
					myDraw.DrawPoint("-5π/2", new PointF(-Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), TextPosition.BottomRight);
					myDraw.DrawPoint("-2π", new PointF(-Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.Bottom);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle((Math.PI * 2) * 50), 0), new PointF(-Convert.ToSingle((Math.PI * 2) * 50), 50));
					myDraw.DrawPoint("-3π/2", new PointF(-Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), TextPosition.BottomLeft);
					myDraw.DrawPoint("-π", new PointF(-Convert.ToSingle(Math.PI * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI * 50), 0), new PointF(-Convert.ToSingle(Math.PI * 50), -50));
					myDraw.DrawPoint("-π/2", new PointF(-Convert.ToSingle(Math.PI / 2 * 50), 0), TextPosition.BottomRight);
					myDraw.DrawPoint("π/2", new PointF(Convert.ToSingle(Math.PI / 2 * 50), 0), TextPosition.BottomLeft);
					myDraw.DrawPoint("π", new PointF(Convert.ToSingle(Math.PI * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI * 50), 0), new PointF(Convert.ToSingle(Math.PI * 50), -50));
					myDraw.DrawPoint("3π/2", new PointF(Convert.ToSingle((Math.PI * 3) / 2 * 50), 0), TextPosition.BottomRight);
					myDraw.DrawPoint("2π", new PointF(Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.Bottom);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle((Math.PI * 2) * 50), 0), new PointF(Convert.ToSingle((Math.PI * 2) * 50), 50));
					myDraw.DrawPoint("5π/2", new PointF(Convert.ToSingle((Math.PI * 5) / 2 * 50), 0), TextPosition.BottomLeft);
					myDraw.DrawPoint("3π", new PointF(Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.Top);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle((Math.PI * 3) * 50), 0), new PointF(Convert.ToSingle((Math.PI * 3) * 50), -50));
				}
				else if (FormType == FormType.Tan)
				{
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI * 5 / 2) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI * 5 / 2) * 50, s.Height / 2));
					myDraw.DrawString("-5π/2", new PointF(-Convert.ToSingle(Math.PI * 5 / 2) * 50, 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI * 3 / 2) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI * 3 / 2) * 50, s.Height / 2));
					myDraw.DrawString("-3π/2", new PointF(-Convert.ToSingle(Math.PI * 3 / 2) * 50, 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI / 2) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI / 2) * 50, s.Height / 2));
					myDraw.DrawString("-π/2", new PointF(-Convert.ToSingle(Math.PI / 2) * 50, 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI / 2) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI / 2) * 50, s.Height / 2));
					myDraw.DrawString("π/2", new PointF(Convert.ToSingle(Math.PI / 2) * 50, 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI * 3 / 2) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI * 3 / 2) * 50, s.Height / 2));
					myDraw.DrawString("3π/2", new PointF(Convert.ToSingle(Math.PI * 3 / 2) * 50, 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI * 5 / 2) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI * 5 / 2) * 50, s.Height / 2));
					myDraw.DrawString("5π/2", new PointF(Convert.ToSingle(Math.PI * 5 / 2) * 50, 0), TextPosition.TopLeft);
				}
				else if (FormType == FormType.CoTan)
				{
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI * 3) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI * 3) * 50, s.Height / 2));
					myDraw.DrawString("-3π", new PointF(-Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI * 2) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI * 2) * 50, s.Height / 2));
					myDraw.DrawString("-2π", new PointF(-Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(-Convert.ToSingle(Math.PI) * 50, -s.Height / 2), new PointF(-Convert.ToSingle(Math.PI) * 50, s.Height / 2));
					myDraw.DrawString("-π", new PointF(-Convert.ToSingle(Math.PI * 50), 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI) * 50, s.Height / 2));
					myDraw.DrawString("π", new PointF(Convert.ToSingle(Math.PI * 50), 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI * 2) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI * 2) * 50, s.Height / 2));
					myDraw.DrawString("2π", new PointF(Convert.ToSingle(Math.PI * 2 * 50), 0), TextPosition.TopLeft);
					myDraw.DrawLine(pdotted, new PointF(Convert.ToSingle(Math.PI * 3) * 50, -s.Height / 2), new PointF(Convert.ToSingle(Math.PI * 3) * 50, s.Height / 2));
					myDraw.DrawString("3π", new PointF(Convert.ToSingle(Math.PI * 3 * 50), 0), TextPosition.TopLeft);
				}

				if (FormType == FormType.Sin || FormType == FormType.Cos)
				{
					myDraw.DrawLine(pdotted, new PointF(-s.Width / 2 + 5, 50), new PointF(s.Width / 2 - 5, 50));
					myDraw.DrawLine(pdotted, new PointF(-s.Width / 2 + 5, -50), new PointF(s.Width / 2 - 5, -50));
					myDraw.DrawString("1", new PointF(s.Width / 2 - 10, 50), TextPosition.Top);
					myDraw.DrawString("-1", new PointF(s.Width / 2 - 10, -50), TextPosition.Bottom);
				}

				foreach (var tmp in lines) //.Where(x => x.PointFrom.Y > 10))
				{
					myDraw.DrawLine(p, tmp.PointFrom, tmp.PointTo);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Trigo 104");
				Logger.LogError(ex);
			}
		}
	}
}

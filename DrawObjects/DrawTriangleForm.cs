using DrawObjects.Classes;
using MyDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawObjects
{
	public partial class DrawTriangleForm : Form
	{
		public DrawTriangleForm()
		{
			try
			{
				InitializeComponent();

				panel1.Location = new Point(10, 10);
				panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error TriangleForm 101!");
				Logger.LogError(ex);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics g = e.Graphics;
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				ExampleDrawTriangle(g, ((Panel)sender).Size);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error TriangleForm 102");
				Logger.LogError(ex);
			}
		}

		private void DrawTriangleForm_Resize(object sender, EventArgs e)
		{
			try
			{
				panel1.Location = new Point(10, 10);
				panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
				panel1.Invalidate();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error TriangleForm 103");
				Logger.LogError(ex);
			}
		}

		private void ExampleDrawTriangle(Graphics g, Size s)
		{
			try
			{
				var A = new PointF(-100, 100);
				var B = new PointF(0, 0);
				var C = new PointF(100, 0.00001f);

				var m1 = (B.Y - A.Y) / (B.X - A.X);
				var m2 = (C.Y - B.Y) / (C.X - B.X);

				Pen myPen = new Pen(Color.Black)
				{
					Width = 0.5f
				};

				var myDraw = new MyDraw(g, s, new Point(s.Width / 2, s.Height / 2));
				myDraw.DrawXOY();
				myDraw.DrawPoint("A", A, TextPosition.TopRight);
				myDraw.DrawPoint("B", B, TextPosition.BottomLeft);
				myDraw.DrawPoint("C", C, TextPosition.BottomRight);
				myDraw.DrawTriangle(myPen, A, B, C);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error TriangleForm 104");
				Logger.LogError(ex);
			}
		}
	}
}

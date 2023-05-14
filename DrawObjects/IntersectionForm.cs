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
	public partial class IntersectionForm : Form
	{
		public IntersectionForm()
		{
			try
			{
				InitializeComponent();

				panel1.Location = new Point(10, 10);
				panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Intersection 101");
				Logger.LogError(ex);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics g = e.Graphics;
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				ExampleIntersection2Lines(g, ((Panel)sender).Size);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Intersection 102");
				Logger.LogError(ex);
			}
		}

		private void IntersectionForm_Resize(object sender, EventArgs e)
		{
			try
			{
				panel1.Location = new Point(10, 10);
				panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
				panel1.Invalidate();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error Intersection 103");
				Logger.LogError(ex);
			}
		}

		private void ExampleIntersection2Lines(Graphics g, Size s)
		{
			try
			{
				PointF A = new PointF(100f, 40f);
				PointF B = new PointF(-150f, -50f);
				PointF C = new PointF(60f, -70f);
				PointF D = new PointF(-50f, 10f);

				Pen myPen = new Pen(Color.Black)
				{
					Width = 0.5f,
				};

				var myDraw = new MyDraw(g, s, new Point(200, 100));
				myDraw.DrawXOY();
				myDraw.DrawPoint("A", A, TextPosition.TopRight);
				myDraw.DrawPoint("B", B, TextPosition.TopRight);
				myDraw.DrawPoint("C", C, TextPosition.TopRight);
				myDraw.DrawPoint("D", D, TextPosition.TopRight);
				myDraw.DrawLine(myPen, A, B);
				myDraw.DrawLine(myPen, C, D);
				var m1 = (B.Y - A.Y) / (B.X - A.X);
				var m2 = (D.Y - C.Y) / (D.X - C.X);
				myDraw.DrawPoint("E", MyMath.GetIntersection(m1, m2, A, C), TextPosition.Top);
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error Intersection 104");
				Logger.LogError(ex);
			}
		}

	}
}

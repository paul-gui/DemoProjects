using DrawObjects.Classes;
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
	public partial class TextPositionForm : Form
	{
		public TextPositionForm()
		{
			InitializeComponent();

			panel1.Location = new Point(10, 10);
			panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Example2TextPosition(g, ((Panel)sender).Size);
		}

		private void TextPositionForm_Resize(object sender, EventArgs e)
		{
			panel1.Location = new Point(10, 10);
			panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
			panel1.Invalidate();
		}

		private void Example2TextPosition(Graphics g, Size s)
		{
			var myDraw = new MyDraw(g, s, new Point(100, 100));
			myDraw.DrawPoint("T", new PointF(0, 10), TextPosition.Top);
			myDraw.DrawPoint("TL", new PointF(50, 10), TextPosition.TopLeft);
			myDraw.DrawPoint("L", new PointF(100, 10), TextPosition.Left);
			myDraw.DrawPoint("BL", new PointF(150, 10), TextPosition.BottomLeft);
			myDraw.DrawPoint("Bottom", new PointF(200, 10), TextPosition.Bottom);
			myDraw.DrawPoint("BR", new PointF(250, 10), TextPosition.BottomRight);
			myDraw.DrawPoint("Right", new PointF(300, 10), TextPosition.Right);
			myDraw.DrawPoint("TR", new PointF(350, 10), TextPosition.TopRight);
		}
	}
}

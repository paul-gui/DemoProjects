using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;


namespace Clock
{
	public partial class myform : Form
	{
		Panel clock;
		int lastSec = -1;
		public myform()
		{
			InitializeComponent();

			clock = new Panel
			{
				Size = new Size(200, 200),
				Location = new Point(0, 0),
				BackColor = Color.LightGray
			};
			clock.Paint += circlePaint;
			this.Controls.Add(clock);
			//SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			//clock.BackColor = Color.Transparent;
		}

		void circlePaint(object sender, PaintEventArgs e)
		{

			Graphics g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen p1 = new Pen(Color.Black, 1);
			Pen p2 = new Pen(Color.Black, 2);

			g.DrawEllipse(p1, new System.Drawing.Rectangle(10, 10, 180, 180));

			for (int i = 0; i < 360; i += 6)
            {				
				g.TranslateTransform(100, 100);
				g.RotateTransform(i);
				g.TranslateTransform(-100, -100);
				g.DrawLine(i % 30 == 0 ? p2 : p1, 100, 10, 100, i % 30 == 0 ? 20 : 15);

				g.ResetTransform();
			}

			DateTime dt = DateTime.Now;

			Console.WriteLine(dt.ToString("HH:mm:ss:ffffff"));

			g.TranslateTransform(100, 100);
			g.RotateTransform(dt.Hour * 30 + dt.Minute / 2 + dt.Second / 120);
			g.TranslateTransform(-100, -100);
			Pen acOrar = new Pen(Color.Black, 2);
			g.DrawLine(acOrar, 100, 40, 100, 97);
			g.DrawEllipse(acOrar, 97, 97, 6, 6);
			g.DrawLine(acOrar, 100, 103, 100, 110);

			g.ResetTransform();

			g.TranslateTransform(100, 100);
			g.RotateTransform(dt.Minute * 6 + dt.Second / 10);
			g.TranslateTransform(-100, -100);
			Pen acMinutar = new Pen(Color.Black);
			g.DrawLine(acMinutar, 100, 30, 100, 110);

			g.ResetTransform();

			g.TranslateTransform(100, 100);
			g.RotateTransform(dt.Second * 6);
			g.TranslateTransform(-100, -100);
			Pen acSecundar = new Pen(Color.Black, 0.5f);
			g.DrawLine(new Pen(Color.Black), 100, 20, 100, 110);

			g.ResetTransform();
		}

		void myform_Paint(object sender, PaintEventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int newSec = DateTime.Now.Second;
			if (newSec != lastSec)
            {
				clock.Invalidate();
				lastSec = newSec;
			}
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myform_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }

        private void myform_Resize(object sender, EventArgs e)
        {
			if (this.WindowState == FormWindowState.Minimized)
            {
				Hide();
				notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}

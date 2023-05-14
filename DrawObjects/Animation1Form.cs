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
    public partial class Animation1Form : Form
    {
        Panel Box = new Panel();

        List<MyBall> myBalls = new List<MyBall>();

        public Animation1Form()
        {
            try
            {
                InitializeComponent();

                panel1.Location = new Point(10, 10);
                panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);

                //Box.Location = new Point(0, 100);
                //Box.Size = new Size(20, 20);
                //Box.BackColor = Color.Blue;

                myBalls.Add(new MyBall
                {
                    Center = new PointF(100, 100),
                    Radius = 20,
                    Color = Color.Green,
                    VelocityX = 5,
                    VelocityY = 5,
                    Mass = 10
                });

                myBalls.Add(new MyBall
                {
                    Center = new PointF(200, 200),
                    Radius = 10,
                    Color = Color.Red,
                    VelocityX = -5,
                    VelocityY = -5,
                    Mass = 20
                });

                //var collisions = new Collisions();
                //myBalls.Add(new MyBall
                //{
                //    Center = new PointF(300, 100),
                //    Radius = 30,
                //    Color = Color.Yellow,
                //    VelocityX = 50,
                //    VelocityY = 2
                //});

                //panel1.Controls.Add(Ball1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Animation1 101");
                Logger.LogError(ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                foreach (var myBall in myBalls)
                {
                    var brush = new SolidBrush(myBall.Color);
                    g.FillEllipse(brush, new RectangleF(myBall.GetLocation(), myBall.GetSize()));
                }
                //ExampleDrawTriangle(g, ((Panel)sender).Size);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Animation1 102");
                Logger.LogError(ex);
            }
        }

        private void Animation1Form_Resize(object sender, EventArgs e)
        {
            try
            {
                panel1.Location = new Point(10, 10);
                panel1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 20);
                panel1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Animation1 103");
                Logger.LogError(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var myBall in myBalls)
            {
                if (myBall.Center.X - myBall.Radius + myBall.VelocityX < 0 || myBall.Center.X + myBall.Radius + myBall.VelocityX > panel1.Size.Width)
                {
                    myBall.VelocityX *= -1;
                }
                if (myBall.Center.Y - myBall.Radius + myBall.VelocityY < 0 || myBall.Center.Y + myBall.Radius + myBall.VelocityY > panel1.Size.Height)
                {
                    myBall.VelocityY *= -1;
                }

                myBall.Center = new PointF(myBall.Center.X + myBall.VelocityX, myBall.Center.Y + myBall.VelocityY);
            }
            var collisions = new Collisions();
            // elastic collision
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(myBalls.ElementAt(0).Center.X - myBalls.ElementAt(1).Center.X, 2) + Math.Pow(myBalls.ElementAt(0).Center.Y - myBalls.ElementAt(1).Center.Y, 2));

            if (distanceBetweenCenters <= myBalls.ElementAt(0).Radius + myBalls.ElementAt(1).Radius + 5)
            {
                double velocity1 = collisions.OneDimentional(myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).VelocityX, myBalls.ElementAt(1).VelocityX).X;
                double velocity2 = collisions.OneDimentional(myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).VelocityX, myBalls.ElementAt(1).VelocityX).Y;
                myBalls.ElementAt(0).VelocityX = Convert.ToSingle(velocity1);
                myBalls.ElementAt(1).VelocityX = Convert.ToSingle(velocity2);
            }

            if (distanceBetweenCenters <= myBalls.ElementAt(0).Radius + myBalls.ElementAt(1).Radius + 5)
            {
                double velocity1 = collisions.OneDimentional(myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).VelocityY, myBalls.ElementAt(1).VelocityY).X;
                double velocity2 = collisions.OneDimentional(myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).VelocityY, myBalls.ElementAt(1).VelocityY).Y;
                myBalls.ElementAt(0).VelocityY = Convert.ToSingle(velocity1);
                myBalls.ElementAt(1).VelocityY = Convert.ToSingle(velocity2);
            }
            //PointF v1 = new PointF
            //{
            //    X = myBalls.ElementAt(0).VelocityX,
            //    Y = myBalls.ElementAt(0).VelocityY
            //};
            //PointF v2 = new PointF
            //{
            //    X = myBalls.ElementAt(1).VelocityX,
            //    Y = myBalls.ElementAt(1).VelocityY
            //};
            //if (distanceBetweenCenters <= myBalls.ElementAt(0).Radius + myBalls.ElementAt(1).Radius + 5)
            //{
            //    PointF velocity1 = collisions.MultiDimensional(v1, v2, myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).Center, myBalls.ElementAt(1).Center);
            //    PointF velocity2 = collisions.MultiDimensional(v1, v2, myBalls.ElementAt(0).Mass, myBalls.ElementAt(1).Mass, myBalls.ElementAt(0).Center, myBalls.ElementAt(1).Center);
            //    myBalls.ElementAt(0).VelocityX = velocity1.X;
            //    myBalls.ElementAt(0).VelocityY = velocity1.Y;
            //    myBalls.ElementAt(1).VelocityX = velocity2.X;
            //    myBalls.ElementAt(1).VelocityY = velocity2.Y;
            //}
            panel1.Invalidate();
        }
    }
}

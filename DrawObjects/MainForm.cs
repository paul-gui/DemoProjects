using DrawObjects.Classes;
using MyDLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawObjects
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			try
			{
				InitializeComponent();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 101");
				Logger.LogError(ex);
			}
		}

		private void IntersectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				new IntersectionForm
				{
					MdiParent = this,
					WindowState = FormWindowState.Maximized
				}.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 102");
				Logger.LogError(ex);
			}
		}

		private void TextPositionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new TextPositionForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 103");
				Logger.LogError(ex);
			}
		}

		private void DrawTriangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new DrawTriangleForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 104");
				Logger.LogError(ex);
			}
		}

		private void DrawWithOutsideCircleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new DrawTriangleWithCircleOutsideForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 105");
				Logger.LogError(ex);
			}
		}

		private void DrawWithInsideCircleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new DrawTriangleWithCircleInsideForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 106");
				Logger.LogError(ex);
			}
		}

		private void SinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new TrigoForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.FormType = FormType.Sin;
				form.PrepareGraph();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 107");
				Logger.LogError(ex);
			}
		}

		private void CosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new TrigoForm
				{
					MdiParent = this,
					WindowState = FormWindowState.Maximized,
					FormType = FormType.Cos
				};
				form.PrepareGraph();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 108");
				Logger.LogError(ex);
			}
		}

		private void TanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new TrigoForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.FormType = FormType.Tan;
				form.PrepareGraph();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 109");
				Logger.LogError(ex);
			}
		}

		private void CoTanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				CloseAllChildren();

				var form = new TrigoForm();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.FormType = FormType.CoTan;
				form.PrepareGraph();
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 109");
				Logger.LogError(ex);
			}
		}

		private void CloseAllChildren()
		{
			try
			{
				foreach (Form frm in this.MdiChildren)
				{
					frm.Dispose();
					frm.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 111");
				Logger.LogError(ex);
			}
		}

        private void animation1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			try
			{
				CloseAllChildren();

				var form = new Animation1Form();
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MainForm 112");
				Logger.LogError(ex);
			}
		}
    }
}

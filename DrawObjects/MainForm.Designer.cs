
namespace DrawObjects
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IntersectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawWithOutsideCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawWithInsideCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoTanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.help2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animation1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animation2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntersectionToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.TextPositionToolStripMenuItem,
            this.trigoToolStripMenuItem,
            this.animationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IntersectionToolStripMenuItem
            // 
            this.IntersectionToolStripMenuItem.Name = "IntersectionToolStripMenuItem";
            this.IntersectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.IntersectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.IntersectionToolStripMenuItem.Text = "Intersection";
            this.IntersectionToolStripMenuItem.Click += new System.EventHandler(this.IntersectionToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawTriangleToolStripMenuItem,
            this.DrawWithOutsideCircleToolStripMenuItem,
            this.DrawWithInsideCircleToolStripMenuItem});
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // DrawTriangleToolStripMenuItem
            // 
            this.DrawTriangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangleToolStripMenuItem.Image")));
            this.DrawTriangleToolStripMenuItem.Name = "DrawTriangleToolStripMenuItem";
            this.DrawTriangleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DrawTriangleToolStripMenuItem.Text = "Draw";
            this.DrawTriangleToolStripMenuItem.Click += new System.EventHandler(this.DrawTriangleToolStripMenuItem_Click);
            // 
            // DrawWithOutsideCircleToolStripMenuItem
            // 
            this.DrawWithOutsideCircleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DrawWithOutsideCircleToolStripMenuItem.Image")));
            this.DrawWithOutsideCircleToolStripMenuItem.Name = "DrawWithOutsideCircleToolStripMenuItem";
            this.DrawWithOutsideCircleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DrawWithOutsideCircleToolStripMenuItem.Text = "Draw with outside circle";
            this.DrawWithOutsideCircleToolStripMenuItem.Click += new System.EventHandler(this.DrawWithOutsideCircleToolStripMenuItem_Click);
            // 
            // DrawWithInsideCircleToolStripMenuItem
            // 
            this.DrawWithInsideCircleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DrawWithInsideCircleToolStripMenuItem.Image")));
            this.DrawWithInsideCircleToolStripMenuItem.Name = "DrawWithInsideCircleToolStripMenuItem";
            this.DrawWithInsideCircleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.DrawWithInsideCircleToolStripMenuItem.Text = "Draw with inside circle";
            this.DrawWithInsideCircleToolStripMenuItem.Click += new System.EventHandler(this.DrawWithInsideCircleToolStripMenuItem_Click);
            // 
            // TextPositionToolStripMenuItem
            // 
            this.TextPositionToolStripMenuItem.Name = "TextPositionToolStripMenuItem";
            this.TextPositionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.TextPositionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.TextPositionToolStripMenuItem.Text = "Text Position";
            this.TextPositionToolStripMenuItem.Click += new System.EventHandler(this.TextPositionToolStripMenuItem_Click);
            // 
            // trigoToolStripMenuItem
            // 
            this.trigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinToolStripMenuItem,
            this.CosToolStripMenuItem,
            this.TanToolStripMenuItem,
            this.CoTanToolStripMenuItem});
            this.trigoToolStripMenuItem.Name = "trigoToolStripMenuItem";
            this.trigoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.trigoToolStripMenuItem.Text = "Trigo";
            // 
            // SinToolStripMenuItem
            // 
            this.SinToolStripMenuItem.Name = "SinToolStripMenuItem";
            this.SinToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.SinToolStripMenuItem.Text = "Sin";
            this.SinToolStripMenuItem.Click += new System.EventHandler(this.SinToolStripMenuItem_Click);
            // 
            // CosToolStripMenuItem
            // 
            this.CosToolStripMenuItem.Name = "CosToolStripMenuItem";
            this.CosToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.CosToolStripMenuItem.Text = "Cos";
            this.CosToolStripMenuItem.Click += new System.EventHandler(this.CosToolStripMenuItem_Click);
            // 
            // TanToolStripMenuItem
            // 
            this.TanToolStripMenuItem.Name = "TanToolStripMenuItem";
            this.TanToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.TanToolStripMenuItem.Text = "Tan";
            this.TanToolStripMenuItem.Click += new System.EventHandler(this.TanToolStripMenuItem_Click);
            // 
            // CoTanToolStripMenuItem
            // 
            this.CoTanToolStripMenuItem.Name = "CoTanToolStripMenuItem";
            this.CoTanToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.CoTanToolStripMenuItem.Text = "CoTan";
            this.CoTanToolStripMenuItem.Click += new System.EventHandler(this.CoTanToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help1ToolStripMenuItem,
            this.toolStripSeparator1,
            this.help2ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // help1ToolStripMenuItem
            // 
            this.help1ToolStripMenuItem.Name = "help1ToolStripMenuItem";
            this.help1ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.help1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.help1ToolStripMenuItem.Text = "Help1";
            this.help1ToolStripMenuItem.ToolTipText = "bla bla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // help2ToolStripMenuItem
            // 
            this.help2ToolStripMenuItem.AutoToolTip = true;
            this.help2ToolStripMenuItem.Name = "help2ToolStripMenuItem";
            this.help2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.help2ToolStripMenuItem.Text = "Help2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item1ToolStripMenuItem.Text = "item1";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.item2ToolStripMenuItem.Text = "item2";
            // 
            // animationToolStripMenuItem
            // 
            this.animationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animation1ToolStripMenuItem,
            this.animation2ToolStripMenuItem});
            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            this.animationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.animationToolStripMenuItem.Text = "Animations";
            // 
            // animation1ToolStripMenuItem
            // 
            this.animation1ToolStripMenuItem.Name = "animation1ToolStripMenuItem";
            this.animation1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animation1ToolStripMenuItem.Text = "Animation 1";
            this.animation1ToolStripMenuItem.Click += new System.EventHandler(this.animation1ToolStripMenuItem_Click);
            // 
            // animation2ToolStripMenuItem
            // 
            this.animation2ToolStripMenuItem.Name = "animation2ToolStripMenuItem";
            this.animation2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animation2ToolStripMenuItem.Text = "Animation 2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 470);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem IntersectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem help1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem help2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TextPositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DrawTriangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DrawWithOutsideCircleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DrawWithInsideCircleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem trigoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem TanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CoTanToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animation1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animation2ToolStripMenuItem;
    }
}


namespace BasicCalculator
{
    partial class MyFirstForm
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
			this.UserInputText = new System.Windows.Forms.TextBox();
			this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
			this.BackButton = new System.Windows.Forms.Button();
			this.PercentButton = new System.Windows.Forms.Button();
			this.CEButton = new System.Windows.Forms.Button();
			this.CButton = new System.Windows.Forms.Button();
			this.DivideButton = new System.Windows.Forms.Button();
			this.Number1 = new System.Windows.Forms.Button();
			this.Number2 = new System.Windows.Forms.Button();
			this.Number3 = new System.Windows.Forms.Button();
			this.MultiplyButton = new System.Windows.Forms.Button();
			this.Number4 = new System.Windows.Forms.Button();
			this.Number5 = new System.Windows.Forms.Button();
			this.Number6 = new System.Windows.Forms.Button();
			this.MinusButton = new System.Windows.Forms.Button();
			this.Number7 = new System.Windows.Forms.Button();
			this.Number8 = new System.Windows.Forms.Button();
			this.Number9 = new System.Windows.Forms.Button();
			this.PlusButton = new System.Windows.Forms.Button();
			this.Number0 = new System.Windows.Forms.Button();
			this.PointButton = new System.Windows.Forms.Button();
			this.EqualsButton = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Mclear = new System.Windows.Forms.Button();
			this.Mrecall = new System.Windows.Forms.Button();
			this.Mplus = new System.Windows.Forms.Button();
			this.Mminus = new System.Windows.Forms.Button();
			this.operation = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.NegativeButton = new System.Windows.Forms.Button();
			this.ButtonPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UserInputText
			// 
			this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserInputText.BackColor = System.Drawing.SystemColors.Control;
			this.UserInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.UserInputText.Location = new System.Drawing.Point(12, 37);
			this.UserInputText.Name = "UserInputText";
			this.UserInputText.Size = new System.Drawing.Size(302, 38);
			this.UserInputText.TabIndex = 0;
			this.UserInputText.TabStop = false;
			this.UserInputText.Text = "0";
			this.UserInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonPanel.ColumnCount = 4;
			this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.ButtonPanel.Controls.Add(this.BackButton, 0, 4);
			this.ButtonPanel.Controls.Add(this.PercentButton, 0, 0);
			this.ButtonPanel.Controls.Add(this.CEButton, 1, 0);
			this.ButtonPanel.Controls.Add(this.CButton, 2, 0);
			this.ButtonPanel.Controls.Add(this.DivideButton, 3, 0);
			this.ButtonPanel.Controls.Add(this.Number1, 0, 1);
			this.ButtonPanel.Controls.Add(this.Number2, 1, 1);
			this.ButtonPanel.Controls.Add(this.Number3, 2, 1);
			this.ButtonPanel.Controls.Add(this.MultiplyButton, 3, 1);
			this.ButtonPanel.Controls.Add(this.Number4, 0, 2);
			this.ButtonPanel.Controls.Add(this.Number5, 1, 2);
			this.ButtonPanel.Controls.Add(this.Number6, 2, 2);
			this.ButtonPanel.Controls.Add(this.MinusButton, 3, 2);
			this.ButtonPanel.Controls.Add(this.Number7, 0, 3);
			this.ButtonPanel.Controls.Add(this.Number8, 1, 3);
			this.ButtonPanel.Controls.Add(this.Number9, 2, 3);
			this.ButtonPanel.Controls.Add(this.PlusButton, 3, 3);
			this.ButtonPanel.Controls.Add(this.Number0, 1, 4);
			this.ButtonPanel.Controls.Add(this.PointButton, 2, 4);
			this.ButtonPanel.Controls.Add(this.EqualsButton, 3, 4);
			this.ButtonPanel.Location = new System.Drawing.Point(12, 132);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.RowCount = 5;
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.ButtonPanel.Size = new System.Drawing.Size(302, 337);
			this.ButtonPanel.TabIndex = 2;
			// 
			// BackButton
			// 
			this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BackButton.Location = new System.Drawing.Point(3, 271);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(69, 63);
			this.BackButton.TabIndex = 19;
			this.BackButton.TabStop = false;
			this.BackButton.Text = "⌫";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// PercentButton
			// 
			this.PercentButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PercentButton.Location = new System.Drawing.Point(3, 3);
			this.PercentButton.Name = "PercentButton";
			this.PercentButton.Size = new System.Drawing.Size(69, 61);
			this.PercentButton.TabIndex = 0;
			this.PercentButton.TabStop = false;
			this.PercentButton.Text = "%";
			this.PercentButton.UseVisualStyleBackColor = true;
			this.PercentButton.Click += new System.EventHandler(this.PercentButton_Click);
			// 
			// CEButton
			// 
			this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CEButton.Location = new System.Drawing.Point(78, 3);
			this.CEButton.Name = "CEButton";
			this.CEButton.Size = new System.Drawing.Size(69, 61);
			this.CEButton.TabIndex = 1;
			this.CEButton.TabStop = false;
			this.CEButton.Text = "CE";
			this.CEButton.UseVisualStyleBackColor = true;
			this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
			// 
			// CButton
			// 
			this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CButton.Location = new System.Drawing.Point(153, 3);
			this.CButton.Name = "CButton";
			this.CButton.Size = new System.Drawing.Size(69, 61);
			this.CButton.TabIndex = 2;
			this.CButton.TabStop = false;
			this.CButton.Text = "C";
			this.CButton.UseVisualStyleBackColor = true;
			this.CButton.Click += new System.EventHandler(this.CButton_Click);
			// 
			// DivideButton
			// 
			this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DivideButton.Location = new System.Drawing.Point(228, 3);
			this.DivideButton.Name = "DivideButton";
			this.DivideButton.Size = new System.Drawing.Size(71, 61);
			this.DivideButton.TabIndex = 3;
			this.DivideButton.TabStop = false;
			this.DivideButton.Tag = "D";
			this.DivideButton.Text = "÷";
			this.DivideButton.UseVisualStyleBackColor = true;
			this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
			// 
			// Number1
			// 
			this.Number1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number1.Location = new System.Drawing.Point(3, 70);
			this.Number1.Name = "Number1";
			this.Number1.Size = new System.Drawing.Size(69, 61);
			this.Number1.TabIndex = 4;
			this.Number1.TabStop = false;
			this.Number1.Tag = "1";
			this.Number1.Text = "1";
			this.Number1.UseVisualStyleBackColor = true;
			this.Number1.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number2
			// 
			this.Number2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number2.Location = new System.Drawing.Point(78, 70);
			this.Number2.Name = "Number2";
			this.Number2.Size = new System.Drawing.Size(69, 61);
			this.Number2.TabIndex = 5;
			this.Number2.TabStop = false;
			this.Number2.Tag = "2";
			this.Number2.Text = "2";
			this.Number2.UseVisualStyleBackColor = true;
			this.Number2.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number3
			// 
			this.Number3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number3.Location = new System.Drawing.Point(153, 70);
			this.Number3.Name = "Number3";
			this.Number3.Size = new System.Drawing.Size(69, 61);
			this.Number3.TabIndex = 6;
			this.Number3.TabStop = false;
			this.Number3.Tag = "3";
			this.Number3.Text = "3";
			this.Number3.UseVisualStyleBackColor = true;
			this.Number3.Click += new System.EventHandler(this.Number_Click);
			// 
			// MultiplyButton
			// 
			this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MultiplyButton.Location = new System.Drawing.Point(228, 70);
			this.MultiplyButton.Name = "MultiplyButton";
			this.MultiplyButton.Size = new System.Drawing.Size(71, 61);
			this.MultiplyButton.TabIndex = 7;
			this.MultiplyButton.TabStop = false;
			this.MultiplyButton.Text = "x";
			this.MultiplyButton.UseVisualStyleBackColor = true;
			this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
			// 
			// Number4
			// 
			this.Number4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number4.Location = new System.Drawing.Point(3, 137);
			this.Number4.Name = "Number4";
			this.Number4.Size = new System.Drawing.Size(69, 61);
			this.Number4.TabIndex = 8;
			this.Number4.TabStop = false;
			this.Number4.Tag = "4";
			this.Number4.Text = "4";
			this.Number4.UseVisualStyleBackColor = true;
			this.Number4.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number5
			// 
			this.Number5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number5.Location = new System.Drawing.Point(78, 137);
			this.Number5.Name = "Number5";
			this.Number5.Size = new System.Drawing.Size(69, 61);
			this.Number5.TabIndex = 9;
			this.Number5.TabStop = false;
			this.Number5.Tag = "5";
			this.Number5.Text = "5";
			this.Number5.UseVisualStyleBackColor = true;
			this.Number5.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number6
			// 
			this.Number6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number6.Location = new System.Drawing.Point(153, 137);
			this.Number6.Name = "Number6";
			this.Number6.Size = new System.Drawing.Size(69, 61);
			this.Number6.TabIndex = 10;
			this.Number6.TabStop = false;
			this.Number6.Tag = "6";
			this.Number6.Text = "6";
			this.Number6.UseVisualStyleBackColor = true;
			this.Number6.Click += new System.EventHandler(this.Number_Click);
			// 
			// MinusButton
			// 
			this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MinusButton.Location = new System.Drawing.Point(228, 137);
			this.MinusButton.Name = "MinusButton";
			this.MinusButton.Size = new System.Drawing.Size(71, 61);
			this.MinusButton.TabIndex = 11;
			this.MinusButton.TabStop = false;
			this.MinusButton.Text = "-";
			this.MinusButton.UseVisualStyleBackColor = true;
			this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
			// 
			// Number7
			// 
			this.Number7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number7.Location = new System.Drawing.Point(3, 204);
			this.Number7.Name = "Number7";
			this.Number7.Size = new System.Drawing.Size(69, 61);
			this.Number7.TabIndex = 12;
			this.Number7.TabStop = false;
			this.Number7.Tag = "7";
			this.Number7.Text = "7";
			this.Number7.UseVisualStyleBackColor = true;
			this.Number7.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number8
			// 
			this.Number8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number8.Location = new System.Drawing.Point(78, 204);
			this.Number8.Name = "Number8";
			this.Number8.Size = new System.Drawing.Size(69, 61);
			this.Number8.TabIndex = 13;
			this.Number8.TabStop = false;
			this.Number8.Tag = "8";
			this.Number8.Text = "8";
			this.Number8.UseVisualStyleBackColor = true;
			this.Number8.Click += new System.EventHandler(this.Number_Click);
			// 
			// Number9
			// 
			this.Number9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number9.Location = new System.Drawing.Point(153, 204);
			this.Number9.Name = "Number9";
			this.Number9.Size = new System.Drawing.Size(69, 61);
			this.Number9.TabIndex = 14;
			this.Number9.TabStop = false;
			this.Number9.Tag = "9";
			this.Number9.Text = "9";
			this.Number9.UseVisualStyleBackColor = true;
			this.Number9.Click += new System.EventHandler(this.Number_Click);
			// 
			// PlusButton
			// 
			this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PlusButton.Location = new System.Drawing.Point(228, 204);
			this.PlusButton.Name = "PlusButton";
			this.PlusButton.Size = new System.Drawing.Size(71, 61);
			this.PlusButton.TabIndex = 15;
			this.PlusButton.TabStop = false;
			this.PlusButton.Tag = "p";
			this.PlusButton.Text = "+";
			this.PlusButton.UseVisualStyleBackColor = true;
			this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
			// 
			// Number0
			// 
			this.Number0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Number0.Location = new System.Drawing.Point(78, 271);
			this.Number0.Name = "Number0";
			this.Number0.Size = new System.Drawing.Size(69, 63);
			this.Number0.TabIndex = 16;
			this.Number0.TabStop = false;
			this.Number0.Tag = "0";
			this.Number0.Text = "0";
			this.Number0.UseVisualStyleBackColor = true;
			this.Number0.Click += new System.EventHandler(this.Number_Click);
			// 
			// PointButton
			// 
			this.PointButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PointButton.Location = new System.Drawing.Point(153, 271);
			this.PointButton.Name = "PointButton";
			this.PointButton.Size = new System.Drawing.Size(69, 63);
			this.PointButton.TabIndex = 17;
			this.PointButton.TabStop = false;
			this.PointButton.Text = ".";
			this.PointButton.UseVisualStyleBackColor = true;
			this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
			// 
			// EqualsButton
			// 
			this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EqualsButton.Location = new System.Drawing.Point(228, 271);
			this.EqualsButton.Name = "EqualsButton";
			this.EqualsButton.Size = new System.Drawing.Size(71, 63);
			this.EqualsButton.TabIndex = 18;
			this.EqualsButton.TabStop = false;
			this.EqualsButton.Text = "=";
			this.EqualsButton.UseVisualStyleBackColor = true;
			this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Mclear
			// 
			this.Mclear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Mclear.Location = new System.Drawing.Point(3, 3);
			this.Mclear.Name = "Mclear";
			this.Mclear.Size = new System.Drawing.Size(54, 38);
			this.Mclear.TabIndex = 3;
			this.Mclear.TabStop = false;
			this.Mclear.Text = "MC";
			this.Mclear.UseVisualStyleBackColor = true;
			this.Mclear.Click += new System.EventHandler(this.Mclear_Click);
			// 
			// Mrecall
			// 
			this.Mrecall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Mrecall.Location = new System.Drawing.Point(63, 3);
			this.Mrecall.Name = "Mrecall";
			this.Mrecall.Size = new System.Drawing.Size(54, 38);
			this.Mrecall.TabIndex = 4;
			this.Mrecall.TabStop = false;
			this.Mrecall.Text = "MR";
			this.Mrecall.UseVisualStyleBackColor = true;
			this.Mrecall.Click += new System.EventHandler(this.Mrecall_Click);
			// 
			// Mplus
			// 
			this.Mplus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Mplus.Location = new System.Drawing.Point(123, 3);
			this.Mplus.Name = "Mplus";
			this.Mplus.Size = new System.Drawing.Size(54, 38);
			this.Mplus.TabIndex = 5;
			this.Mplus.TabStop = false;
			this.Mplus.Text = "M+";
			this.Mplus.UseVisualStyleBackColor = true;
			this.Mplus.Click += new System.EventHandler(this.Mplus_Click);
			// 
			// Mminus
			// 
			this.Mminus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Mminus.Location = new System.Drawing.Point(183, 3);
			this.Mminus.Name = "Mminus";
			this.Mminus.Size = new System.Drawing.Size(54, 38);
			this.Mminus.TabIndex = 6;
			this.Mminus.TabStop = false;
			this.Mminus.Text = "M-";
			this.Mminus.UseVisualStyleBackColor = true;
			this.Mminus.Click += new System.EventHandler(this.Mminus_Click);
			// 
			// operation
			// 
			this.operation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.operation.AutoSize = true;
			this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.operation.Location = new System.Drawing.Point(14, 9);
			this.operation.MinimumSize = new System.Drawing.Size(300, 0);
			this.operation.Name = "operation";
			this.operation.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.operation.Size = new System.Drawing.Size(300, 20);
			this.operation.TabIndex = 7;
			this.operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Mclear, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Mrecall, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Mplus, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.Mminus, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.NegativeButton, 4, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 44);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// NegativeButton
			// 
			this.NegativeButton.Location = new System.Drawing.Point(243, 3);
			this.NegativeButton.Name = "NegativeButton";
			this.NegativeButton.Size = new System.Drawing.Size(56, 38);
			this.NegativeButton.TabIndex = 7;
			this.NegativeButton.TabStop = false;
			this.NegativeButton.Text = "-/+";
			this.NegativeButton.UseVisualStyleBackColor = true;
			this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
			// 
			// MyFirstForm
			// 
			this.AcceptButton = this.EqualsButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CEButton;
			this.ClientSize = new System.Drawing.Size(326, 481);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.operation);
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.UserInputText);
			this.MinimumSize = new System.Drawing.Size(305, 300);
			this.Name = "MyFirstForm";
			this.Text = "Basic Calculator";
			this.ButtonPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button PercentButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button Mclear;
		private System.Windows.Forms.Button Mrecall;
		private System.Windows.Forms.Button Mplus;
		private System.Windows.Forms.Button Mminus;
		private System.Windows.Forms.Label operation;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button NegativeButton;
	}
}


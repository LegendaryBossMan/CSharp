namespace NBishop_Assignment_BasicGUI
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.FirstNum = new System.Windows.Forms.TextBox();
			this.SecondNum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AddBtn = new System.Windows.Forms.Button();
			this.SubBtn = new System.Windows.Forms.Button();
			this.MultBtn = new System.Windows.Forms.Button();
			this.DivBtn = new System.Windows.Forms.Button();
			this.ResultLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Number:";
			// 
			// FirstNum
			// 
			this.FirstNum.Location = new System.Drawing.Point(139, 22);
			this.FirstNum.Name = "FirstNum";
			this.FirstNum.Size = new System.Drawing.Size(100, 20);
			this.FirstNum.TabIndex = 1;
			// 
			// SecondNum
			// 
			this.SecondNum.Location = new System.Drawing.Point(139, 55);
			this.SecondNum.Name = "SecondNum";
			this.SecondNum.Size = new System.Drawing.Size(100, 20);
			this.SecondNum.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Second Number:";
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(106, 114);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 4;
			this.AddBtn.Text = "+";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// SubBtn
			// 
			this.SubBtn.Location = new System.Drawing.Point(177, 140);
			this.SubBtn.Name = "SubBtn";
			this.SubBtn.Size = new System.Drawing.Size(75, 23);
			this.SubBtn.TabIndex = 5;
			this.SubBtn.Text = "-";
			this.SubBtn.UseVisualStyleBackColor = true;
			this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
			// 
			// MultBtn
			// 
			this.MultBtn.Location = new System.Drawing.Point(106, 169);
			this.MultBtn.Name = "MultBtn";
			this.MultBtn.Size = new System.Drawing.Size(75, 23);
			this.MultBtn.TabIndex = 6;
			this.MultBtn.Text = "X";
			this.MultBtn.UseVisualStyleBackColor = true;
			this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
			// 
			// DivBtn
			// 
			this.DivBtn.Location = new System.Drawing.Point(27, 140);
			this.DivBtn.Name = "DivBtn";
			this.DivBtn.Size = new System.Drawing.Size(75, 23);
			this.DivBtn.TabIndex = 7;
			this.DivBtn.Text = "/";
			this.DivBtn.UseVisualStyleBackColor = true;
			this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
			// 
			// ResultLbl
			// 
			this.ResultLbl.AutoSize = true;
			this.ResultLbl.Location = new System.Drawing.Point(174, 87);
			this.ResultLbl.Name = "ResultLbl";
			this.ResultLbl.Size = new System.Drawing.Size(0, 13);
			this.ResultLbl.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 227);
			this.Controls.Add(this.ResultLbl);
			this.Controls.Add(this.DivBtn);
			this.Controls.Add(this.MultBtn);
			this.Controls.Add(this.SubBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SecondNum);
			this.Controls.Add(this.FirstNum);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FirstNum;
		private System.Windows.Forms.TextBox SecondNum;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button SubBtn;
		private System.Windows.Forms.Button MultBtn;
		private System.Windows.Forms.Button DivBtn;
		private System.Windows.Forms.Label ResultLbl;
	}
}


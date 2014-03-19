namespace Engine_test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblSticks = new System.Windows.Forms.Label();
			this.txtPlayer1Name = new System.Windows.Forms.TextBox();
			this.txtPlayer2Name = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtTakeSticks = new System.Windows.Forms.TextBox();
			this.btnTake = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSticks
			// 
			this.lblSticks.Location = new System.Drawing.Point(214, 56);
			this.lblSticks.Name = "lblSticks";
			this.lblSticks.Size = new System.Drawing.Size(100, 23);
			this.lblSticks.TabIndex = 0;
			this.lblSticks.Text = "label1";
			// 
			// txtPlayer1Name
			// 
			this.txtPlayer1Name.Location = new System.Drawing.Point(13, 13);
			this.txtPlayer1Name.Name = "txtPlayer1Name";
			this.txtPlayer1Name.Size = new System.Drawing.Size(100, 20);
			this.txtPlayer1Name.TabIndex = 1;
			// 
			// txtPlayer2Name
			// 
			this.txtPlayer2Name.Location = new System.Drawing.Point(378, 13);
			this.txtPlayer2Name.Name = "txtPlayer2Name";
			this.txtPlayer2Name.Size = new System.Drawing.Size(100, 20);
			this.txtPlayer2Name.TabIndex = 2;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(214, 30);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// txtTakeSticks
			// 
			this.txtTakeSticks.Location = new System.Drawing.Point(189, 109);
			this.txtTakeSticks.Name = "txtTakeSticks";
			this.txtTakeSticks.Size = new System.Drawing.Size(100, 20);
			this.txtTakeSticks.TabIndex = 4;
			// 
			// btnTake
			// 
			this.btnTake.Location = new System.Drawing.Point(295, 107);
			this.btnTake.Name = "btnTake";
			this.btnTake.Size = new System.Drawing.Size(75, 23);
			this.btnTake.TabIndex = 5;
			this.btnTake.Text = "take";
			this.btnTake.UseVisualStyleBackColor = true;
			this.btnTake.Click += new System.EventHandler(this.BtnTakeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 196);
			this.Controls.Add(this.btnTake);
			this.Controls.Add(this.txtTakeSticks);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtPlayer2Name);
			this.Controls.Add(this.txtPlayer1Name);
			this.Controls.Add(this.lblSticks);
			this.Name = "MainForm";
			this.Text = "Engine_test";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnTake;
		private System.Windows.Forms.TextBox txtTakeSticks;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtPlayer2Name;
		private System.Windows.Forms.TextBox txtPlayer1Name;
		private System.Windows.Forms.Label lblSticks;
	}
}

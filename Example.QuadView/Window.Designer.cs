namespace Example.QuadView
{
	partial class Window
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
			this.quadPanel = new System.Windows.Forms.TableLayoutPanel();
			this.singlePanel = new System.Windows.Forms.Panel();
			this.viewer1 = new Example.QuadView.Viewer(23);
			this.viewer2 = new Example.QuadView.Viewer(24);
			this.viewer3 = new Example.QuadView.Viewer(25);
			this.viewer4 = new Example.QuadView.Viewer(26);
			this.quadPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// quadPanel
			// 
			this.quadPanel.ColumnCount = 2;
			this.quadPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.quadPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.quadPanel.Controls.Add(this.viewer1, 0, 0);
			this.quadPanel.Controls.Add(this.viewer2, 1, 0);
			this.quadPanel.Controls.Add(this.viewer3, 0, 1);
			this.quadPanel.Controls.Add(this.viewer4, 1, 1);
			this.quadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quadPanel.Location = new System.Drawing.Point(0, 0);
			this.quadPanel.Name = "quadPanel";
			this.quadPanel.RowCount = 2;
			this.quadPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.quadPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.quadPanel.Size = new System.Drawing.Size(784, 562);
			this.quadPanel.TabIndex = 0;
			// 
			// singlePanel
			// 
			this.singlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.singlePanel.Location = new System.Drawing.Point(0, 0);
			this.singlePanel.Name = "singlePanel";
			this.singlePanel.Size = new System.Drawing.Size(784, 562);
			this.singlePanel.TabIndex = 1;
			this.singlePanel.Visible = false;
			// 
			// viewer1
			// 
			this.viewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewer1.Location = new System.Drawing.Point(3, 3);
			this.viewer1.Name = "viewer1";
			this.viewer1.Size = new System.Drawing.Size(386, 275);
			this.viewer1.TabIndex = 0;
			// 
			// viewer2
			// 
			this.viewer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewer2.Location = new System.Drawing.Point(395, 3);
			this.viewer2.Name = "viewer2";
			this.viewer2.Size = new System.Drawing.Size(386, 275);
			this.viewer2.TabIndex = 1;
			// 
			// viewer3
			// 
			this.viewer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewer3.Location = new System.Drawing.Point(3, 284);
			this.viewer3.Name = "viewer3";
			this.viewer3.Size = new System.Drawing.Size(386, 275);
			this.viewer3.TabIndex = 2;
			// 
			// viewer4
			// 
			this.viewer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewer4.Location = new System.Drawing.Point(395, 284);
			this.viewer4.Name = "viewer4";
			this.viewer4.Size = new System.Drawing.Size(386, 275);
			this.viewer4.TabIndex = 3;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.singlePanel);
			this.Controls.Add(this.quadPanel);
			this.Name = "Window";
			this.Text = "Vidview Example Quad View";
			this.quadPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel quadPanel;
		private Viewer viewer1;
		private Viewer viewer2;
		private Viewer viewer3;
		private Viewer viewer4;
		private System.Windows.Forms.Panel singlePanel;

	}
}


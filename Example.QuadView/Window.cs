using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.QuadView
{
	public partial class Window : Form
	{
		public Window()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			this.viewer1.PositionChanged += position =>
			{
				if (InvokeRequired)
				{
					this.BeginInvoke((Action)(() => 
					{
						if (quadPanel.Visible)
						{
							quadPanel.Hide();
							singlePanel.Controls.Add(viewer1);
							singlePanel.Show();
						}
						else
						{
							singlePanel.Hide();
							quadPanel.Controls.Add(viewer1, 0, 0);
							quadPanel.Show();
						}
					}));
				}
			};
			this.viewer2.PositionChanged += position =>
			{
				if (InvokeRequired)
				{
					this.BeginInvoke((Action)(() =>
					{
						if (quadPanel.Visible)
						{
							quadPanel.Hide();
							singlePanel.Controls.Add(viewer2);
							singlePanel.Show();
						}
						else
						{
							singlePanel.Hide();
							quadPanel.Controls.Add(viewer2, 1, 0);
							quadPanel.Show();
						}
					}));
				}
			};
			this.viewer3.PositionChanged += position =>
			{
				if (InvokeRequired)
				{
					this.BeginInvoke((Action)(() =>
					{
						if (quadPanel.Visible)
						{
							quadPanel.Hide();
							singlePanel.Controls.Add(viewer3);
							singlePanel.Show();
						}
						else
						{
							singlePanel.Hide();
							quadPanel.Controls.Add(viewer3, 0, 1);
							quadPanel.Show();
						}
					}));
				}
			};
			this.viewer4.PositionChanged += position =>
			{
				if (InvokeRequired)
				{
					this.BeginInvoke((Action)(() =>
					{
						if (quadPanel.Visible)
						{
							quadPanel.Hide();
							singlePanel.Controls.Add(viewer4);
							singlePanel.Show();
						}
						else
						{
							singlePanel.Hide();
							quadPanel.Controls.Add(viewer4, 1, 1);
							quadPanel.Show();
						}
					}));
				}
			};
		}
	}
}

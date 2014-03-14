using System;
using Forms = System.Windows.Forms;
using Settings = Kean.Platform.Settings;
using Kean.Extension;

namespace Example.QuadView
{
	public class Viewer : 
		Forms.UserControl
	{
		Imint.Vidview.Viewer vidview;
		int port;

		public Viewer(int port = 23)
		{
			this.port = port;
			this.InitializeComponent();
			this.Load += (Object sender, EventArgs e) => Viewer_Load(sender, e);
		}

		void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Viewer
			// 
			this.Name = "Viewer";
			this.Dock = Forms.DockStyle.Fill;
			this.Size = new System.Drawing.Size(800, 600);
			this.ResumeLayout(false);
		}

		protected virtual void Viewer_Load(Object sender, EventArgs e)
		{
			if (!DesignMode)
			{
				this.vidview = new Imint.Vidview.Viewer();
				this.SuspendLayout();
				// 
				// viewer
				// 
				this.vidview.Asynchronous = Settings.Asynchronous.SetNotify;
				this.vidview.Arguments = "-d -r telnet://:" + this.port;
				this.vidview.Dock = System.Windows.Forms.DockStyle.Fill;
				this.vidview.Location = new System.Drawing.Point(0, 0);
				this.vidview.Name = "viewer";
				// Running as a separate process requires the NuGet package "Imint.Vidview.Window". 
				this.vidview.SeparateProcess = true;
				this.vidview.OnDebug += (direction, message) => Console.WriteLine((direction ? "> " : "< ") + message);
				this.vidview.Size = new System.Drawing.Size(800, 600);
				this.vidview.TabIndex = 0;
				this.vidview.Closed += System.Windows.Forms.Application.Exit;
				// When the Vidview viewer is fully initialized open test://photo. In case of errors shut down the viewer and the application.
				this.vidview.Started += () =>
				{
					if (!(this.vidview.Media != null && this.vidview.Media.Open("test://photo")))
					{
						this.vidview.Close();
					}
					(this.vidview.Viewer.Overlays["clickOverlay"] as IClickOverlay).PositionChanged += position =>
					{
						if (position.NotNull())
							this.PositionChanged.Call(position);
					};
					this.ClientSizeChanged += (se, ev) =>
					{
						this.vidview.Viewer.Fit();
						this.vidview.Viewer.Translation = new Kean.Math.Geometry2D.Single.Size();
					};
				};
				this.Controls.Add(this.vidview);
				this.ResumeLayout(false);
			}
		}

		public event Action<Kean.Math.Geometry2D.Single.Point> PositionChanged;

	}
}

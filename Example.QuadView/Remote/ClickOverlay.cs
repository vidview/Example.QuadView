using System;
using Geometry2D = Kean.Math.Geometry2D;
using Draw = Kean.Draw;
using Kean;
using Kean.Extension;
using Serializing = Attraction.Core.Serializing;
using Svg = Attraction.Svg;
using Platform = Kean.Platform;

namespace Example.QuadView.Remote
{
	public class ClickOverlay :
		Imint.Viewer.Remote.Overlay,
		IClickOverlay
	{
		public Geometry2D.Single.Point Position
		{
			get { return this.Backend.Get<Geometry2D.Single.Point>(this.Path + "position"); }
			set { this.Backend.Set<Geometry2D.Single.Point>(this.Path + "position", value); }
		}
		Action<Geometry2D.Single.Point> positionChanged;
		public event Action<Geometry2D.Single.Point> PositionChanged
		{
			add
			{
				if (this.positionChanged.IsNull())
					this.Backend.Listen(this.Path + "position", (Geometry2D.Single.Point v) => this.positionChanged.Call(v));
				this.positionChanged += value;
			}
			remove { this.positionChanged -= value; }
		}
	}
}

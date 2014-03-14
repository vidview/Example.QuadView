using System;
using Geometry2D = Kean.Math.Geometry2D;
using Draw = Kean.Draw;
using Kean;
using Kean.Extension;
using Serializing = Attraction.Core.Serializing;
using Svg = Attraction.Svg;
using Platform = Kean.Platform;

namespace Example.QuadView
{
	public interface IClickOverlay :
		Imint.Viewer.IOverlay
	{
		Geometry2D.Single.Point Position { get; }
		event Action<Geometry2D.Single.Point> PositionChanged;
	}
}

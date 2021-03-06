﻿using System;
using Geometry2D = Kean.Math.Geometry2D;
using Draw = Kean.Draw;
using Kean;
using Kean.Extension;
using Serializing = Attraction.Core.Serializing;
using Svg = Attraction.Svg;
using Platform = Kean.Platform;

namespace Example.QuadView
{
	public class ClickOverlay : 
		Imint.Viewer.Overlay,
		IClickOverlay
	{
		public override string Type { get { return "Example.QuadView:IClickOverlay"; } }
		public override string Remote { get { return "Example.QuadView:Remote.ClickOverlay"; } }
		Geometry2D.Single.Point position;
		[Notify("PositionChanged")]
		[Platform.Settings.Property("position")]
		public Geometry2D.Single.Point Position 
		{
			get { return this.position; }
			private set { this.PositionChanged.Call(this.position = value); }
		}
		public event Action<Geometry2D.Single.Point> PositionChanged;

		protected override bool PointerLeftClick(Geometry2D.Single.Point position)
		{
			this.Position = position;
			return true;
		}

		protected override Imint.Viewer.Cache[] UpdateCaches(Imint.Viewer.Cache[] caches, Kean.Collection.IReadOnlyDictionary<string, object> meta)
		{
			return caches;
		}
	}
}

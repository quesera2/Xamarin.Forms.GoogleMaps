﻿using System;
using Android.Gms.Maps.Model;

namespace Xamarin.Forms.GoogleMaps.Logics.Android
{
	internal class NativeUrlTileLayer : UrlTileProvider
	{
		private readonly Func<int, int, int, Uri> _makeTileUri;

		public NativeUrlTileLayer(Func<int, int, int, Uri> makeTileUri, int tileSize = 256) : base(tileSize, tileSize)
		{
			_makeTileUri = makeTileUri;
		}

		public override Java.Net.URL GetTileUrl(int x, int y, int zoom)
		{
			var uri = _makeTileUri(x,y,zoom);
			return new Java.Net.URL(uri.AbsoluteUri);
		}
	}
}


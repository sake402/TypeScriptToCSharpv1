
using System;
using TSCS;

//using number = System.Double;
//using any = Bridge.Union<System.Delegate, object>;
//using boolean = System.Boolean;
#pragma warning disable CS0626
#pragma warning disable CS0824
#pragma warning disable CS0108
#pragma warning disable IDE1006
//[assembly: Convention(Notation.LowerCamelCase)]

namespace TSCS
{
	public partial class geojson
	{
		public partial interface GeoJsonObject
		{
			string type { get; set; }
			double[] bbox { get; set; }
			CoordinateReferenceSystem crs { get; set; }
		}
		public partial interface Position
		{
			double this[double index] { get; set; }
		}
		public partial interface GeometryObject : GeoJsonObject
		{
			object coordinates { get; set; }
		}
		public partial interface Point : GeometryObject
		{
			Position coordinates { get; set; }
		}
		public partial interface MultiPoint : GeometryObject
		{
			Position[] coordinates { get; set; }
		}
		public partial interface LineString : GeometryObject
		{
			Position[] coordinates { get; set; }
		}
		public partial interface MultiLineString : GeometryObject
		{
			Position[][] coordinates { get; set; }
		}
		public partial interface Polygon : GeometryObject
		{
			Position[][] coordinates { get; set; }
		}
		public partial interface MultiPolygon : GeometryObject
		{
			Position[][][] coordinates { get; set; }
		}
		public partial interface GeometryCollection : GeoJsonObject
		{
			GeometryObject[] geometries { get; set; }
		}
		public partial interface Feature : GeoJsonObject
		{
			GeometryObject geometry { get; set; }
			object properties { get; set; }
			string id { get; set; }
		}
		public partial interface Feature<A,B> : Feature
		{
		}
		public partial interface FeatureCollection : GeoJsonObject
		{
			Feature[] features { get; set; }
		}
		public partial interface FeatureCollection<A,B> : FeatureCollection
		{
		}
		public partial interface CoordinateReferenceSystem
		{
			string type { get; set; }
			object properties { get; set; }
		}
		public partial interface NamedCoordinateReferenceSystem : CoordinateReferenceSystem
		{
			Anonymous_46104728 properties { get; set; }
		}
		public partial interface Anonymous_46104728
		{
			string name { get; set; }
		}
		public partial interface LinkedCoordinateReferenceSystem : CoordinateReferenceSystem
		{
			Anonymous_12289376 properties { get; set; }
		}
		public partial interface Anonymous_12289376
		{
			string href { get; set; }
			string type { get; set; }
		}
	}
}

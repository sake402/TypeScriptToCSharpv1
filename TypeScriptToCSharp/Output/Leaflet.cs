
using System;
using TSCS;
using Date = System.DateTime;

#pragma warning disable CS0626
#pragma warning disable CS0824
#pragma warning disable CS0108
#pragma warning disable IDE1006

public class Leaflet
{
	public partial class Class
	{
		public partial interface ClassType_0
		{
			object @new(object[] args);
		}
		public virtual Union<ClassType_0, Class> extend(object props) => default(Union<ClassType_0, Class>);
		public virtual Union<object, Class> include(object props) => default(Union<object, Class>);
		public virtual Union<object, Class> mergeOptions(object props) => default(Union<object, Class>);
		public virtual Union<object, Class> addInitHook(Action initHookFn) => default(Union<object, Class>);
		public virtual Union<object, Class> addInitHook(string methodName, object[] args) => default(Union<object, Class>);
		public Class() { }
	}
	public partial class Transformation
	{
		public Transformation(double a, double b, double c, double d) { }
		public virtual Point transform(Point point, double scale) => default(Point);
		public virtual Point untransform(Point point, double scale) => default(Point);
		public Transformation() { }
	}
	public partial class LineUtil
	{
		public virtual Point[] simplify(Point[] points, double tolerance) => default(Point[]);
		public virtual double pointToSegmentDistance(Point p, Point p1, Point p2) => default(double);
		public virtual Point closestPointOnSegment(Point p, Point p1, Point p2) => default(Point);
		public virtual bool isFlat(LatLngExpression[] latlngs) => default(bool);
		public LineUtil() { }
	}
	public partial class PolyUtil
	{
		public virtual Point[] clipPolygon(Point[] points, BoundsExpression bounds, bool round) => default(Point[]);
		public PolyUtil() { }
	}
	public partial class DomUtil
	{
		public virtual string TRANSFORM { get; set; }
		public virtual string TRANSITION { get; set; }
		public virtual string TRANSITION_END { get; set; }
		public virtual Union<HTMLElement, object> get(Union<string, HTMLElement> element) => default(Union<HTMLElement, object>);
		public virtual Union<string, object> getStyle(HTMLElement el, string styleAttrib) => default(Union<string, object>);
		public virtual HTMLElement create(string tagName, string className, HTMLElement container) => default(HTMLElement);
		public virtual void remove(HTMLElement el) { }
		public virtual void empty(HTMLElement el) { }
		public virtual void toFront(HTMLElement el) { }
		public virtual void toBack(HTMLElement el) { }
		public virtual bool hasClass(HTMLElement el, string name) => default(bool);
		public virtual void addClass(HTMLElement el, string name) { }
		public virtual void removeClass(HTMLElement el, string name) { }
		public virtual void setClass(HTMLElement el, string name) { }
		public virtual string getClass(HTMLElement el) => default(string);
		public virtual void setOpacity(HTMLElement el, double opacity) { }
		public virtual Union<string, bool> testProp(string[] props) => default(Union<string, bool>);
		public virtual void setTransform(HTMLElement el, Point offset, double scale) { }
		public virtual void setPosition(HTMLElement el, Point position) { }
		public virtual Point getPosition(HTMLElement el) => default(Point);
		public virtual void disableTextSelection() { }
		public virtual void enableTextSelection() { }
		public virtual void disableImageDrag() { }
		public virtual void enableImageDrag() { }
		public virtual void preventOutline(HTMLElement el) { }
		public virtual void restoreOutline() { }
		public DomUtil() { }
	}
	public partial interface CRS
	{
		string code { get; set; }
		object[] wrapLng { get; set; }
		object[] wrapLat { get; set; }
		bool infinite { get; set; }
		Point latLngToPoint(LatLngExpression latlng, double zoom);
		LatLng pointToLatLng(PointExpression point, double zoom);
		Point project(Union<LatLng, LatLngLiteral> latlng);
		LatLng unproject(PointExpression point);
		double scale(double zoom);
		double zoom(double scale);
		Bounds getProjectedBounds(double zoom);
		double distance(LatLngExpression latlng1, LatLngExpression latlng2);
		LatLng wrapLatLng(Union<LatLng, LatLngLiteral> latlng);
	}
	public partial class CCRS
	{
		public virtual CRS EPSG3395 { get; set; }
		public virtual CRS EPSG3857 { get; set; }
		public virtual CRS EPSG4326 { get; set; }
		public virtual CRS Earth { get; set; }
		public virtual CRS Simple { get; set; }
		public CCRS() { }
	}
	public partial interface Projection
	{
		Bounds bounds { get; set; }
		Point project(Union<LatLng, LatLngLiteral> latlng);
		LatLng unproject(PointExpression point);
	}
	public partial class CProjection
	{
		public virtual Projection LonLat { get; set; }
		public virtual Projection Mercator { get; set; }
		public virtual Projection SphericalMercator { get; set; }
		public CProjection() { }
	}
	public partial class LatLng
	{
		public virtual double lat { get; set; }
		public virtual double lng { get; set; }
		public virtual double alt { get; set; }
		public LatLng(double latitude, double longitude, double altitude) { }
		public virtual bool equals(LatLngExpression otherLatLng, double maxMargin) => default(bool);
		public virtual string toString() => default(string);
		public virtual double distanceTo(LatLngExpression otherLatLng) => default(double);
		public virtual LatLng wrap() => default(LatLng);
		public virtual LatLngBounds toBounds(double sizeInMeters) => default(LatLngBounds);
		public virtual LatLng clone() => default(LatLng);
		public LatLng() { }
	}
	public partial interface LatLngLiteral
	{
		double lat { get; set; }
		double lng { get; set; }
	}
	public class LatLngTuple : TypeAlias
	{
		public LatLngTuple(object[] value) { Value = value; }
		public static implicit operator LatLngTuple(object[] value) { return new LatLngTuple(value); }
	}
	public class LatLngExpression : TypeAlias
	{
		public LatLngExpression(Union<LatLng, LatLngLiteral, LatLngTuple> value) { Value = value; }
		public static implicit operator LatLngExpression(Union<LatLng, LatLngLiteral, LatLngTuple> value) { return new LatLngExpression(value); }
	}
	public virtual LatLng latLng(double latitude, double longitude, double altitude) => default(LatLng);
	public virtual LatLng latLng(Union<LatLngTuple, object[], LatLngLiteral, latLngType_0> coords) => default(LatLng);
	public partial interface latLngType_0
	{
		double lat { get; set; }
		double lng { get; set; }
		double alt { get; set; }
	}
	public partial class LatLngBounds
	{
		public LatLngBounds(LatLngExpression southWest, LatLngExpression northEast) { }
		public LatLngBounds(LatLngBoundsLiteral latlngs) { }
		public virtual LatLngBounds extend(Union<LatLngExpression, LatLngBoundsExpression> latlngOrBounds) => default(LatLngBounds);
		public virtual LatLngBounds pad(double bufferRatio) => default(LatLngBounds);
		public virtual LatLng getCenter() => default(LatLng);
		public virtual LatLng getSouthWest() => default(LatLng);
		public virtual LatLng getNorthEast() => default(LatLng);
		public virtual LatLng getNorthWest() => default(LatLng);
		public virtual LatLng getSouthEast() => default(LatLng);
		public virtual double getWest() => default(double);
		public virtual double getSouth() => default(double);
		public virtual double getEast() => default(double);
		public virtual double getNorth() => default(double);
		public virtual bool contains(Union<LatLngBoundsExpression, LatLngExpression> otherBoundsOrLatLng) => default(bool);
		public virtual bool intersects(LatLngBoundsExpression otherBounds) => default(bool);
		public virtual bool overlaps(BoundsExpression otherBounds) => default(bool);
		public virtual string toBBoxString() => default(string);
		public virtual bool equals(LatLngBoundsExpression otherBounds) => default(bool);
		public virtual bool isValid() => default(bool);
		public LatLngBounds() { }
	}
	public class LatLngBoundsLiteral : TypeAlias
	{
		public LatLngBoundsLiteral(LatLngTuple[] value) { Value = value; }
		public static implicit operator LatLngBoundsLiteral(LatLngTuple[] value) { return new LatLngBoundsLiteral(value); }
	}
	public class LatLngBoundsExpression : TypeAlias
	{
		public LatLngBoundsExpression(Union<LatLngBounds, LatLngBoundsLiteral> value) { Value = value; }
		public static implicit operator LatLngBoundsExpression(Union<LatLngBounds, LatLngBoundsLiteral> value) { return new LatLngBoundsExpression(value); }
	}
	public virtual LatLngBounds latLngBounds(LatLngExpression southWest, LatLngExpression northEast) => default(LatLngBounds);
	public virtual LatLngBounds latLngBounds(LatLngExpression[] latlngs) => default(LatLngBounds);
	public class PointTuple : TypeAlias
	{
		public PointTuple(object[] value) { Value = value; }
		public static implicit operator PointTuple(object[] value) { return new PointTuple(value); }
	}
	public partial class Point
	{
		public virtual double x { get; set; }
		public virtual double y { get; set; }
		public Point(double x, double y, bool round) { }
		public virtual Point clone() => default(Point);
		public virtual Point add(PointExpression otherPoint) => default(Point);
		public virtual Point subtract(PointExpression otherPoint) => default(Point);
		public virtual Point divideBy(double num) => default(Point);
		public virtual Point multiplyBy(double num) => default(Point);
		public virtual Point scaleBy(PointExpression scale) => default(Point);
		public virtual Point unscaleBy(PointExpression scale) => default(Point);
		public virtual Point round() => default(Point);
		public virtual Point floor() => default(Point);
		public virtual Point ceil() => default(Point);
		public virtual double distanceTo(PointExpression otherPoint) => default(double);
		public virtual bool equals(PointExpression otherPoint) => default(bool);
		public virtual bool contains(PointExpression otherPoint) => default(bool);
		public virtual string toString() => default(string);
		public Point() { }
	}
	public partial class Coords : Point
	{
		public virtual double z { get; set; }
	}
	public class PointExpression : TypeAlias
	{
		public PointExpression(Union<Point, PointTuple> value) { Value = value; }
		public static implicit operator PointExpression(Union<Point, PointTuple> value) { return new PointExpression(value); }
	}
	public virtual Point point(double x, double y, bool round) => default(Point);
	public virtual Point point(Union<PointTuple, pointType_0> coords) => default(Point);
	public partial interface pointType_0
	{
		double x { get; set; }
		double y { get; set; }
	}
	public class BoundsLiteral : TypeAlias
	{
		public BoundsLiteral(object[] value) { Value = value; }
		public static implicit operator BoundsLiteral(object[] value) { return new BoundsLiteral(value); }
	}
	public partial class Bounds
	{
		public virtual Point min { get; set; }
		public virtual Point max { get; set; }
		public Bounds(PointExpression topLeft, PointExpression bottomRight) { }
		public Bounds(Union<Point[], BoundsLiteral> points) { }
		public virtual Bounds extend(PointExpression point) => default(Bounds);
		public virtual Point getCenter(bool round) => default(Point);
		public virtual Point getBottomLeft() => default(Point);
		public virtual Point getTopRight() => default(Point);
		public virtual Point getSize() => default(Point);
		public virtual bool contains(Union<BoundsExpression, PointExpression> pointOrBounds) => default(bool);
		public virtual bool intersects(BoundsExpression otherBounds) => default(bool);
		public virtual bool overlaps(BoundsExpression otherBounds) => default(bool);
		public Bounds() { }
	}
	public class BoundsExpression : TypeAlias
	{
		public BoundsExpression(Union<Bounds, BoundsLiteral> value) { Value = value; }
		public static implicit operator BoundsExpression(Union<Bounds, BoundsLiteral> value) { return new BoundsExpression(value); }
	}
	public virtual Bounds bounds(PointExpression topLeft, PointExpression bottomRight) => default(Bounds);
	public virtual Bounds bounds(Union<Point[], BoundsLiteral> points) => default(Bounds);
	public class LeafletEventHandlerFn : TypeAlias
	{
		public LeafletEventHandlerFn(Action<LeafletEvent> value) { Value = value; }
		public static implicit operator LeafletEventHandlerFn(Action<LeafletEvent> value) { return new LeafletEventHandlerFn(value); }
	}
	public class LayersControlEventHandlerFn : TypeAlias
	{
		public LayersControlEventHandlerFn(Action<LayersControlEvent> value) { Value = value; }
		public static implicit operator LayersControlEventHandlerFn(Action<LayersControlEvent> value) { return new LayersControlEventHandlerFn(value); }
	}
	public class LayerEventHandlerFn : TypeAlias
	{
		public LayerEventHandlerFn(Action<LayerEvent> value) { Value = value; }
		public static implicit operator LayerEventHandlerFn(Action<LayerEvent> value) { return new LayerEventHandlerFn(value); }
	}
	public class ResizeEventHandlerFn : TypeAlias
	{
		public ResizeEventHandlerFn(Action<ResizeEvent> value) { Value = value; }
		public static implicit operator ResizeEventHandlerFn(Action<ResizeEvent> value) { return new ResizeEventHandlerFn(value); }
	}
	public class PopupEventHandlerFn : TypeAlias
	{
		public PopupEventHandlerFn(Action<PopupEvent> value) { Value = value; }
		public static implicit operator PopupEventHandlerFn(Action<PopupEvent> value) { return new PopupEventHandlerFn(value); }
	}
	public class TooltipEventHandlerFn : TypeAlias
	{
		public TooltipEventHandlerFn(Action<TooltipEvent> value) { Value = value; }
		public static implicit operator TooltipEventHandlerFn(Action<TooltipEvent> value) { return new TooltipEventHandlerFn(value); }
	}
	public class ErrorEventHandlerFn : TypeAlias
	{
		public ErrorEventHandlerFn(Action<ErrorEvent> value) { Value = value; }
		public static implicit operator ErrorEventHandlerFn(Action<ErrorEvent> value) { return new ErrorEventHandlerFn(value); }
	}
	public class LocationEventHandlerFn : TypeAlias
	{
		public LocationEventHandlerFn(Action<LocationEvent> value) { Value = value; }
		public static implicit operator LocationEventHandlerFn(Action<LocationEvent> value) { return new LocationEventHandlerFn(value); }
	}
	public class LeafletMouseEventHandlerFn : TypeAlias
	{
		public LeafletMouseEventHandlerFn(Action<LeafletMouseEvent> value) { Value = value; }
		public static implicit operator LeafletMouseEventHandlerFn(Action<LeafletMouseEvent> value) { return new LeafletMouseEventHandlerFn(value); }
	}
	public class LeafletKeyboardEventHandlerFn : TypeAlias
	{
		public LeafletKeyboardEventHandlerFn(Action<LeafletKeyboardEvent> value) { Value = value; }
		public static implicit operator LeafletKeyboardEventHandlerFn(Action<LeafletKeyboardEvent> value) { return new LeafletKeyboardEventHandlerFn(value); }
	}
	public class ZoomAnimEventHandlerFn : TypeAlias
	{
		public ZoomAnimEventHandlerFn(Action<ZoomAnimEvent> value) { Value = value; }
		public static implicit operator ZoomAnimEventHandlerFn(Action<ZoomAnimEvent> value) { return new ZoomAnimEventHandlerFn(value); }
	}
	public class DragEndEventHandlerFn : TypeAlias
	{
		public DragEndEventHandlerFn(Action<DragEndEvent> value) { Value = value; }
		public static implicit operator DragEndEventHandlerFn(Action<DragEndEvent> value) { return new DragEndEventHandlerFn(value); }
	}
	public class TileEventHandlerFn : TypeAlias
	{
		public TileEventHandlerFn(Action<TileEvent> value) { Value = value; }
		public static implicit operator TileEventHandlerFn(Action<TileEvent> value) { return new TileEventHandlerFn(value); }
	}
	public class TileErrorEventHandlerFn : TypeAlias
	{
		public TileErrorEventHandlerFn(Action<TileErrorEvent> value) { Value = value; }
		public static implicit operator TileErrorEventHandlerFn(Action<TileErrorEvent> value) { return new TileErrorEventHandlerFn(value); }
	}
	public partial interface LeafletEventHandlerFnMap
	{
		LayersControlEventHandlerFn baselayerchange { get; set; }
		LayersControlEventHandlerFn overlayadd { get; set; }
		LayersControlEventHandlerFn overlayremove { get; set; }
		LayerEventHandlerFn layeradd { get; set; }
		LayerEventHandlerFn layerremove { get; set; }
		LeafletEventHandlerFn zoomlevelschange { get; set; }
		LeafletEventHandlerFn unload { get; set; }
		LeafletEventHandlerFn viewreset { get; set; }
		LeafletEventHandlerFn load { get; set; }
		LeafletEventHandlerFn zoomstart { get; set; }
		LeafletEventHandlerFn movestart { get; set; }
		LeafletEventHandlerFn zoom { get; set; }
		LeafletEventHandlerFn move { get; set; }
		LeafletEventHandlerFn zoomend { get; set; }
		LeafletEventHandlerFn moveend { get; set; }
		LeafletEventHandlerFn autopanstart { get; set; }
		LeafletEventHandlerFn dragstart { get; set; }
		LeafletEventHandlerFn drag { get; set; }
		LeafletEventHandlerFn add { get; set; }
		LeafletEventHandlerFn remove { get; set; }
		LeafletEventHandlerFn loading { get; set; }
		LeafletEventHandlerFn error { get; set; }
		LeafletEventHandlerFn update { get; set; }
		LeafletEventHandlerFn down { get; set; }
		LeafletEventHandlerFn predrag { get; set; }
		ResizeEventHandlerFn resize { get; set; }
		PopupEventHandlerFn popupopen { get; set; }
		PopupEventHandlerFn popupclose { get; set; }
		TooltipEventHandlerFn tooltipopen { get; set; }
		TooltipEventHandlerFn tooltipclose { get; set; }
		ErrorEventHandlerFn locationerror { get; set; }
		LocationEventHandlerFn locationfound { get; set; }
		LeafletMouseEventHandlerFn click { get; set; }
		LeafletMouseEventHandlerFn dblclick { get; set; }
		LeafletMouseEventHandlerFn mousedown { get; set; }
		LeafletMouseEventHandlerFn mouseup { get; set; }
		LeafletMouseEventHandlerFn mouseover { get; set; }
		LeafletMouseEventHandlerFn mouseout { get; set; }
		LeafletMouseEventHandlerFn mousemove { get; set; }
		LeafletMouseEventHandlerFn contextmenu { get; set; }
		LeafletMouseEventHandlerFn preclick { get; set; }
		LeafletKeyboardEventHandlerFn keypress { get; set; }
		LeafletKeyboardEventHandlerFn keydown { get; set; }
		LeafletKeyboardEventHandlerFn keyup { get; set; }
		ZoomAnimEventHandlerFn zoomanim { get; set; }
		DragEndEventHandlerFn dragend { get; set; }
		TileEventHandlerFn tileunload { get; set; }
		TileEventHandlerFn tileloadstart { get; set; }
		TileEventHandlerFn tileload { get; set; }
		TileErrorEventHandlerFn tileerror { get; set; }
	}
	public abstract partial class Evented : Class
	{
		public class EventedType_0 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_0(string value) { return new EventedType_0(value); }
			public EventedType_0(object value) { Value = value; }
		}
		public class EventedType_1 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_1(string value) { return new EventedType_1(value); }
			public EventedType_1(object value) { Value = value; }
		}
		public class EventedType_2 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_2(string value) { return new EventedType_2(value); }
			public EventedType_2(object value) { Value = value; }
		}
		public class EventedType_3 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_3(string value) { return new EventedType_3(value); }
			public EventedType_3(object value) { Value = value; }
		}
		public class EventedType_4 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_4(string value) { return new EventedType_4(value); }
			public EventedType_4(object value) { Value = value; }
		}
		public class EventedType_5 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_5(string value) { return new EventedType_5(value); }
			public EventedType_5(object value) { Value = value; }
		}
		public class EventedType_6 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_6(string value) { return new EventedType_6(value); }
			public EventedType_6(object value) { Value = value; }
		}
		public class EventedType_7 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_7(string value) { return new EventedType_7(value); }
			public EventedType_7(object value) { Value = value; }
		}
		public class EventedType_8 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_8(string value) { return new EventedType_8(value); }
			public EventedType_8(object value) { Value = value; }
		}
		public class EventedType_9 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_9(string value) { return new EventedType_9(value); }
			public EventedType_9(object value) { Value = value; }
		}
		public class EventedType_10 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_10(string value) { return new EventedType_10(value); }
			public EventedType_10(object value) { Value = value; }
		}
		public class EventedType_11 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_11(string value) { return new EventedType_11(value); }
			public EventedType_11(object value) { Value = value; }
		}
		public class EventedType_12 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_12(string value) { return new EventedType_12(value); }
			public EventedType_12(object value) { Value = value; }
		}
		public class EventedType_13 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_13(string value) { return new EventedType_13(value); }
			public EventedType_13(object value) { Value = value; }
		}
		public class EventedType_14 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_14(string value) { return new EventedType_14(value); }
			public EventedType_14(object value) { Value = value; }
		}
		public class EventedType_15 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_15(string value) { return new EventedType_15(value); }
			public EventedType_15(object value) { Value = value; }
		}
		public class EventedType_16 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_16(string value) { return new EventedType_16(value); }
			public EventedType_16(object value) { Value = value; }
		}
		public class EventedType_17 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_17(string value) { return new EventedType_17(value); }
			public EventedType_17(object value) { Value = value; }
		}
		public class EventedType_18 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_18(string value) { return new EventedType_18(value); }
			public EventedType_18(object value) { Value = value; }
		}
		public class EventedType_19 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_19(string value) { return new EventedType_19(value); }
			public EventedType_19(object value) { Value = value; }
		}
		public class EventedType_20 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_20(string value) { return new EventedType_20(value); }
			public EventedType_20(object value) { Value = value; }
		}
		public class EventedType_21 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_21(string value) { return new EventedType_21(value); }
			public EventedType_21(object value) { Value = value; }
		}
		public class EventedType_22 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_22(string value) { return new EventedType_22(value); }
			public EventedType_22(object value) { Value = value; }
		}
		public class EventedType_23 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_23(string value) { return new EventedType_23(value); }
			public EventedType_23(object value) { Value = value; }
		}
		public class EventedType_24 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_24(string value) { return new EventedType_24(value); }
			public EventedType_24(object value) { Value = value; }
		}
		public class EventedType_25 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_25(string value) { return new EventedType_25(value); }
			public EventedType_25(object value) { Value = value; }
		}
		public class EventedType_26 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_26(string value) { return new EventedType_26(value); }
			public EventedType_26(object value) { Value = value; }
		}
		public class EventedType_27 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_27(string value) { return new EventedType_27(value); }
			public EventedType_27(object value) { Value = value; }
		}
		public class EventedType_28 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_28(string value) { return new EventedType_28(value); }
			public EventedType_28(object value) { Value = value; }
		}
		public class EventedType_29 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_29(string value) { return new EventedType_29(value); }
			public EventedType_29(object value) { Value = value; }
		}
		public class EventedType_30 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_30(string value) { return new EventedType_30(value); }
			public EventedType_30(object value) { Value = value; }
		}
		public class EventedType_31 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_31(string value) { return new EventedType_31(value); }
			public EventedType_31(object value) { Value = value; }
		}
		public class EventedType_32 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_32(string value) { return new EventedType_32(value); }
			public EventedType_32(object value) { Value = value; }
		}
		public class EventedType_33 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_33(string value) { return new EventedType_33(value); }
			public EventedType_33(object value) { Value = value; }
		}
		public class EventedType_34 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_34(string value) { return new EventedType_34(value); }
			public EventedType_34(object value) { Value = value; }
		}
		public class EventedType_35 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_35(string value) { return new EventedType_35(value); }
			public EventedType_35(object value) { Value = value; }
		}
		public class EventedType_36 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_36(string value) { return new EventedType_36(value); }
			public EventedType_36(object value) { Value = value; }
		}
		public class EventedType_37 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_37(string value) { return new EventedType_37(value); }
			public EventedType_37(object value) { Value = value; }
		}
		public class EventedType_38 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_38(string value) { return new EventedType_38(value); }
			public EventedType_38(object value) { Value = value; }
		}
		public class EventedType_39 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_39(string value) { return new EventedType_39(value); }
			public EventedType_39(object value) { Value = value; }
		}
		public class EventedType_40 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_40(string value) { return new EventedType_40(value); }
			public EventedType_40(object value) { Value = value; }
		}
		public class EventedType_41 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_41(string value) { return new EventedType_41(value); }
			public EventedType_41(object value) { Value = value; }
		}
		public class EventedType_42 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_42(string value) { return new EventedType_42(value); }
			public EventedType_42(object value) { Value = value; }
		}
		public class EventedType_43 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_43(string value) { return new EventedType_43(value); }
			public EventedType_43(object value) { Value = value; }
		}
		public class EventedType_44 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_44(string value) { return new EventedType_44(value); }
			public EventedType_44(object value) { Value = value; }
		}
		public class EventedType_45 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_45(string value) { return new EventedType_45(value); }
			public EventedType_45(object value) { Value = value; }
		}
		public class EventedType_46 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_46(string value) { return new EventedType_46(value); }
			public EventedType_46(object value) { Value = value; }
		}
		public class EventedType_47 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_47(string value) { return new EventedType_47(value); }
			public EventedType_47(object value) { Value = value; }
		}
		public class EventedType_48 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_48(string value) { return new EventedType_48(value); }
			public EventedType_48(object value) { Value = value; }
		}
		public class EventedType_49 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_49(string value) { return new EventedType_49(value); }
			public EventedType_49(object value) { Value = value; }
		}
		public class EventedType_50 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_50(string value) { return new EventedType_50(value); }
			public EventedType_50(object value) { Value = value; }
		}
		public class EventedType_51 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_51(string value) { return new EventedType_51(value); }
			public EventedType_51(object value) { Value = value; }
		}
		public class EventedType_52 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_52(string value) { return new EventedType_52(value); }
			public EventedType_52(object value) { Value = value; }
		}
		public class EventedType_53 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_53(string value) { return new EventedType_53(value); }
			public EventedType_53(object value) { Value = value; }
		}
		public class EventedType_54 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_54(string value) { return new EventedType_54(value); }
			public EventedType_54(object value) { Value = value; }
		}
		public class EventedType_55 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_55(string value) { return new EventedType_55(value); }
			public EventedType_55(object value) { Value = value; }
		}
		public class EventedType_56 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_56(string value) { return new EventedType_56(value); }
			public EventedType_56(object value) { Value = value; }
		}
		public class EventedType_57 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_57(string value) { return new EventedType_57(value); }
			public EventedType_57(object value) { Value = value; }
		}
		public class EventedType_58 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_58(string value) { return new EventedType_58(value); }
			public EventedType_58(object value) { Value = value; }
		}
		public class EventedType_59 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_59(string value) { return new EventedType_59(value); }
			public EventedType_59(object value) { Value = value; }
		}
		public class EventedType_60 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_60(string value) { return new EventedType_60(value); }
			public EventedType_60(object value) { Value = value; }
		}
		public class EventedType_61 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_61(string value) { return new EventedType_61(value); }
			public EventedType_61(object value) { Value = value; }
		}
		public class EventedType_62 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_62(string value) { return new EventedType_62(value); }
			public EventedType_62(object value) { Value = value; }
		}
		public class EventedType_63 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_63(string value) { return new EventedType_63(value); }
			public EventedType_63(object value) { Value = value; }
		}
		public class EventedType_64 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_64(string value) { return new EventedType_64(value); }
			public EventedType_64(object value) { Value = value; }
		}
		public class EventedType_65 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_65(string value) { return new EventedType_65(value); }
			public EventedType_65(object value) { Value = value; }
		}
		public class EventedType_66 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_66(string value) { return new EventedType_66(value); }
			public EventedType_66(object value) { Value = value; }
		}
		public class EventedType_67 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_67(string value) { return new EventedType_67(value); }
			public EventedType_67(object value) { Value = value; }
		}
		public class EventedType_68 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_68(string value) { return new EventedType_68(value); }
			public EventedType_68(object value) { Value = value; }
		}
		public class EventedType_69 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_69(string value) { return new EventedType_69(value); }
			public EventedType_69(object value) { Value = value; }
		}
		public class EventedType_70 : Enumerated
		{
			public static string baselayerchange = "baselayerchange";
			public static string overlayadd = "overlayadd";
			public static string overlayremove = "overlayremove";
			public static implicit operator EventedType_70(string value) { return new EventedType_70(value); }
			public EventedType_70(object value) { Value = value; }
		}
		public class EventedType_71 : Enumerated
		{
			public static string layeradd = "layeradd";
			public static string layerremove = "layerremove";
			public static implicit operator EventedType_71(string value) { return new EventedType_71(value); }
			public EventedType_71(object value) { Value = value; }
		}
		public class EventedType_72 : Enumerated
		{
			public static string zoomlevelschange = "zoomlevelschange";
			public static string unload = "unload";
			public static string viewreset = "viewreset";
			public static string load = "load";
			public static string zoomstart = "zoomstart";
			public static string movestart = "movestart";
			public static string zoom = "zoom";
			public static string move = "move";
			public static string zoomend = "zoomend";
			public static string moveend = "moveend";
			public static string autopanstart = "autopanstart";
			public static string dragstart = "dragstart";
			public static string drag = "drag";
			public static string add = "add";
			public static string remove = "remove";
			public static string loading = "loading";
			public static string error = "error";
			public static string update = "update";
			public static string down = "down";
			public static string predrag = "predrag";
			public static implicit operator EventedType_72(string value) { return new EventedType_72(value); }
			public EventedType_72(object value) { Value = value; }
		}
		public class EventedType_73 : Enumerated
		{
			public static string resize = "resize";
			public static implicit operator EventedType_73(string value) { return new EventedType_73(value); }
			public EventedType_73(object value) { Value = value; }
		}
		public class EventedType_74 : Enumerated
		{
			public static string popupopen = "popupopen";
			public static string popupclose = "popupclose";
			public static implicit operator EventedType_74(string value) { return new EventedType_74(value); }
			public EventedType_74(object value) { Value = value; }
		}
		public class EventedType_75 : Enumerated
		{
			public static string tooltipopen = "tooltipopen";
			public static string tooltipclose = "tooltipclose";
			public static implicit operator EventedType_75(string value) { return new EventedType_75(value); }
			public EventedType_75(object value) { Value = value; }
		}
		public class EventedType_76 : Enumerated
		{
			public static string locationerror = "locationerror";
			public static implicit operator EventedType_76(string value) { return new EventedType_76(value); }
			public EventedType_76(object value) { Value = value; }
		}
		public class EventedType_77 : Enumerated
		{
			public static string locationfound = "locationfound";
			public static implicit operator EventedType_77(string value) { return new EventedType_77(value); }
			public EventedType_77(object value) { Value = value; }
		}
		public class EventedType_78 : Enumerated
		{
			public static string click = "click";
			public static string dblclick = "dblclick";
			public static string mousedown = "mousedown";
			public static string mouseup = "mouseup";
			public static string mouseover = "mouseover";
			public static string mouseout = "mouseout";
			public static string mousemove = "mousemove";
			public static string contextmenu = "contextmenu";
			public static string preclick = "preclick";
			public static implicit operator EventedType_78(string value) { return new EventedType_78(value); }
			public EventedType_78(object value) { Value = value; }
		}
		public class EventedType_79 : Enumerated
		{
			public static string keypress = "keypress";
			public static string keydown = "keydown";
			public static string keyup = "keyup";
			public static implicit operator EventedType_79(string value) { return new EventedType_79(value); }
			public EventedType_79(object value) { Value = value; }
		}
		public class EventedType_80 : Enumerated
		{
			public static string zoomanim = "zoomanim";
			public static implicit operator EventedType_80(string value) { return new EventedType_80(value); }
			public EventedType_80(object value) { Value = value; }
		}
		public class EventedType_81 : Enumerated
		{
			public static string dragend = "dragend";
			public static implicit operator EventedType_81(string value) { return new EventedType_81(value); }
			public EventedType_81(object value) { Value = value; }
		}
		public class EventedType_82 : Enumerated
		{
			public static string tileunload = "tileunload";
			public static string tileloadstart = "tileloadstart";
			public static string tileload = "tileload";
			public static implicit operator EventedType_82(string value) { return new EventedType_82(value); }
			public EventedType_82(object value) { Value = value; }
		}
		public class EventedType_83 : Enumerated
		{
			public static string tileerror = "tileerror";
			public static implicit operator EventedType_83(string value) { return new EventedType_83(value); }
			public EventedType_83(object value) { Value = value; }
		}
		public virtual Evented on(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_0 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_1 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_2 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_3 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_4 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_5 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_6 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_7 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_8 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_9 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_10 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_11 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_12 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(EventedType_13 type, TileErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented on(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented off(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_14 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_15 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_16 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_17 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_18 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_19 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_20 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_21 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_22 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_23 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_24 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_25 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_26 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(EventedType_27 type, TileErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented off(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented off() => default(Evented);
		public virtual Evented fire(string type, object data, bool propagate) => default(Evented);
		public virtual bool listens(string type) => default(bool);
		public virtual Evented once(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_28 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_29 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_30 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_31 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_32 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_33 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_34 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_35 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_36 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_37 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_38 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_39 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_40 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(EventedType_41 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented once(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented addEventParent(Evented obj) => default(Evented);
		public virtual Evented removeEventParent(Evented obj) => default(Evented);
		public virtual Evented addEventListener(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_42 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_43 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_44 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_45 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_46 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_47 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_48 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_49 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_50 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_51 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_52 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_53 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_54 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(EventedType_55 type, TileErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addEventListener(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented removeEventListener(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_56 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_57 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_58 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_59 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_60 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_61 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_62 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_63 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_64 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_65 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_66 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_67 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_68 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(EventedType_69 type, TileErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented removeEventListener(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented clearAllEventListeners() => default(Evented);
		public virtual Evented addOneTimeEventListener(string type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_70 type, LayersControlEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_71 type, LayerEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_72 type, LeafletEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_73 type, ResizeEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_74 type, PopupEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_75 type, TooltipEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_76 type, ErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_77 type, LocationEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_78 type, LeafletMouseEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_79 type, LeafletKeyboardEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_80 type, ZoomAnimEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_81 type, DragEndEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_82 type, TileEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(EventedType_83 type, TileErrorEventHandlerFn fn, object context) => default(Evented);
		public virtual Evented addOneTimeEventListener(LeafletEventHandlerFnMap eventMap) => default(Evented);
		public virtual Evented fireEvent(string type, object data, bool propagate) => default(Evented);
		public virtual bool hasEventListeners(string type) => default(bool);
		public Evented() { }
	}
	public partial class Draggable : Evented
	{
		public Draggable(HTMLElement element, HTMLElement dragStartTarget, bool preventOutline) { }
		public virtual void enable() { }
		public virtual void disable() { }
		public virtual void finishDrag() { }
		public Draggable() { }
	}
	public partial interface LayerOptions
	{
		string pane { get; set; }
		string attribution { get; set; }
	}
	public partial interface InteractiveLayerOptions : LayerOptions
	{
		bool interactive { get; set; }
		bool bubblingMouseEvents { get; set; }
	}
	public partial class Layer : Evented
	{
		public partial interface LayerType_0
		{
			LeafletEventHandlerFn this[string name] { get; set; }
		}
		protected virtual Map _map { get; set; }
		public Layer(LayerOptions options) { }
		public virtual Layer addTo(Union<Map, LayerGroup> map) => default(Layer);
		public virtual Layer remove() => default(Layer);
		public virtual Layer removeFrom(Map map) => default(Layer);
		public virtual Union<HTMLElement, undefined> getPane(string name) => default(Union<HTMLElement, undefined>);
		public virtual Layer bindPopup(Union<Func<Layer, Content>, Content, Popup> content, PopupOptions options) => default(Layer);
		public virtual Layer unbindPopup() => default(Layer);
		public virtual Layer openPopup(LatLngExpression latlng) => default(Layer);
		public virtual Layer closePopup() => default(Layer);
		public virtual Layer togglePopup() => default(Layer);
		public virtual bool isPopupOpen() => default(bool);
		public virtual Layer setPopupContent(Union<Content, Popup> content) => default(Layer);
		public virtual Union<Popup, undefined> getPopup() => default(Union<Popup, undefined>);
		public virtual Layer bindTooltip(Union<Func<Layer, Content>, Tooltip, Content> content, TooltipOptions options) => default(Layer);
		public virtual Layer unbindTooltip() => default(Layer);
		public virtual Layer openTooltip(LatLngExpression latlng) => default(Layer);
		public virtual Layer closeTooltip() => default(Layer);
		public virtual Layer toggleTooltip() => default(Layer);
		public virtual bool isTooltipOpen() => default(bool);
		public virtual Layer setTooltipContent(Union<Content, Tooltip> content) => default(Layer);
		public virtual Union<Tooltip, undefined> getTooltip() => default(Union<Tooltip, undefined>);
		public virtual Layer onAdd(Map map) => default(Layer);
		public virtual Layer onRemove(Map map) => default(Layer);
		public virtual LayerType_0 getEvents() => default(LayerType_0);
		public virtual Union<string, object> getAttribution() => default(Union<string, object>);
		public virtual Layer beforeAdd(Map map) => default(Layer);
		public Layer() { }
	}
	public partial interface GridLayerOptions
	{
		Union<double, Point> tileSize { get; set; }
		double opacity { get; set; }
		bool updateWhenIdle { get; set; }
		bool updateWhenZooming { get; set; }
		double updateInterval { get; set; }
		string attribution { get; set; }
		double zIndex { get; set; }
		LatLngBoundsExpression bounds { get; set; }
		double minZoom { get; set; }
		double maxZoom { get; set; }
		bool noWrap { get; set; }
		string pane { get; set; }
		string className { get; set; }
		double keepBuffer { get; set; }
	}
	public class DoneCallback : TypeAlias
	{
		public DoneCallback(Action<Error, HTMLElement> value) { Value = value; }
		public static implicit operator DoneCallback(Action<Error, HTMLElement> value) { return new DoneCallback(value); }
	}
	public partial interface InternalTiles
	{
		InternalTilesType_0 this[string key] { get; set; }
	}
	public partial interface InternalTilesType_0
	{
		bool active { get; set; }
		Coords coords { get; set; }
		bool current { get; set; }
		HTMLElement el { get; set; }
		Date loaded { get; set; }
		bool retain { get; set; }
	}
	public partial class GridLayer : Layer
	{
		protected virtual InternalTiles _tiles { get; set; }
		protected virtual double _tileZoom { get; set; }
		public GridLayer(GridLayerOptions options) { }
		public virtual GridLayer bringToFront() => default(GridLayer);
		public virtual GridLayer bringToBack() => default(GridLayer);
		public virtual Union<HTMLElement, object> getContainer() => default(Union<HTMLElement, object>);
		public virtual GridLayer setOpacity(double opacity) => default(GridLayer);
		public virtual GridLayer setZIndex(double zIndex) => default(GridLayer);
		public virtual bool isLoading() => default(bool);
		public virtual GridLayer redraw() => default(GridLayer);
		public virtual Point getTileSize() => default(Point);
		protected virtual HTMLElement createTile(Coords coords, DoneCallback done) => default(HTMLElement);
		protected virtual string _tileCoordsToKey(Coords coords) => default(string);
		public GridLayer() { }
	}
	public virtual GridLayer gridLayer(GridLayerOptions options) => default(GridLayer);
	public partial interface TileLayerOptions : GridLayerOptions
	{
		string id { get; set; }
		string accessToken { get; set; }
		double minZoom { get; set; }
		double maxZoom { get; set; }
		double maxNativeZoom { get; set; }
		double minNativeZoom { get; set; }
		Union<string, string[]> subdomains { get; set; }
		string errorTileUrl { get; set; }
		double zoomOffset { get; set; }
		bool tms { get; set; }
		bool zoomReverse { get; set; }
		bool detectRetina { get; set; }
		CrossOrigin crossOrigin { get; set; }
	}
	public partial class TileLayer : GridLayer
	{
		public partial class WMS : TileLayer
		{
			public virtual WMSParams wmsParams { get; set; }
			public virtual WMSOptions options { get; set; }
			public WMS(string baseUrl, WMSOptions options) { }
			public virtual WMS setParams(WMSParams @params, bool noRedraw) => default(WMS);
			public WMS() { }
		}
		public virtual TileLayerOptions options { get; set; }
		public TileLayer(string urlTemplate, TileLayerOptions options) { }
		public virtual TileLayer setUrl(string url, bool noRedraw) => default(TileLayer);
		public virtual string getTileUrl(Coords coords) => default(string);
		protected virtual void _abortLoading() { }
		protected virtual double _getZoomForUrl() => default(double);
		public TileLayer() { }
	}
	public virtual TileLayer tileLayer(string urlTemplate, TileLayerOptions options) => default(TileLayer);
	public partial interface WMSOptions : TileLayerOptions
	{
		string layers { get; set; }
		string styles { get; set; }
		string format { get; set; }
		bool transparent { get; set; }
		string version { get; set; }
		CRS crs { get; set; }
		bool uppercase { get; set; }
	}
	public partial interface WMSParams
	{
		string format { get; set; }
		string layers { get; set; }
		string request { get; set; }
		string service { get; set; }
		string styles { get; set; }
		string version { get; set; }
		bool transparent { get; set; }
		double width { get; set; }
		double height { get; set; }
	}
	//[Name("tileLayer")]
	public partial class _TileLayer
	{
		public virtual TileLayer.WMS wms(string baseUrl, WMSOptions options) => default(TileLayer.WMS);
		public _TileLayer() { }
	}
	public class CrossOrigin : TypeAlias
	{
		public CrossOrigin(Union<bool, string> value) { Value = value; }
		public static implicit operator CrossOrigin(Union<bool, string> value) { return new CrossOrigin(value); }
	}
	public partial interface ImageOverlayOptions : InteractiveLayerOptions
	{
		double opacity { get; set; }
		string alt { get; set; }
		bool interactive { get; set; }
		string attribution { get; set; }
		CrossOrigin crossOrigin { get; set; }
		string errorOverlayUrl { get; set; }
		double zIndex { get; set; }
		string className { get; set; }
	}
	public partial class ImageOverlay : Layer
	{
		public virtual ImageOverlayOptions options { get; set; }
		public ImageOverlay(string imageUrl, LatLngBoundsExpression bounds, ImageOverlayOptions options) { }
		public virtual ImageOverlay setOpacity(double opacity) => default(ImageOverlay);
		public virtual ImageOverlay bringToFront() => default(ImageOverlay);
		public virtual ImageOverlay bringToBack() => default(ImageOverlay);
		public virtual ImageOverlay setUrl(string url) => default(ImageOverlay);
		public virtual ImageOverlay setBounds(LatLngBounds bounds) => default(ImageOverlay);
		public virtual ImageOverlay setZIndex(double value) => default(ImageOverlay);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public virtual Union<HTMLImageElement, undefined> getElement() => default(Union<HTMLImageElement, undefined>);
		public ImageOverlay() { }
	}
	public virtual ImageOverlay imageOverlay(string imageUrl, LatLngBoundsExpression bounds, ImageOverlayOptions options) => default(ImageOverlay);
	public partial class SVGOverlay : Layer
	{
		public virtual ImageOverlayOptions options { get; set; }
		public SVGOverlay(Union<string, SVGElement> svgImage, LatLngBoundsExpression bounds, ImageOverlayOptions options) { }
		public virtual SVGOverlay setOpacity(double opacity) => default(SVGOverlay);
		public virtual SVGOverlay bringToFront() => default(SVGOverlay);
		public virtual SVGOverlay bringToBack() => default(SVGOverlay);
		public virtual SVGOverlay setUrl(string url) => default(SVGOverlay);
		public virtual SVGOverlay setBounds(LatLngBounds bounds) => default(SVGOverlay);
		public virtual SVGOverlay setZIndex(double value) => default(SVGOverlay);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public virtual Union<SVGElement, undefined> getElement() => default(Union<SVGElement, undefined>);
		public SVGOverlay() { }
	}
	public virtual SVGOverlay svgOverlay(Union<string, SVGElement> svgImage, LatLngBoundsExpression bounds, ImageOverlayOptions options) => default(SVGOverlay);
	public partial interface VideoOverlayOptions : ImageOverlayOptions
	{
		bool autoplay { get; set; }
		bool loop { get; set; }
		bool keepAspectRatio { get; set; }
	}
	public partial class VideoOverlay : Layer
	{
		public virtual VideoOverlayOptions options { get; set; }
		public VideoOverlay(Union<string, string[], HTMLVideoElement> video, LatLngBoundsExpression bounds, VideoOverlayOptions options) { }
		public virtual VideoOverlay setOpacity(double opacity) => default(VideoOverlay);
		public virtual VideoOverlay bringToFront() => default(VideoOverlay);
		public virtual VideoOverlay bringToBack() => default(VideoOverlay);
		public virtual VideoOverlay setUrl(string url) => default(VideoOverlay);
		public virtual VideoOverlay setBounds(LatLngBounds bounds) => default(VideoOverlay);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public virtual Union<HTMLVideoElement, undefined> getElement() => default(Union<HTMLVideoElement, undefined>);
		public VideoOverlay() { }
	}
	public virtual VideoOverlay videoOverlay(Union<string, string[], HTMLVideoElement> video, LatLngBoundsExpression bounds, VideoOverlayOptions options) => default(VideoOverlay);
	public class LineCapShape : Enumerated
	{
		public static string butt = "butt";
		public static string round = "round";
		public static string square = "square";
		public static string inherit = "inherit";
		public static implicit operator LineCapShape(string value) { return new LineCapShape(value); }
		public LineCapShape(object value) { Value = value; }
	}
	public class LineJoinShape : Enumerated
	{
		public static string miter = "miter";
		public static string round = "round";
		public static string bevel = "bevel";
		public static string inherit = "inherit";
		public static implicit operator LineJoinShape(string value) { return new LineJoinShape(value); }
		public LineJoinShape(object value) { Value = value; }
	}
	public class FillRule : Enumerated
	{
		public static string nonzero = "nonzero";
		public static string evenodd = "evenodd";
		public static string inherit = "inherit";
		public static implicit operator FillRule(string value) { return new FillRule(value); }
		public FillRule(object value) { Value = value; }
	}
	public partial interface PathOptions : InteractiveLayerOptions
	{
		bool stroke { get; set; }
		string color { get; set; }
		double weight { get; set; }
		double opacity { get; set; }
		LineCapShape lineCap { get; set; }
		LineJoinShape lineJoin { get; set; }
		Union<string, double[]> dashArray { get; set; }
		string dashOffset { get; set; }
		bool fill { get; set; }
		string fillColor { get; set; }
		double fillOpacity { get; set; }
		FillRule fillRule { get; set; }
		Renderer renderer { get; set; }
		string className { get; set; }
	}
	public abstract partial class Path : Layer
	{
		public virtual PathOptions options { get; set; }
		public virtual Path redraw() => default(Path);
		public virtual Path setStyle(PathOptions style) => default(Path);
		public virtual Path bringToFront() => default(Path);
		public virtual Path bringToBack() => default(Path);
		public virtual Union<Element, undefined> getElement() => default(Union<Element, undefined>);
		public Path() { }
	}
	public partial interface PolylineOptions : PathOptions
	{
		double smoothFactor { get; set; }
		bool noClip { get; set; }
	}
	public partial class Polyline<T, P> : Path
	{
		public virtual geojson.Feature<T, P> feature { get; set; }
		public virtual PolylineOptions options { get; set; }
		public Polyline(Union<LatLngExpression[], LatLngExpression[][]> latlngs, PolylineOptions options) { }
		public virtual geojson.Feature<T, P> toGeoJSON() => default(geojson.Feature<T, P>);
		public virtual Union<LatLng[], LatLng[][], LatLng[][][]> getLatLngs() => default(Union<LatLng[], LatLng[][], LatLng[][][]>);
		public virtual Polyline<T, P> setLatLngs(Union<LatLngExpression[], LatLngExpression[][], LatLngExpression[][][]> latlngs) => default(Polyline<T, P>);
		public virtual bool isEmpty() => default(bool);
		public virtual LatLng getCenter() => default(LatLng);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public virtual Polyline<T, P> addLatLng(Union<LatLngExpression, LatLngExpression[]> latlng, LatLng[] latlngs) => default(Polyline<T, P>);
		public virtual Point closestLayerPoint(Point p) => default(Point);
		public Polyline() { }
	}
	public virtual Polyline polyline(Union<LatLngExpression[], LatLngExpression[][]> latlngs, PolylineOptions options) => default(Polyline);
	public partial class Polygon<P> : Polyline<Union<geojson.Polygon, geojson.MultiPolygon>, P>
	{
		public Polygon(Union<LatLngExpression[], LatLngExpression[][], LatLngExpression[][][]> latlngs, PolylineOptions options) { }
		public Polygon() { }
	}
	public virtual Polygon polygon(Union<LatLngExpression[], LatLngExpression[][], LatLngExpression[][][]> latlngs, PolylineOptions options) => default(Polygon);
	public partial class Rectangle<P> : Polygon<P>
	{
		public Rectangle(LatLngBoundsExpression latLngBounds, PolylineOptions options) { }
		public virtual Rectangle<P> setBounds(LatLngBoundsExpression latLngBounds) => default(Rectangle<P>);
		public Rectangle() { }
	}
	public virtual Rectangle rectangle(LatLngBoundsExpression latLngBounds, PolylineOptions options) => default(Rectangle);
	public partial interface CircleMarkerOptions : PathOptions
	{
		double radius { get; set; }
	}
	public partial class CircleMarker<P> : Path
	{
		public virtual CircleMarkerOptions options { get; set; }
		public virtual geojson.Feature<geojson.Point, P> feature { get; set; }
		public CircleMarker(LatLngExpression latlng, CircleMarkerOptions options) { }
		public virtual geojson.Feature<geojson.Point, P> toGeoJSON() => default(geojson.Feature<geojson.Point, P>);
		public virtual CircleMarker<P> setLatLng(LatLngExpression latLng) => default(CircleMarker<P>);
		public virtual LatLng getLatLng() => default(LatLng);
		public virtual CircleMarker<P> setRadius(double radius) => default(CircleMarker<P>);
		public virtual double getRadius() => default(double);
		public CircleMarker() { }
	}
	public virtual CircleMarker circleMarker(LatLngExpression latlng, CircleMarkerOptions options) => default(CircleMarker);
	public partial class Circle<P> : CircleMarker<P>
	{
		public Circle(LatLngExpression latlng, CircleMarkerOptions options) { }
		public Circle(LatLngExpression latlng, double radius, CircleMarkerOptions options) { }
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public Circle() { }
	}
	public virtual Circle circle(LatLngExpression latlng, CircleMarkerOptions options) => default(Circle);
	public virtual Circle circle(LatLngExpression latlng, double radius, CircleMarkerOptions options) => default(Circle);
	public partial interface RendererOptions : LayerOptions
	{
		double padding { get; set; }
		double tolerance { get; set; }
	}
	public partial class Renderer : Layer
	{
		public virtual RendererOptions options { get; set; }
		public Renderer(RendererOptions options) { }
		public Renderer() { }
	}
	public partial class SVG : Renderer
	{
		public virtual SVGElement create(string name) => default(SVGElement);
		public virtual string pointsToPath(PointExpression[] rings, bool close) => default(string);
		public SVG() { }
	}
	public virtual SVG svg(RendererOptions options) => default(SVG);
	public partial class Canvas : Renderer
	{
		public Canvas() { }
	}
	public virtual Canvas canvas(RendererOptions options) => default(Canvas);
	public partial class LayerGroup<P> : Layer
	{
		public virtual Union<geojson.FeatureCollection<geojson.GeometryObject, P>, geojson.Feature<geojson.MultiPoint, P>, geojson.GeometryCollection> feature { get; set; }
		public LayerGroup(Layer[] layers, LayerOptions options) { }
		public virtual Union<geojson.FeatureCollection<geojson.GeometryObject, P>, geojson.Feature<geojson.MultiPoint, P>, geojson.GeometryCollection> toGeoJSON() => default(Union<geojson.FeatureCollection<geojson.GeometryObject, P>, geojson.Feature<geojson.MultiPoint, P>, geojson.GeometryCollection>);
		public virtual LayerGroup<P> addLayer(Layer layer) => default(LayerGroup<P>);
		public virtual LayerGroup<P> removeLayer(Union<double, Layer> layer) => default(LayerGroup<P>);
		public virtual bool hasLayer(Layer layer) => default(bool);
		public virtual LayerGroup<P> clearLayers() => default(LayerGroup<P>);
		public virtual LayerGroup<P> invoke(string methodName, object[] @params) => default(LayerGroup<P>);
		public virtual LayerGroup<P> eachLayer(Action<Layer> fn, object context) => default(LayerGroup<P>);
		public virtual Union<Layer, undefined> getLayer(double id) => default(Union<Layer, undefined>);
		public virtual Layer[] getLayers() => default(Layer[]);
		public virtual LayerGroup<P> setZIndex(double zIndex) => default(LayerGroup<P>);
		public virtual double getLayerId(Layer layer) => default(double);
		public LayerGroup() { }
	}
	public virtual LayerGroup layerGroup(Layer[] layers, LayerOptions options) => default(LayerGroup);
	public partial class FeatureGroup<P> : LayerGroup<P>
	{
		public virtual FeatureGroup<P> setStyle(PathOptions style) => default(FeatureGroup<P>);
		public virtual FeatureGroup<P> bringToFront() => default(FeatureGroup<P>);
		public virtual FeatureGroup<P> bringToBack() => default(FeatureGroup<P>);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public FeatureGroup() { }
	}
	public virtual FeatureGroup featureGroup(Layer[] layers) => default(FeatureGroup);
	public class StyleFunction<P> : TypeAlias
	{
		public StyleFunction(Func<geojson.Feature<geojson.GeometryObject, P>, PathOptions> value) { Value = value; }
		public static implicit operator StyleFunction<P>(Func<geojson.Feature<geojson.GeometryObject, P>, PathOptions> value) { return new StyleFunction<P>(value); }
	}

	///<summary>
	///  Create a feature group, optionally given an initial set of layers.
	///</summary>
	public partial interface GeoJSONOptions<P> : LayerOptions
	{

		///<summary>
		///      PathOptions or a Function defining the Path options for styling GeoJSON lines and polygons,
		///      called internally when data is added.
		///
		///      The default value is to not override any defaults:
		///
		///      ```
		///      function (geoJsonFeature) {
		///          return {}
		///      }
		///      ```
		///</summary>
		Union<PathOptions, StyleFunction<P>> style { get; set; }

		///<summary>
		///      A Function defining how GeoJSON points spawn Leaflet layers.
		///      It is internally called when data is added, passing the GeoJSON point
		///      feature and its LatLng.
		///
		///      The default is to spawn a default Marker:
		///
		///      ```
		///      function(geoJsonPoint, latlng) {
		///          return L.marker(latlng);
		///      }
		///      ```
		///</summary>
		Layer pointToLayer(geojson.Feature<geojson.Point, P> geoJsonPoint, LatLng latlng);

		///<summary>
		///      A Function that will be called once for each created Feature, after it
		///      has been created and styled. Useful for attaching events and popups to features.
		///
		///      The default is to do nothing with the newly created layers:
		///
		///      ```
		///      function (feature, layer) {}
		///      ```
		///</summary>
		void onEachFeature(geojson.Feature<geojson.GeometryObject, P> feature, Layer layer);

		///<summary>
		///      A Function that will be used to decide whether to show a feature or not.
		///
		///      The default is to show all features:
		///
		///      ```
		///      function (geoJsonFeature) {
		///          return true;
		///      }
		///      ```
		///</summary>
		bool filter(geojson.Feature<geojson.GeometryObject, P> geoJsonFeature);

		///<summary>
		///      A Function that will be used for converting GeoJSON coordinates to LatLngs.
		///      The default is the coordsToLatLng static method.
		///</summary>
		LatLng coordsToLatLng(Union<object[], object[]> coords);
	}
	public partial class GeoJSON<P> : FeatureGroup<P>
	{
		public virtual GeoJSONOptions<P> options { get; set; }
		public virtual Layer geometryToLayer<P>(geojson.Feature<geojson.GeometryObject, P> featureData, GeoJSONOptions<P> options) => default(Layer);
		public virtual LatLng coordsToLatLng(Union<object[], object[]> coords) => default(LatLng);
		public virtual object[] coordsToLatLngs(object[] coords, double levelsDeep, Func<Union<object[], object[]>, LatLng> coordsToLatLng) => default(object[]);
		public virtual Union<object[], object[]> latLngToCoords(LatLng latlng) => default(Union<object[], object[]>);
		public virtual object[] latLngsToCoords(object[] latlngs, double levelsDeep, bool closed) => default(object[]);
		public virtual geojson.Feature<geojson.GeometryObject, P> asFeature<P>(Union<geojson.Feature<geojson.GeometryObject, P>, geojson.GeometryObject> geojson) => default(geojson.Feature<geojson.GeometryObject, P>);
		public GeoJSON(geojson.GeoJsonObject geojson, GeoJSONOptions<P> options) { }
		public virtual Layer addData(geojson.GeoJsonObject data) => default(Layer);
		public virtual Layer resetStyle(Layer layer) => default(Layer);
		public virtual GeoJSON<P> setStyle(Union<PathOptions, StyleFunction<P>> style) => default(GeoJSON<P>);
		public GeoJSON() { }
	}
	public virtual GeoJSON<P> geoJSON<P>(geojson.GeoJsonObject geojson, GeoJSONOptions<P> options) => default(GeoJSON<P>);
	public class Zoom : Enumerated
	{
		public static string center = "center";
		public static implicit operator Zoom(bool value) { return new Zoom(value); }
		public static implicit operator Zoom(string value) { return new Zoom(value); }
		public Zoom(object value) { Value = value; }
	}
	public partial interface MapOptions
	{
		bool preferCanvas { get; set; }
		bool attributionControl { get; set; }
		bool zoomControl { get; set; }
		bool closePopupOnClick { get; set; }
		double zoomSnap { get; set; }
		double zoomDelta { get; set; }
		bool trackResize { get; set; }
		bool boxZoom { get; set; }
		Zoom doubleClickZoom { get; set; }
		bool dragging { get; set; }
		CRS crs { get; set; }
		LatLngExpression center { get; set; }
		double zoom { get; set; }
		double minZoom { get; set; }
		double maxZoom { get; set; }
		Layer[] layers { get; set; }
		LatLngBoundsExpression maxBounds { get; set; }
		Renderer renderer { get; set; }
		bool fadeAnimation { get; set; }
		bool markerZoomAnimation { get; set; }
		double transform3DLimit { get; set; }
		bool zoomAnimation { get; set; }
		double zoomAnimationThreshold { get; set; }
		bool inertia { get; set; }
		double inertiaDeceleration { get; set; }
		double inertiaMaxSpeed { get; set; }
		double easeLinearity { get; set; }
		bool worldCopyJump { get; set; }
		double maxBoundsViscosity { get; set; }
		bool keyboard { get; set; }
		double keyboardPanDelta { get; set; }
		Zoom scrollWheelZoom { get; set; }
		double wheelDebounceTime { get; set; }
		double wheelPxPerZoomLevel { get; set; }
		bool tap { get; set; }
		double tapTolerance { get; set; }
		Zoom touchZoom { get; set; }
		bool bounceAtZoomLimits { get; set; }
	}
	public class ControlPosition : Enumerated
	{
		public static string topleft = "topleft";
		public static string topright = "topright";
		public static string bottomleft = "bottomleft";
		public static string bottomright = "bottomright";
		public static implicit operator ControlPosition(string value) { return new ControlPosition(value); }
		public ControlPosition(object value) { Value = value; }
	}
	public partial interface ControlOptions
	{
		ControlPosition position { get; set; }
	}
	public partial class Control : Class
	{
		public partial interface ControlType_0<T>
		{
			T @new(object[] args);
		}
		public partial interface ZoomOptions : ControlOptions
		{
			string zoomInText { get; set; }
			string zoomInTitle { get; set; }
			string zoomOutText { get; set; }
			string zoomOutTitle { get; set; }
		}
		public partial class Zoom : Control
		{
			public virtual ZoomOptions options { get; set; }
			public Zoom(ZoomOptions options) { }
			public Zoom() { }
		}
		public partial interface AttributionOptions : ControlOptions
		{
			Union<string, bool> prefix { get; set; }
		}
		public partial class Attribution : Control
		{
			public virtual AttributionOptions options { get; set; }
			public Attribution(AttributionOptions options) { }
			public virtual Attribution setPrefix(string prefix) => default(Attribution);
			public virtual Attribution addAttribution(string text) => default(Attribution);
			public virtual Attribution removeAttribution(string text) => default(Attribution);
			public Attribution() { }
		}
		public partial interface LayersOptions : ControlOptions
		{
			bool collapsed { get; set; }
			bool autoZIndex { get; set; }
			bool hideSingleBase { get; set; }
		}
		public partial interface LayersObject
		{
			Layer this[string name] { get; set; }
		}
		public partial class Layers : Control
		{
			public virtual LayersOptions options { get; set; }
			public Layers(LayersObject baseLayers, LayersObject overlays, LayersOptions options) { }
			public virtual Layers addBaseLayer(Layer layer, string name) => default(Layers);
			public virtual Layers addOverlay(Layer layer, string name) => default(Layers);
			public virtual Layers removeLayer(Layer layer) => default(Layers);
			public virtual Layers expand() => default(Layers);
			public virtual Layers collapse() => default(Layers);
			public Layers() { }
		}
		public partial interface ScaleOptions : ControlOptions
		{
			double maxWidth { get; set; }
			bool metric { get; set; }
			bool imperial { get; set; }
			bool updateWhenIdle { get; set; }
		}
		public partial class Scale : Control
		{
			public virtual ScaleOptions options { get; set; }
			public Scale(ScaleOptions options) { }
			public Scale() { }
		}
		public virtual ControlOptions options { get; set; }
		public virtual Union<ControlType_0<T>, Control> extend<T>(T props) => default(Union<ControlType_0<T>, Control>);
		public Control(ControlOptions options) { }
		public virtual ControlPosition getPosition() => default(ControlPosition);
		public virtual Control setPosition(ControlPosition position) => default(Control);
		public virtual Union<HTMLElement, undefined> getContainer() => default(Union<HTMLElement, undefined>);
		public virtual Control addTo(Map map) => default(Control);
		public virtual Control remove() => default(Control);
		public virtual HTMLElement onAdd(Map map) => default(HTMLElement);
		public virtual void onRemove(Map map) { }
		public Control() { }
	}
	public partial class control
	{
		public virtual Control.Zoom zoom(Control.ZoomOptions options) => default(Control.Zoom);
		public virtual Control.Attribution attribution(Control.AttributionOptions options) => default(Control.Attribution);
		public virtual Control.Layers layers(Control.LayersObject baseLayers, Control.LayersObject overlays, Control.LayersOptions options) => default(Control.Layers);
		public virtual Control.Scale scale(Control.ScaleOptions options) => default(Control.Scale);
		public control() { }
	}
	public partial interface DivOverlayOptions
	{
		PointExpression offset { get; set; }
		bool zoomAnimation { get; set; }
		string className { get; set; }
		string pane { get; set; }
	}
	public abstract partial class DivOverlay : Layer
	{
		public virtual DivOverlayOptions options { get; set; }
		public DivOverlay(DivOverlayOptions options, Layer source) { }
		public virtual Union<LatLng, undefined> getLatLng() => default(Union<LatLng, undefined>);
		public virtual DivOverlay setLatLng(LatLngExpression latlng) => default(DivOverlay);
		public virtual Union<Content, Func<Layer, Content>, undefined> getContent() => default(Union<Content, Func<Layer, Content>, undefined>);
		public virtual DivOverlay setContent(Union<Func<Layer, Content>, Content> htmlContent) => default(DivOverlay);
		public virtual Union<HTMLElement, undefined> getElement() => default(Union<HTMLElement, undefined>);
		public virtual void update() { }
		public virtual bool isOpen() => default(bool);
		public virtual DivOverlay bringToFront() => default(DivOverlay);
		public virtual DivOverlay bringToBack() => default(DivOverlay);
		public DivOverlay() { }
	}
	public partial interface PopupOptions : DivOverlayOptions
	{
		double maxWidth { get; set; }
		double minWidth { get; set; }
		double maxHeight { get; set; }
		bool keepInView { get; set; }
		bool closeButton { get; set; }
		bool autoPan { get; set; }
		PointExpression autoPanPaddingTopLeft { get; set; }
		PointExpression autoPanPaddingBottomRight { get; set; }
		PointExpression autoPanPadding { get; set; }
		bool autoClose { get; set; }
		bool closeOnClick { get; set; }
		bool closeOnEscapeKey { get; set; }
	}
	public class Content : TypeAlias
	{
		public Content(Union<string, HTMLElement> value) { Value = value; }
		public static implicit operator Content(Union<string, HTMLElement> value) { return new Content(value); }
	}
	public partial class Popup : DivOverlay
	{
		public virtual PopupOptions options { get; set; }
		public Popup(PopupOptions options, Layer source) { }
		public virtual Popup openOn(Map map) => default(Popup);
		public Popup() { }
	}
	public virtual Popup popup(PopupOptions options, Layer source) => default(Popup);
	public class Direction : Enumerated
	{
		public static string right = "right";
		public static string left = "left";
		public static string top = "top";
		public static string bottom = "bottom";
		public static string center = "center";
		public static string auto = "auto";
		public static implicit operator Direction(string value) { return new Direction(value); }
		public Direction(object value) { Value = value; }
	}
	public partial interface TooltipOptions : DivOverlayOptions
	{
		string pane { get; set; }
		PointExpression offset { get; set; }
		Direction direction { get; set; }
		bool permanent { get; set; }
		bool sticky { get; set; }
		bool interactive { get; set; }
		double opacity { get; set; }
	}
	public partial class Tooltip : DivOverlay
	{
		public virtual TooltipOptions options { get; set; }
		public Tooltip(TooltipOptions options, Layer source) { }
		public virtual void setOpacity(double val) { }
		public Tooltip() { }
	}
	public virtual Tooltip tooltip(TooltipOptions options, Layer source) => default(Tooltip);
	public partial interface ZoomOptions
	{
		bool animate { get; set; }
	}
	public partial interface PanOptions
	{
		bool animate { get; set; }
		double duration { get; set; }
		double easeLinearity { get; set; }
		bool noMoveStart { get; set; }
	}
	public partial interface ZoomPanOptions : ZoomOptions, PanOptions
	{
	}
	public partial interface FitBoundsOptions : ZoomOptions, PanOptions
	{
		PointExpression paddingTopLeft { get; set; }
		PointExpression paddingBottomRight { get; set; }
		PointExpression padding { get; set; }
		double maxZoom { get; set; }
	}
	public partial interface PanInsideOptions
	{
		PointExpression paddingTopLeft { get; set; }
		PointExpression paddingBottomRight { get; set; }
		PointExpression padding { get; set; }
	}
	public partial interface LocateOptions
	{
		bool watch { get; set; }
		bool setView { get; set; }
		double maxZoom { get; set; }
		double timeout { get; set; }
		double maximumAge { get; set; }
		bool enableHighAccuracy { get; set; }
	}
	public partial class Handler : Class
	{
		public Handler(Map map) { }
		public virtual Handler enable() => default(Handler);
		public virtual Handler disable() => default(Handler);
		public virtual bool enabled() => default(bool);
		public virtual void addHooks() { }
		public virtual void removeHooks() { }
		public Handler() { }
	}
	public partial interface LeafletEvent
	{
		string type { get; set; }
		object target { get; set; }
		object sourceTarget { get; set; }
		object propagatedFrom { get; set; }
		object layer { get; set; }
	}
	public partial interface LeafletMouseEvent : LeafletEvent
	{
		LatLng latlng { get; set; }
		Point layerPoint { get; set; }
		Point containerPoint { get; set; }
		MouseEvent originalEvent { get; set; }
	}
	public partial interface LeafletKeyboardEvent : LeafletEvent
	{
		KeyboardEvent originalEvent { get; set; }
	}
	public partial interface LocationEvent : LeafletEvent
	{
		LatLng latlng { get; set; }
		LatLngBounds bounds { get; set; }
		double accuracy { get; set; }
		double altitude { get; set; }
		double altitudeAccuracy { get; set; }
		double heading { get; set; }
		double speed { get; set; }
		double timestamp { get; set; }
	}
	public partial interface ErrorEvent : LeafletEvent
	{
		string message { get; set; }
		double code { get; set; }
	}
	public partial interface LayerEvent : LeafletEvent
	{
		Layer layer { get; set; }
	}
	public partial interface LayersControlEvent : LayerEvent
	{
		string name { get; set; }
	}
	public partial interface TileEvent : LeafletEvent
	{
		HTMLImageElement tile { get; set; }
		Point coords { get; set; }
	}
	public partial interface TileErrorEvent : TileEvent
	{
		Error error { get; set; }
	}
	public partial interface ResizeEvent : LeafletEvent
	{
		Point oldSize { get; set; }
		Point newSize { get; set; }
	}
	public partial interface GeoJSONEvent : LeafletEvent
	{
		Layer layer { get; set; }
		object properties { get; set; }
		string geometryType { get; set; }
		string id { get; set; }
	}
	public partial interface PopupEvent : LeafletEvent
	{
		Popup popup { get; set; }
	}
	public partial interface TooltipEvent : LeafletEvent
	{
		Tooltip tooltip { get; set; }
	}
	public partial interface DragEndEvent : LeafletEvent
	{
		double distance { get; set; }
	}
	public partial interface ZoomAnimEvent : LeafletEvent
	{
		LatLng center { get; set; }
		double zoom { get; set; }
		bool noUpdate { get; set; }
	}
	public partial class DomEvent
	{
		public class EventHandlerFn : TypeAlias
		{
			public EventHandlerFn(Action<Event> value) { Value = value; }
			public static implicit operator EventHandlerFn(Action<Event> value) { return new EventHandlerFn(value); }
		}
		public class PropagableEvent : TypeAlias
		{
			public PropagableEvent(Union<LeafletMouseEvent, LeafletKeyboardEvent, LeafletEvent, Event> value) { Value = value; }
			public static implicit operator PropagableEvent(Union<LeafletMouseEvent, LeafletKeyboardEvent, LeafletEvent, Event> value) { return new PropagableEvent(value); }
		}
		public partial interface onType_0
		{
			EventHandlerFn this[string eventName] { get; set; }
		}
		public partial interface offType_0
		{
			EventHandlerFn this[string eventName] { get; set; }
		}
		public partial interface addListenerType_0
		{
			EventHandlerFn this[string eventName] { get; set; }
		}
		public partial interface removeListenerType_0
		{
			EventHandlerFn this[string eventName] { get; set; }
		}
		public virtual DomEvent on(HTMLElement el, string types, EventHandlerFn fn, object context) => default(DomEvent);
		public virtual DomEvent on(HTMLElement el, onType_0 eventMap, object context) => default(DomEvent);
		public virtual DomEvent off(HTMLElement el, string types, EventHandlerFn fn, object context) => default(DomEvent);
		public virtual DomEvent off(HTMLElement el, offType_0 eventMap, object context) => default(DomEvent);
		public virtual DomEvent stopPropagation(PropagableEvent ev) => default(DomEvent);
		public virtual DomEvent disableScrollPropagation(HTMLElement el) => default(DomEvent);
		public virtual DomEvent disableClickPropagation(HTMLElement el) => default(DomEvent);
		public virtual DomEvent preventDefault(Event ev) => default(DomEvent);
		public virtual DomEvent stop(PropagableEvent ev) => default(DomEvent);
		public virtual Point getMousePosition(MouseEvent ev, HTMLElement container) => default(Point);
		public virtual double getWheelDelta(Event ev) => default(double);
		public virtual DomEvent addListener(HTMLElement el, string types, EventHandlerFn fn, object context) => default(DomEvent);
		public virtual DomEvent addListener(HTMLElement el, addListenerType_0 eventMap, object context) => default(DomEvent);
		public virtual DomEvent removeListener(HTMLElement el, string types, EventHandlerFn fn, object context) => default(DomEvent);
		public virtual DomEvent removeListener(HTMLElement el, removeListenerType_0 eventMap, object context) => default(DomEvent);
		public DomEvent() { }
	}
	public partial interface DefaultMapPanes
	{
		HTMLElement mapPane { get; set; }
		HTMLElement tilePane { get; set; }
		HTMLElement overlayPane { get; set; }
		HTMLElement shadowPane { get; set; }
		HTMLElement markerPane { get; set; }
		HTMLElement tooltipPane { get; set; }
		HTMLElement popupPane { get; set; }
	}
	public partial class Map : Evented
	{
		public partial interface MapType_0
		{
			HTMLElement this[string name] { get; set; }
		}
		public virtual Leaflet.Control.Attribution attributionControl { get; set; }
		public virtual Handler boxZoom { get; set; }
		public virtual Handler doubleClickZoom { get; set; }
		public virtual Handler dragging { get; set; }
		public virtual Handler keyboard { get; set; }
		public virtual Handler scrollWheelZoom { get; set; }
		public virtual Handler tap { get; set; }
		public virtual Handler touchZoom { get; set; }
		public virtual Control.Zoom zoomControl { get; set; }
		public virtual MapOptions options { get; set; }
		public Map(Union<string, HTMLElement> element, MapOptions options) { }
		public virtual Renderer getRenderer(Path layer) => default(Renderer);
		public virtual Map addControl(Control control) => default(Map);
		public virtual Map removeControl(Control control) => default(Map);
		public virtual Map addLayer(Layer layer) => default(Map);
		public virtual Map removeLayer(Layer layer) => default(Map);
		public virtual bool hasLayer(Layer layer) => default(bool);
		public virtual Map eachLayer(Action<Layer> fn, object context) => default(Map);
		public virtual Map openPopup(Popup popup) => default(Map);
		public virtual Map openPopup(Content content, LatLngExpression latlng, PopupOptions options) => default(Map);
		public virtual Map closePopup(Popup popup) => default(Map);
		public virtual Map openTooltip(Tooltip tooltip) => default(Map);
		public virtual Map openTooltip(Content content, LatLngExpression latlng, TooltipOptions options) => default(Map);
		public virtual Map closeTooltip(Tooltip tooltip) => default(Map);
		public virtual Map setView(LatLngExpression center, double zoom, ZoomPanOptions options) => default(Map);
		public virtual Map setZoom(double zoom, ZoomPanOptions options) => default(Map);
		public virtual Map zoomIn(double delta, ZoomOptions options) => default(Map);
		public virtual Map zoomOut(double delta, ZoomOptions options) => default(Map);
		public virtual Map setZoomAround(Union<Point, LatLngExpression> position, double zoom, ZoomOptions options) => default(Map);
		public virtual Map fitBounds(LatLngBoundsExpression bounds, FitBoundsOptions options) => default(Map);
		public virtual Map fitWorld(FitBoundsOptions options) => default(Map);
		public virtual Map panTo(LatLngExpression latlng, PanOptions options) => default(Map);
		public virtual Map panBy(PointExpression offset, PanOptions options) => default(Map);
		public virtual Map setMaxBounds(LatLngBoundsExpression bounds) => default(Map);
		public virtual Map setMinZoom(double zoom) => default(Map);
		public virtual Map setMaxZoom(double zoom) => default(Map);
		public virtual Map panInside(LatLngExpression latLng, PanInsideOptions options) => default(Map);
		public virtual Map panInsideBounds(LatLngBoundsExpression bounds, PanOptions options) => default(Map);
		public virtual Map invalidateSize(Union<bool, ZoomPanOptions> options) => default(Map);
		public virtual Map stop() => default(Map);
		public virtual Map flyTo(LatLngExpression latlng, double zoom, ZoomPanOptions options) => default(Map);
		public virtual Map flyToBounds(LatLngBoundsExpression bounds, FitBoundsOptions options) => default(Map);
		public virtual Map addHandler(string name, Handler HandlerClass) => default(Map);
		public virtual Map remove() => default(Map);
		public virtual HTMLElement createPane(string name, HTMLElement container) => default(HTMLElement);
		public virtual Union<HTMLElement, undefined> getPane(Union<string, HTMLElement> pane) => default(Union<HTMLElement, undefined>);
		public virtual Union<MapType_0, DefaultMapPanes> getPanes() => default(Union<MapType_0, DefaultMapPanes>);
		public virtual HTMLElement getContainer() => default(HTMLElement);
		public virtual Map whenReady(Action fn, object context) => default(Map);
		public virtual LatLng getCenter() => default(LatLng);
		public virtual double getZoom() => default(double);
		public virtual LatLngBounds getBounds() => default(LatLngBounds);
		public virtual double getMinZoom() => default(double);
		public virtual double getMaxZoom() => default(double);
		public virtual double getBoundsZoom(LatLngBoundsExpression bounds, bool inside) => default(double);
		public virtual Point getSize() => default(Point);
		public virtual Bounds getPixelBounds() => default(Bounds);
		public virtual Point getPixelOrigin() => default(Point);
		public virtual Bounds getPixelWorldBounds(double zoom) => default(Bounds);
		public virtual double getZoomScale(double toZoom, double fromZoom) => default(double);
		public virtual double getScaleZoom(double scale, double fromZoom) => default(double);
		public virtual Point project(LatLngExpression latlng, double zoom) => default(Point);
		public virtual LatLng unproject(PointExpression point, double zoom) => default(LatLng);
		public virtual LatLng layerPointToLatLng(PointExpression point) => default(LatLng);
		public virtual Point latLngToLayerPoint(LatLngExpression latlng) => default(Point);
		public virtual LatLng wrapLatLng(LatLngExpression latlng) => default(LatLng);
		public virtual LatLngBounds wrapLatLngBounds(LatLngBounds bounds) => default(LatLngBounds);
		public virtual double distance(LatLngExpression latlng1, LatLngExpression latlng2) => default(double);
		public virtual Point containerPointToLayerPoint(PointExpression point) => default(Point);
		public virtual LatLng containerPointToLatLng(PointExpression point) => default(LatLng);
		public virtual Point layerPointToContainerPoint(PointExpression point) => default(Point);
		public virtual Point latLngToContainerPoint(LatLngExpression latlng) => default(Point);
		public virtual Point mouseEventToContainerPoint(MouseEvent ev) => default(Point);
		public virtual Point mouseEventToLayerPoint(MouseEvent ev) => default(Point);
		public virtual LatLng mouseEventToLatLng(MouseEvent ev) => default(LatLng);
		public virtual Map locate(LocateOptions options) => default(Map);
		public virtual Map stopLocate() => default(Map);
		public Map() { }
	}
	public virtual Map map(Union<string, HTMLElement> element, MapOptions options) => default(Map);
	public partial interface BaseIconOptions : LayerOptions
	{
		string iconUrl { get; set; }
		string iconRetinaUrl { get; set; }
		PointExpression iconSize { get; set; }
		PointExpression iconAnchor { get; set; }
		PointExpression popupAnchor { get; set; }
		PointExpression tooltipAnchor { get; set; }
		string shadowUrl { get; set; }
		string shadowRetinaUrl { get; set; }
		PointExpression shadowSize { get; set; }
		PointExpression shadowAnchor { get; set; }
		string className { get; set; }
	}
	public partial interface IconOptions : BaseIconOptions
	{
		string iconUrl { get; set; }
	}
	public partial class Icon<T> : Layer
	{
		public virtual T options { get; set; }
		public Icon(T options) { }
		public virtual HTMLElement createIcon(HTMLElement oldIcon) => default(HTMLElement);
		public virtual HTMLElement createShadow(HTMLElement oldIcon) => default(HTMLElement);
		public Icon() { }
	}
	public partial class NIcon
	{
		public partial interface DefaultIconOptions : BaseIconOptions
		{
			string imagePath { get; set; }
		}
		public partial class Default : Icon<DefaultIconOptions>
		{
			public virtual string imagePath { get; set; }
			public Default(DefaultIconOptions options) { }
			public Default() { }
		}
		public NIcon() { }
	}
	public virtual Icon icon(IconOptions options) => default(Icon);
	public partial interface DivIconOptions : BaseIconOptions
	{
		Union<string, HTMLElement, bool> html { get; set; }
		PointExpression bgPos { get; set; }
		PointExpression iconSize { get; set; }
		PointExpression iconAnchor { get; set; }
		PointExpression popupAnchor { get; set; }
		string className { get; set; }
	}
	public partial class DivIcon : Icon<DivIconOptions>
	{
		public DivIcon(DivIconOptions options) { }
		public DivIcon() { }
	}
	public virtual DivIcon divIcon(DivIconOptions options) => default(DivIcon);
	public partial interface MarkerOptions : InteractiveLayerOptions
	{
		Union<Icon, DivIcon> icon { get; set; }
		bool draggable { get; set; }
		bool keyboard { get; set; }
		string title { get; set; }
		string alt { get; set; }
		double zIndexOffset { get; set; }
		double opacity { get; set; }
		bool riseOnHover { get; set; }
		double riseOffset { get; set; }
		string shadowPane { get; set; }
		bool autoPan { get; set; }
		PointExpression autoPanPadding { get; set; }
		double autoPanSpeed { get; set; }
	}
	public partial class Marker<P> : Layer
	{
		public virtual MarkerOptions options { get; set; }
		public virtual Handler dragging { get; set; }
		public virtual geojson.Feature<geojson.Point, P> feature { get; set; }
		protected virtual Union<HTMLElement, undefined> _shadow { get; set; }
		public Marker(LatLngExpression latlng, MarkerOptions options) { }
		public virtual geojson.Feature<geojson.Point, P> toGeoJSON() => default(geojson.Feature<geojson.Point, P>);
		public virtual LatLng getLatLng() => default(LatLng);
		public virtual Marker<P> setLatLng(LatLngExpression latlng) => default(Marker<P>);
		public virtual Marker<P> setZIndexOffset(double offset) => default(Marker<P>);
		public virtual Union<Icon, DivIcon> getIcon() => default(Union<Icon, DivIcon>);
		public virtual Marker<P> setIcon(Union<Icon, DivIcon> icon) => default(Marker<P>);
		public virtual Marker<P> setOpacity(double opacity) => default(Marker<P>);
		public virtual Union<HTMLElement, undefined> getElement() => default(Union<HTMLElement, undefined>);
		public Marker() { }
	}
	public virtual Marker marker(LatLngExpression latlng, MarkerOptions options) => default(Marker);
	public partial class Browser
	{
		public virtual bool ie { get; set; }
		public virtual bool ielt9 { get; set; }
		public virtual bool edge { get; set; }
		public virtual bool webkit { get; set; }
		public virtual bool android { get; set; }
		public virtual bool android23 { get; set; }
		public virtual bool androidStock { get; set; }
		public virtual bool opera { get; set; }
		public virtual bool chrome { get; set; }
		public virtual bool gecko { get; set; }
		public virtual bool safari { get; set; }
		public virtual bool opera12 { get; set; }
		public virtual bool win { get; set; }
		public virtual bool ie3d { get; set; }
		public virtual bool webkit3d { get; set; }
		public virtual bool gecko3d { get; set; }
		public virtual bool any3d { get; set; }
		public virtual bool mobile { get; set; }
		public virtual bool mobileWebkit { get; set; }
		public virtual bool mobileWebkit3d { get; set; }
		public virtual bool msPointer { get; set; }
		public virtual bool pointer { get; set; }
		public virtual bool touch { get; set; }
		public virtual bool mobileOpera { get; set; }
		public virtual bool mobileGecko { get; set; }
		public virtual bool retina { get; set; }
		public virtual bool canvas { get; set; }
		public virtual bool svg { get; set; }
		public virtual bool vml { get; set; }
		public Browser() { }
	}
	public partial class Util
	{
		public virtual double lastId { get; set; }
		public virtual string emptyImageUrl { get; set; }
		public virtual Union<D, S1> extend<D, S1>(D dest, S1 src) => default(Union<D, S1>);
		public virtual Union<D, S1, S2> extend<D, S1, S2>(D dest, S1 src1, S2 src2) => default(Union<D, S1, S2>);
		public virtual Union<D, S1, S2, S3> extend<D, S1, S2, S3>(D dest, S1 src1, S2 src2, S3 src3) => default(Union<D, S1, S2, S3>);
		public virtual object extend(object dest, object[] src) => default(object);
		public virtual object create(Union<object, object> proto, PropertyDescriptorMap properties) => default(object);
		public virtual Action bind(Action fn, object[] obj) => default(Action);
		public virtual double stamp(object obj) => default(double);
		public virtual Action throttle(Action fn, double time, object context) => default(Action);
		public virtual double wrapNum(double num, double[] range, bool includeMax) => default(double);
		public virtual bool falseFn() => default(bool);
		public virtual double formatNum(double num, double digits) => default(double);
		public virtual string trim(string str) => default(string);
		public virtual string[] splitWords(string str) => default(string[]);
		public virtual object setOptions(object obj, object options) => default(object);
		public virtual string getParamString(object obj, string existingUrl, bool uppercase) => default(string);
		public virtual string template(string str, object data) => default(string);
		public virtual bool isArray(object obj) => default(bool);
		public virtual double indexOf(object[] array, object el) => default(double);
		public virtual double requestAnimFrame(Action<double> fn, object context, bool immediate) => default(double);
		public virtual void cancelAnimFrame(double id) { }
		public Util() { }
	}
	public partial class Polyline : Polyline<geojson.GeometryObject, object>
	{
		public Polyline(Union<LatLngExpression[], LatLngExpression[][]> latlngs, PolylineOptions options) { }
	}
	public partial class Polygon : Polygon<object>
	{
		public Polygon(Union<LatLngExpression[], LatLngExpression[][], LatLngExpression[][][]> latlngs, PolylineOptions options) { }
	}
	public partial class Rectangle : Rectangle<object>
	{
		public Rectangle(LatLngBoundsExpression latLngBounds, PolylineOptions options) { }
	}
	public partial class CircleMarker : CircleMarker<object>
	{
		public CircleMarker(LatLngExpression latlng, CircleMarkerOptions options) { }
	}
	public partial class Circle : Circle<object>
	{
		public Circle(LatLngExpression latlng, CircleMarkerOptions options) { }
		public Circle(LatLngExpression latlng, double radius, CircleMarkerOptions options) { }
	}
	public partial class LayerGroup : LayerGroup<object>
	{
		public LayerGroup(Layer[] layers, LayerOptions options) { }
	}
	public partial class FeatureGroup : FeatureGroup<object>
	{
	}
	public partial class GeoJSON : GeoJSON<object>
	{
		public GeoJSON(geojson.GeoJsonObject geojson, GeoJSONOptions<object> options) { }
	}
	public partial class Icon : Icon<BaseIconOptions>
	{
		public Icon(BaseIconOptions options) { }
	}
	public partial class Marker : Marker<object>
	{
		public Marker(LatLngExpression latlng, MarkerOptions options) { }
	}
}

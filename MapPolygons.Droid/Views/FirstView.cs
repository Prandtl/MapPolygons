using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Graphics;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;

namespace MapPolygons.Droid.Views
{
	[Activity(Label = "View for FirstViewModel")]
	public class FirstView : MvxActivity, IOnMapReadyCallback
	{
		private GoogleMap _map;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.FirstView);
			var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
			mapFragment.GetMapAsync(this);
		}

		public void OnMapReady(GoogleMap googleMap)
		{
			_map = googleMap;

			// Instantiates a new Polygon object and adds points to define a rectangle
			var rectOptions = new PolygonOptions()
						  .Add(new LatLng(9,10),
							   new LatLng(10, 11),
							   new LatLng(11, 10),
							   new LatLng(10, 9));
			rectOptions.InvokeFillColor(0x66FF0000);
			rectOptions.InvokeStrokeColor(0x660000FF);

			// Get back the mutable Polygon
			var polygon = _map.AddPolygon(rectOptions);
		}
	}
}

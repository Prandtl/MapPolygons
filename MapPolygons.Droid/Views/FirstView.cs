using Android.App;
using Android.Gms.Maps;
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
		}
	}
}

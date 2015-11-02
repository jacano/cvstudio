using Android.App;
using Android.OS;
using Android.Widget;
using CvStudio.Core.Models;
using Square.Picasso;

namespace CvStudio.Fragments
{
    public class CvDetailFragment : BaseFragment
    {
        private Cv _cv;

        public CvDetailFragment(Cv cv)
        {
            _cv = cv;
        }

        protected override int LayoutResource => Resource.Layout.CvDetailView;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var profileImage = view.FindViewById<ImageView>(Resource.Id.ProfileImage);
            var profileName = view.FindViewById<TextView>(Resource.Id.ProfileName);

            Picasso.With(Activity)
               .Load(_cv.PhotoUrl)
               .Placeholder(Resource.Drawable.placeholderuser)
               .Into(profileImage);

            profileName.Text = _cv.Name;

            return view;
        }
    }
}
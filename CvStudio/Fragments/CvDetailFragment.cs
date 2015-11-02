using Android.App;
using Android.OS;
using CvStudio.Core.Models;

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

            return view;
        }
    }
}
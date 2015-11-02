using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;


namespace CvStudio.Fragments
{
    public abstract class BaseFragment : Fragment
    {
        protected BaseFragment()
        {
            RetainInstance = true;
            HasOptionsMenu = true;
        }

        public override View OnCreateView(LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            var view = inflater.Inflate(LayoutResource, null);

            return view;
        }

        protected abstract int LayoutResource
        {
            get;
        }
    }
}
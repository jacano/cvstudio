using Android.App;
using Android.OS;
using Android.Widget;
using Autofac;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Fragments
{
    public class ResetCvFragment : BaseFragment
    {
        private Button _addCvButton;

        protected override int LayoutResource => Resource.Layout.ResetCvView;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _addCvButton = view.FindViewById<Button>(Resource.Id.ResetButton);

            _addCvButton.Click += (sender, args) =>
            {
                var cvStudioApp = (CvStudioApplication)Activity.Application;
                var cvService = cvStudioApp.Container.Resolve<ICvService>();
                var toastService = cvStudioApp.Container.Resolve<IToastService>();

                cvService.Reset();
                toastService.ShowToast(Resources.GetString(Resource.String.ResetCvView_Done)); 
            };

            return view;
        }
    }
}
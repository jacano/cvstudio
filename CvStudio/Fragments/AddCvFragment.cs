using Android.App;
using Android.OS;
using Android.Widget;
using Autofac;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Fragments
{
    public class AddCvFragment : BaseFragment
    {
        private EditText _cvLinkEditText;
        private Button _addCvButton;

        protected override int LayoutResource => Resource.Layout.AddCvView;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _cvLinkEditText = view.FindViewById<EditText>(Resource.Id.CvLink);
            _addCvButton = view.FindViewById<Button>(Resource.Id.AddCvButton);

            _addCvButton.Click += async (sender, args) =>
            {
                var cvStudioApp = (CvStudioApplication)Activity.Application;
                var cvService = cvStudioApp.Container.Resolve<ICvService>();
                var toastService = cvStudioApp.Container.Resolve<IToastService>();

                var link = _cvLinkEditText.Text;

                cvService.Initialize();
                var added = await cvService.AddCv(link);

                if (added)
                {
                    toastService.ShowToast(Resources.GetString(Resource.String.AddCvView_Added));
                }
                else
                {
                    toastService.ShowToast(Resources.GetString(Resource.String.AddCvView_Error));
                }
            };

            return view;
        }
    }
}
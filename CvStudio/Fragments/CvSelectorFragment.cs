using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Widget;
using Autofac;
using CvStudio.Activities;
using CvStudio.Adapters;
using CvStudio.Core.Models;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Fragments
{
    public class CvSelectorFragment : BaseFragment
    {
        private ListView _cvList;
           
        protected override int LayoutResource => Resource.Layout.CvSelectorView;

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _cvList = view.FindViewById<ListView>(Resource.Id.CvList);

            InitializeCvList();

            return view;
        }

        private async void InitializeCvList()
        {
            var cvStudioApp = (CvStudioApplication)Activity.Application;
            var cvService = cvStudioApp.Container.Resolve<ICvService>();

            cvService.Initialize();
            var cvs = await cvService.GetAllCvs();

            var enumerable = cvs as IList<Cv> ?? cvs.ToList();
            _cvList.Adapter = new CvAdapter(Activity, enumerable);

            _cvList.ItemClick += (sender, args) =>
            {
                var cv = enumerable.ElementAt(args.Position);

                var mainActivity = (MainActivity) Activity;
                mainActivity.NavigateToFragment(new CvDetailFragment(cv));
            };
        }
    }
}
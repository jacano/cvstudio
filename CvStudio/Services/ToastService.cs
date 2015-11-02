using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Services
{
    public class ToastService : IToastService
    {
        private readonly IAppService _applicationService;

        public ToastService(IAppService applicationService)
        {
            _applicationService = applicationService;
        }

        public void ShowToast(string msg)
        {
            var application = (Application)_applicationService.GetApp();

            Toast.MakeText(application, msg, ToastLength.Short).Show();
        }
    }
}
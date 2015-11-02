using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CvStudio.Core.Services.Interfaces;
using CvStudio.Activities;

namespace CvStudio.Services
{
    public class AppService : IAppService
    {
        private readonly Application _application;

        public AppService(Application application)
        {
            _application = application;
        }

        public string GetAppName()
        {
            var appName =_application.ApplicationInfo.LoadLabel(_application.PackageManager);

            return appName;
        }
    }
}
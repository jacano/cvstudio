using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using CvStudio.Core.Services;
using CvStudio.Core.Services.Interfaces;
using CvStudio.Services;

namespace CvStudio
{
    [Application(Label = "@string/ApplicationName", Icon = "@drawable/Icon")]
    public class CvStudioApplication : Application
    {
        public IContainer Container { get; private set; }

        public CvStudioApplication(IntPtr javaReference, JniHandleOwnership transfer)
           : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();

            var builder = new ContainerBuilder();

            builder.RegisterInstance<IAppService>(new AppService(this));

            builder.RegisterType<CvService>().As<ICvService>();
            //builder.RegisterType<FakeCvService>().As<ICvService>();
            builder.RegisterType<LogService>().As<ILogService>();
            builder.RegisterType<JsonSerializerService>().As<ISerializationService>();
            builder.RegisterType<FileService>().As<IFileService>();
            builder.RegisterType<ToastService>().As<IToastService>();
            builder.RegisterType<HttpService>().As<IHttpService>();

            Container = builder.Build();
        }
    }
}
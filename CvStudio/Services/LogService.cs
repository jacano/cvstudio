using System;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Services
{
    public class LogService : ILogService
    {
        private readonly IAppService _navigationService;

        public LogService(IAppService navigationService)
        {
            _navigationService = navigationService;
        }

        public void LogInfo(string msg)
        {
            var appName = _navigationService.GetAppName();
            Android.Util.Log.Info(appName, msg);
        }

        public void LogException(Exception ex)
        {
            var appName = _navigationService.GetAppName();
            Android.Util.Log.Error(appName, ex.ToString());
        }
    }
}
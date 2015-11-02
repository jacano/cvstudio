using System;
using System.Threading.Tasks;
using CvStudio.Core.Services.Interfaces;
using Square.OkHttp;

namespace CvStudio.Services
{
    public class HttpService : IHttpService
    {
        private readonly ILogService _logService;

        public HttpService(ILogService logService)
        {
            _logService = logService;
        }

        public async Task<string> GetRequest(string url)
        {
            string result = null;

            var client = new OkHttpClient();
            var request = new Request.Builder()
                .Url(url)
                .Build();

            try
            {
                var response = await client.NewCall(request).ExecuteAsync();
                var body = response.Body().String();

                result = body;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }

            return result;
        }
    }
}

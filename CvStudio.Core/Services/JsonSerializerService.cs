using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CvStudio.Core.Services.Interfaces;
using Newtonsoft.Json;

namespace CvStudio.Core.Services
{
    public class JsonSerializerService : ISerializationService
    {
        private readonly ILogService _logService;

        public JsonSerializerService(ILogService logService)
        {
            _logService = logService;
        }

        public Task<string> Serialize<T>(T obj)
        {
            string result = null;

            try
            {
                var data = JsonConvert.SerializeObject(obj);
                result = data;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }

            return Task.FromResult(result);
        }

        public Task<T> Deserialize<T>(string data)
        {
            var result = default(T);

            try
            {
                var obj = JsonConvert.DeserializeObject<T>(data);
                result = obj;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }

            return Task.FromResult(result);
        }
    }
}

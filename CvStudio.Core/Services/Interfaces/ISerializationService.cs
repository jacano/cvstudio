using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvStudio.Core.Services.Interfaces
{
    public interface ISerializationService
    {
        Task<string> Serialize<T>(T obj);

        Task<T> Deserialize<T>(string data);
    }
}

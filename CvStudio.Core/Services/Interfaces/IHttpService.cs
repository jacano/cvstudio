using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvStudio.Core.Services.Interfaces
{
    public interface IHttpService
    {
        Task<string> GetRequest(string url);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using CvStudio.Core.Models;

namespace CvStudio.Core.Services.Interfaces
{
    public interface ICvService
    {
        Task<IEnumerable<Cv>> GetAllCvs();

        Task<bool> AddCv(string cvLink);

        void Initialize();

        void Reset();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CvStudio.Core.Models;
using CvStudio.Core.Services.Interfaces;

namespace CvStudio.Core.Services
{
    public class CvService : ICvService
    {
        private const string Cvstoragefolder = "CVS";

        private readonly IHttpService _httpService;
        private readonly ISerializationService _serializationService;
        private readonly IFileService _fileService;

        public CvService(IHttpService httpService, ISerializationService serializationService, IFileService fileService)
        {
            _httpService = httpService;
            _serializationService = serializationService;
            _fileService = fileService;
        }

        public void Initialize()
        {
            _fileService.CreateFolder(Cvstoragefolder);
        }

        public void Reset()
        {
            _fileService.RemoveFolder(Cvstoragefolder);
        }

        public async Task<IEnumerable<Cv>> GetAllCvs()
        {
            var result = new List<Cv>();
            
            var cvsInFiles = _fileService.EnumerateFilesInFolder(Cvstoragefolder);
            foreach (var cvFile in cvsInFiles)
            {
                var cvContentPath = _fileService.Combine(Cvstoragefolder, cvFile);
                var cvContent = _fileService.GetFileContent(cvContentPath);
                if (cvContent != null)
                {
                    var cv = await _serializationService.Deserialize<Cv>(cvContent);
                    if (cv != null)
                    {
                        result.Add(cv);
                    }
                }
            }
            
            return result;
        }

        public async Task<bool> AddCv(string cvLink)
        {
            var result = false;

            var cvContent = await _httpService.GetRequest(cvLink);
            if (cvContent != null)
            {
                var cv = await _serializationService.Deserialize<Cv>(cvContent);
                if (cv != null)
                {
                    var cvId = cv.Id.ToString();

                    var cvsInFiles = _fileService.EnumerateFilesInFolder(Cvstoragefolder);
                    var cvAlreadyExists = cvsInFiles.Any(c => c == cvId);
                    if (!cvAlreadyExists)
                    {
                        var cvPath = _fileService.Combine(Cvstoragefolder, cvId);

                        result = _fileService.WriteFile(cvPath, cvContent);
                    }
                }
            }

            return result;
        }
    }
}

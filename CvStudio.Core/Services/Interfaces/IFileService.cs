using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvStudio.Core.Services.Interfaces
{
    public interface IFileService
    {
        void CreateFolder(string folderName);

        void RemoveFolder(string folderName);

        IEnumerable<string> EnumerateFilesInFolder(string path);

        string GetFileContent(string path);

        bool WriteFile(string path, string fileContent);

        string Combine(string path1, string path2);
    }
}

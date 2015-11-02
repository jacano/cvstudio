using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CvStudio.Core.Services.Interfaces;
using Environment = System.Environment;

namespace CvStudio.Services
{
    public class FileService : IFileService
    {
        private readonly ILogService _logService;

        public FileService(ILogService logService)
        {
            _logService = logService;
        }

        public void CreateFolder(string folderName)
        {
            var folderPath = GetFilePath(folderName);

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }
        }

        public void RemoveFolder(string folderName)
        {
            var folderPath = GetFilePath(folderName);

            try
            {
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                }
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }
        }

        public IEnumerable<string> EnumerateFilesInFolder(string path)
        {
            var result = Enumerable.Empty<string>();

            var filePath = GetFilePath(path);

            try
            {
                var files = Directory.EnumerateFiles(filePath).Select(p => Path.GetFileName(p)).ToList();
                result = files;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }
            
            return result;
        }

        public string GetFileContent(string path)
        {
            string result = null;

            var filePath = GetFilePath(path);

            try
            {
                var content = File.ReadAllText(filePath);
                result = content;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }
            
            return result;
        }

        public bool WriteFile(string path, string fileContent)
        {
            var result = false;

            var filePath = GetFilePath(path);

            try
            {
                File.WriteAllText(filePath, fileContent);
                result = true;
            }
            catch (Exception ex)
            {
                _logService.LogException(ex);
            }

            return result;
        }

        public string Combine(string path1, string path2)
        {
            var finalPath = Path.Combine(path1, path2);

            return finalPath;
        }

        private string GetFilePath(string path)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var finalPath = Combine(documentsPath, path);

            return finalPath;
        }
    }
}
using Core.Utilities.Helpers.GuidHelpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelpers
{
    public class FileHelperManager : IFileHelperService
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile formFile, string root, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(formFile, root);
        }

        public string Upload(IFormFile formFile, string root)
        {
            if (formFile != null)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string fileExtension = Path.GetExtension(formFile.FileName);
                string guid = GuidHelper.CreateGuid();
                string filePath = guid + fileExtension;

                using (var fileStream = File.Create(root + filePath))
                {
                    formFile.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }
            return null;
        }
    }
}

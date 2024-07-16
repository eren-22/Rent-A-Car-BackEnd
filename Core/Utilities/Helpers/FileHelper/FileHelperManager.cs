using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath)) // parametrede belirtilen dosyanın olup olmadığı kontrol ediliyor.
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root); // Eski dosya silindikten sonra "Upload" metodunda belirtilen yeni dosya ve root döndürülür.
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string existsion = Path.GetExtension(file.FileName);  // Dosya uzantısı alınıyor.
                string guid = GuidHelper.GuidHelper.CreateGuid();  // Benzersiz bir GUID oluşturuluyor.
                string filePath = guid + existsion;  // Dosya yolu GUID ve uzantı ile oluşturuluyor.

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);  // Dosya içeriği yeni dosyaya kopyalanıyor.
                    fileStream.Flush();  // FileStream temizleniyor.
                    return filePath;
                }
            }
            return null;
        }
    }
}

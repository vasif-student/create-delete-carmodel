using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Areas.Admin.Utilis
{
    public class FileUtil
    {
        public static string CreatedFile(string folderPath, IFormFile file)
        {
            string fileName = Guid.NewGuid() + file.FileName;

            var path = Path.Combine(folderPath, fileName);
            FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();
            return fileName;
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}

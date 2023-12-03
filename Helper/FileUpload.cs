using Microsoft.AspNetCore.Http;

using System;
using System.IO;

namespace Helper
{
    public class FileUpload
    {
        public static string UploadFile(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return "/images/" + fileName;
            }
            return null;
        }
    }
}

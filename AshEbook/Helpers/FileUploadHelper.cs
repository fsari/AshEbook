using System;
using System.IO;
using System.Web;

namespace AshEbook.Helpers
{
    public static class FileUploadHelper
    {
        public static string UploadFile(HttpPostedFileBase file, string path)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileInfo = new FileInfo(file.FileName);
                var fileName = Guid.NewGuid() + fileInfo.Extension;
                var uploadPath = Path.Combine(path, fileName);

                file.SaveAs(uploadPath);
                return fileName;
            }

            return null;
        } 
    }
}
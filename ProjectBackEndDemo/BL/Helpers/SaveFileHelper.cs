using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Helpers
{
    public class SaveFileHelper
    {


        public static string SaveProfilePicture(string userId ,IFormFile Pic)
        {
            string FilePath = Directory.GetCurrentDirectory() + "/wwwroot/Files/UsersProfilePictures";
            string FileName = userId + Pic.FileName;

            string FinalPath = Path.Combine(FilePath, FileName);


            using (var stream = new FileStream(FinalPath, FileMode.Create))
            {
              Pic.CopyTo(stream);
            }

            return FileName;
        }

        public static string SaveFile(string folder, IFormFile Pic)
        {
            string FilePath = Directory.GetCurrentDirectory() + "/wwwroot/Files/" + folder;
            string FileName =  Guid.NewGuid().ToString() + Pic.FileName;

            string FinalPath = Path.Combine(FilePath, FileName);


            using (var stream = new FileStream(FinalPath, FileMode.Create))
            {
                Pic.CopyTo(stream);
            }

            return FileName;

        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.API
{
    public class PictureService
    {
        public Picture createPicture(string path)
        {
            char[] separator = { '\\' };
            Picture picture = new Picture();
            picture.path = path;
            picture.deleted = false;
            picture.full_name = path.Split(separator)[path.Split(separator).Length - 1];
            picture.created_at = DateTime.Now;
            return picture;
        }

        public void deletePicture(String path)
        {
            using (Model1Container context = new Model1Container())
            {
                context.Picture.Single(a => a.path == path).deleted = true;
                context.SaveChanges();
            }
        }
    }
}

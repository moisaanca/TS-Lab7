using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class InformationsDTO
    {
        public int Id { get; set; }

        public string description { get; set; }

        public virtual TagsDTO tag_id { get; set; }

        public virtual PictureDTO picture_id { get; set; }
    }
}

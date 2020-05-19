using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PictureDTO
    {

            public int Id { get; set; }

            public string full_name { get; set; }

            public string path { get; set; }

            public System.DateTime created_at { get; set; }

            public bool deleted { get; set; }
    }
}

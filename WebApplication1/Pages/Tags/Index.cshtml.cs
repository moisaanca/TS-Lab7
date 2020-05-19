using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using WebApplication1.Models;

namespace WebApplication1.Pages.Tags
{
    public class IndexModel : PageModel
    {
        Service1Client service1Client = new Service1Client();
        public List<TagsDTO> Tags { get; set; }

        public IndexModel()
        {
            Tags = new List<TagsDTO>();
        }
        public async Task OnGetAsync()
        {
            var posts = await service1Client.getTagsAsync();
            foreach (var item in posts)
            {
                TagsDTO tag = new TagsDTO();
                tag.name = item;
                Tags.Add(tag);
            }
        }

    }
}
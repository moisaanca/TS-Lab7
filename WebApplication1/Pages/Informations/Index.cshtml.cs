using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference2;
using WebApplication1.Models;

namespace WebApplication1.Pages.Informations
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        Service1Client service1Client = new Service1Client();
        public List<TagsDTO> Tags { get; set; }
        public List<InformationsDTO> Informations { get; set; } = new List<InformationsDTO>();

        public IndexModel()
        {
            Tags = new List<TagsDTO>();
        }
        public async Task OnGetAsync()
        {
            var posts = await service1Client.getTagsAsync();
            posts.Sort();
            foreach (var item in posts)
            {
                TagsDTO tag = new TagsDTO();
                tag.name = item;
                Tags.Add(tag);
            }

        }

        public IActionResult OnPost()
        {

            if (string.IsNullOrEmpty(SearchString))
            {
                return Page();
            }
            return RedirectToPage($"./Filter", new { name = SearchString });
        }
    }
}
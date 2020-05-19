using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;
using WebApplication1.Models;

namespace WebApplication1.Pages.Pictures
{
    public class IndexModel : PageModel
    {
        Service1Client service1Client = new Service1Client();
        public List<PictureDTO> Pictures { get; set; }

        public IndexModel()
        {
            Pictures = new List<PictureDTO>();
        }
        public async Task OnGetAsync()
        {

            // Check what methods need to be implemented so we can display all the information for the summary


           /* var posts = await service1Client.();
            foreach (var item in posts)
            {
                
                PostDTO pd = new PostDTO();
                pd.Description = item.Description;
                pd.PostId = item.PostId;
                pd.Domain = item.Domain;
                pd.Date = item.Date;
                foreach (var cc in item.Comments)
                {
                    CommentDTO cdto = new CommentDTO();
                    cdto.PostPostId = cc.PostPostId;
                    cdto.Text = cc.Text;
                    pd.Comments.Add(cdto);
                }
                Posts.Add(pd);*/
            }
        }
    }
}
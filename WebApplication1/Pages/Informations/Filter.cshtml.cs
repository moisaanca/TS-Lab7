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
    public class FilterModel : PageModel
    {
        public List<InformationsDTO> Informations { get; set; } = new List<InformationsDTO>();
        Service1Client service1Client = new Service1Client();

        public async Task<IActionResult> OnGetAsync(string name)
        {

            if (name == null)
            {
                return NotFound();
            }
            List<ServiceReference2.Informations> infos = await service1Client.GetPicturesByTagMetodAsync(name, null);
            foreach (ServiceReference2.Informations info in infos)
            {
                TagsDTO tagInfo = new TagsDTO();
                tagInfo.Id = info.tag_id.Id;
                tagInfo.name = info.tag_id.name;
                //mapperTag.Map<WindowsFormsApp1.Tags, Tags>(info.tag_id);
                PictureDTO pictureInfo = new PictureDTO();
                pictureInfo.created_at = info.picture_id.created_at;
                pictureInfo.deleted = info.picture_id.deleted;
                pictureInfo.full_name = info.picture_id.full_name;
                pictureInfo.Id = info.picture_id.Id;
                pictureInfo.path = info.picture_id.path.Replace("\\", "/");
                //mapperTag.Map<WindowsFormsApp1.Picture, Picture>(info.picture_id);
                InformationsDTO informations = new InformationsDTO();
                informations.description = info.description;
                informations.Id = info.Id;
                informations.picture_id = pictureInfo;
                informations.tag_id = tagInfo;
                //mapperInfo.Map<Informations, InformationsDTO>(info);

                Informations.Add(informations);
            }


            if (Informations == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WindowsFormsApp1.API;

namespace ClassLibrary1
{
    public class PictureTagsInformations : InterfacePictureTagsInformations
    {
        Picture InterfacePicture.createPicture(string path)
        {
            PictureService pictureService = new PictureService();
            return pictureService.createPicture(path);
        }

        Tags InterfaceTags.createTags(string name)
        {
            TagsService tagsService = new TagsService();
            return tagsService.createTags(name);
        }

        void InterfacePicture.deletePicture(string path)
        {
            PictureService pictureService = new PictureService();
            pictureService.deletePicture(path);
        }

        Informations InterfaceInformations.saveInformations(string path, string tag, string value)
        {
            InformationsService informationsService = new InformationsService();
            return informationsService.saveInformations(path, tag, value);
        }

        List<string> InterfaceInformations.displaySearchResults(string description, string tag)
        {
            InformationsService informationsService = new InformationsService();
            return informationsService.displaySearchResults(description, tag);
        }

        List<string> InterfaceTags.getTags()
        {
            TagsService tagsService = new TagsService();
            return tagsService.getTags();
        }

        Tags InterfaceTags.saveTag(string name)
        {
            TagsService tagsService = new TagsService();
            return tagsService.saveTag(name);
        }
    }
}

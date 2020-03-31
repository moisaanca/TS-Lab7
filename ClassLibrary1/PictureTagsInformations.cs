using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ClassLibrary1
{
    public class PictureTagsInformations : InterfacePictureTagsInformations
    {
        Picture InterfacePicture.createPicture(string path)
        {
            throw new NotImplementedException();
        }

        Tags InterfaceTags.createTags(string name)
        {
            throw new NotImplementedException();
        }

        void InterfacePicture.deletePicture(string path)
        {
            throw new NotImplementedException();
        }

        Informations InterfaceInformations.saveInformations(string path, string tag, string value)
        {
            throw new NotImplementedException();
        }

        List<string> InterfaceInformations.displaySearchResults(string description, string tag)
        {
            throw new NotImplementedException();
        }

        List<string> InterfaceTags.getTags()
        {
            throw new NotImplementedException();
        }

        Tags InterfaceTags.saveTag(string name)
        {
            throw new NotImplementedException();
        }
    }
}

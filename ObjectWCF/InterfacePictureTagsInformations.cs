using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [ServiceContract]
    interface InterfacePictureTagsInformations: InterfaceInformations, InterfacePicture, InterfaceTags
    {
    }
}

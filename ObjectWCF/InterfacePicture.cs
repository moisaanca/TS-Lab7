using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ClassLibrary1
{
    [ServiceContract]
    interface InterfacePicture
    {
        [OperationContract]
        Picture createPicture(string path);

        [OperationContract]
        void deletePicture(String path);
    }
}

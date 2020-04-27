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
    interface InterfaceInformations
    {
        [OperationContract]
        Informations saveInformations(string path, String tag, String value);

        [OperationContract]
        List<String> displaySearchResults(String description, String tag);
    }
}

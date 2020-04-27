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
    interface InterfaceTags
    {
        [OperationContract]
        Tags createTags(string name);

        [OperationContract]
        List<String> getTags();

        [OperationContract]
        Tags saveTag(String name);
    }
}

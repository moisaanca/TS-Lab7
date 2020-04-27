using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WindowsFormsApp1;

namespace InformationsTagsPictures
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Informations saveInformations(string path, String tag, String value);

        [OperationContract]
        List<String> displaySearchResults(String description, String tag);

        [OperationContract]
        Picture createPicture(string path);

        [OperationContract]
        void deletePicture(String path);

        [OperationContract]
        Tags createTags(string name);

        [OperationContract]
        List<String> getTags();

        [OperationContract]
        Tags saveTag(String name);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "InformationsTagsPictures.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract(IsReference = true)]
    public partial class Picture
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string full_name { get; set; }
        [DataMember]
        public string path { get; set; }
        [DataMember]
        public System.DateTime created_at { get; set; }
        [DataMember]
        public bool deleted { get; set; }
    }

    [DataContract(IsReference = true)]
    public partial class Tags
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string name { get; set; }
    }

    [DataContract(IsReference = true)]
    public partial class Informations
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public virtual Tags tag_id { get; set; }
        [DataMember]
        public virtual Picture picture_id { get; set; }
    }
}

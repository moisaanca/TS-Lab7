﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/InformationsTagsPictures")]
    public partial class CompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Informations", Namespace="http://schemas.datacontract.org/2004/07/InformationsTagsPictures", IsReference=true)]
    public partial class Informations : object
    {
        
        private int IdField;
        
        private string descriptionField;
        
        private ServiceReference2.Picture picture_idField;
        
        private ServiceReference2.Tags tag_idField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.Picture picture_id
        {
            get
            {
                return this.picture_idField;
            }
            set
            {
                this.picture_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.Tags tag_id
        {
            get
            {
                return this.tag_idField;
            }
            set
            {
                this.tag_idField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Picture", Namespace="http://schemas.datacontract.org/2004/07/InformationsTagsPictures", IsReference=true)]
    public partial class Picture : object
    {
        
        private int IdField;
        
        private System.DateTime created_atField;
        
        private bool deletedField;
        
        private string full_nameField;
        
        private string pathField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime created_at
        {
            get
            {
                return this.created_atField;
            }
            set
            {
                this.created_atField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool deleted
        {
            get
            {
                return this.deletedField;
            }
            set
            {
                this.deletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string full_name
        {
            get
            {
                return this.full_nameField;
            }
            set
            {
                this.full_nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tags", Namespace="http://schemas.datacontract.org/2004/07/InformationsTagsPictures", IsReference=true)]
    public partial class Tags : object
    {
        
        private int IdField;
        
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceReference2.CompositeType> GetDataUsingDataContractAsync(ServiceReference2.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveInformations", ReplyAction="http://tempuri.org/IService1/saveInformationsResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Informations> saveInformationsAsync(string path, string tag, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/displaySearchResults", ReplyAction="http://tempuri.org/IService1/displaySearchResultsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> displaySearchResultsAsync(string description, string tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createPicture", ReplyAction="http://tempuri.org/IService1/createPictureResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Picture> createPictureAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePicture", ReplyAction="http://tempuri.org/IService1/deletePictureResponse")]
        System.Threading.Tasks.Task deletePictureAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createTags", ReplyAction="http://tempuri.org/IService1/createTagsResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Tags> createTagsAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getTags", ReplyAction="http://tempuri.org/IService1/getTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getTagsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveTag", ReplyAction="http://tempuri.org/IService1/saveTagResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Tags> saveTagAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPicturesByTagMetod", ReplyAction="http://tempuri.org/IService1/GetPicturesByTagMetodResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference2.Informations>> GetPicturesByTagMetodAsync(string description, string tag);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceReference2.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference2.IService1>, ServiceReference2.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.CompositeType> GetDataUsingDataContractAsync(ServiceReference2.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Informations> saveInformationsAsync(string path, string tag, string value)
        {
            return base.Channel.saveInformationsAsync(path, tag, value);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> displaySearchResultsAsync(string description, string tag)
        {
            return base.Channel.displaySearchResultsAsync(description, tag);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Picture> createPictureAsync(string path)
        {
            return base.Channel.createPictureAsync(path);
        }
        
        public System.Threading.Tasks.Task deletePictureAsync(string path)
        {
            return base.Channel.deletePictureAsync(path);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Tags> createTagsAsync(string name)
        {
            return base.Channel.createTagsAsync(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> getTagsAsync()
        {
            return base.Channel.getTagsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Tags> saveTagAsync(string name)
        {
            return base.Channel.saveTagAsync(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference2.Informations>> GetPicturesByTagMetodAsync(string description, string tag)
        {
            return base.Channel.GetPicturesByTagMetodAsync(description, tag);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/InformationsTagsPictures/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XE_HR_FrontEndCoreWCFClient.CoreWCFClients
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XE_HR_FrontEndCoreWCFClient.CoreWCFClients.IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_Store" +
        "dProcedure_Service")]
    public interface IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service/Call_" +
            "XE_HR_PACKAGE1_OPEN_TWO_CURSORS", ReplyAction="http://tempuri.org/IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service/Call_" +
            "XE_HR_PACKAGE1_OPEN_TWO_CURSORSResponse")]
        System.Threading.Tasks.Task<XE_HR_Common.IndirectReferenceTransformerModels.XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR> Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORSAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceChannel : XE_HR_FrontEndCoreWCFClient.CoreWCFClients.IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient : System.ServiceModel.ClientBase<XE_HR_FrontEndCoreWCFClient.CoreWCFClients.IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service>, XE_HR_FrontEndCoreWCFClient.CoreWCFClients.IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient() : 
                base(XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetDefaultBinding(), XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetBindingForEndpoint(endpointConfiguration), XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<XE_HR_Common.IndirectReferenceTransformerModels.XE_HR_PACKAGE1_OPEN_TWO_CURSORS_OM_IR> Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORSAsync()
        {
            return base.Channel.Call_XE_HR_PACKAGE1_OPEN_TWO_CURSORSAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:5001/XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return XE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IXE_HR_PACKAGE1_OPEN_TWO_CURSORS_StoredProcedure_Service,
        }
    }
}

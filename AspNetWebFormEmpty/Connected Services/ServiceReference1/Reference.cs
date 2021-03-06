﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetWebFormEmpty.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService2Soap")]
    public interface WebService2Soap {
        
        // CODEGEN: Parameter 'GetRemoteClientDataResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayItemAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRemoteClientData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse GetRemoteClientData(AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRemoteClientData", ReplyAction="*")]
        System.Threading.Tasks.Task<AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse> GetRemoteClientDataAsync(AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetClientData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientData", ReplyAction="*")]
        System.Threading.Tasks.Task GetClientDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientDataWithGetMethod", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetClientDataWithGetMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetClientDataWithGetMethod", ReplyAction="*")]
        System.Threading.Tasks.Task GetClientDataWithGetMethodAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RemoteClientData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dayOfWeekField;
        
        private bool isUrlProvidedField;
        
        private System.DateTime mydateTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string dayOfWeek {
            get {
                return this.dayOfWeekField;
            }
            set {
                this.dayOfWeekField = value;
                this.RaisePropertyChanged("dayOfWeek");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool isUrlProvided {
            get {
                return this.isUrlProvidedField;
            }
            set {
                this.isUrlProvidedField = value;
                this.RaisePropertyChanged("isUrlProvided");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime mydateTime {
            get {
                return this.mydateTimeField;
            }
            set {
                this.mydateTimeField = value;
                this.RaisePropertyChanged("mydateTime");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRemoteClientData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetRemoteClientDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string optionalstr;
        
        public GetRemoteClientDataRequest() {
        }
        
        public GetRemoteClientDataRequest(string optionalstr) {
            this.optionalstr = optionalstr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRemoteClientDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetRemoteClientDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public AspNetWebFormEmpty.ServiceReference1.RemoteClientData[] GetRemoteClientDataResult;
        
        public GetRemoteClientDataResponse() {
        }
        
        public GetRemoteClientDataResponse(AspNetWebFormEmpty.ServiceReference1.RemoteClientData[] GetRemoteClientDataResult) {
            this.GetRemoteClientDataResult = GetRemoteClientDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService2SoapChannel : AspNetWebFormEmpty.ServiceReference1.WebService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService2SoapClient : System.ServiceModel.ClientBase<AspNetWebFormEmpty.ServiceReference1.WebService2Soap>, AspNetWebFormEmpty.ServiceReference1.WebService2Soap {
        
        public WebService2SoapClient() {
        }
        
        public WebService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse AspNetWebFormEmpty.ServiceReference1.WebService2Soap.GetRemoteClientData(AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest request) {
            return base.Channel.GetRemoteClientData(request);
        }
        
        public AspNetWebFormEmpty.ServiceReference1.RemoteClientData[] GetRemoteClientData(string optionalstr) {
            AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest inValue = new AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest();
            inValue.optionalstr = optionalstr;
            AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse retVal = ((AspNetWebFormEmpty.ServiceReference1.WebService2Soap)(this)).GetRemoteClientData(inValue);
            return retVal.GetRemoteClientDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse> AspNetWebFormEmpty.ServiceReference1.WebService2Soap.GetRemoteClientDataAsync(AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest request) {
            return base.Channel.GetRemoteClientDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataResponse> GetRemoteClientDataAsync(string optionalstr) {
            AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest inValue = new AspNetWebFormEmpty.ServiceReference1.GetRemoteClientDataRequest();
            inValue.optionalstr = optionalstr;
            return ((AspNetWebFormEmpty.ServiceReference1.WebService2Soap)(this)).GetRemoteClientDataAsync(inValue);
        }
        
        public void GetClientData() {
            base.Channel.GetClientData();
        }
        
        public System.Threading.Tasks.Task GetClientDataAsync() {
            return base.Channel.GetClientDataAsync();
        }
        
        public void GetClientDataWithGetMethod() {
            base.Channel.GetClientDataWithGetMethod();
        }
        
        public System.Threading.Tasks.Task GetClientDataWithGetMethodAsync() {
            return base.Channel.GetClientDataWithGetMethodAsync();
        }
    }
}

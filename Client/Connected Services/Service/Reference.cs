﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IService", CallbackContract=typeof(Client.Service.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        string Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Subscribe", ReplyAction="http://tempuri.org/IService/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Subscribe", ReplyAction="http://tempuri.org/IService/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Unsubscribe", ReplyAction="http://tempuri.org/IService/UnsubscribeResponse")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Unsubscribe", ReplyAction="http://tempuri.org/IService/UnsubscribeResponse")]
        System.Threading.Tasks.Task UnsubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Poke", ReplyAction="http://tempuri.org/IService/PokeResponse")]
        void Poke(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.Service.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<Client.Service.IService>, Client.Service.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<string> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
    }
}

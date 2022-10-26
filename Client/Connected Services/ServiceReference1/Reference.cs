﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IChatService1", CallbackContract=typeof(Client.ServiceReference1.IChatService1Callback))]
    public interface IChatService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService1/Connect", ReplyAction="http://tempuri.org/IChatService1/ConnectResponse")]
        int Connect(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService1/Connect", ReplyAction="http://tempuri.org/IChatService1/ConnectResponse")]
        System.Threading.Tasks.Task<int> ConnectAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService1/Disconnect", ReplyAction="http://tempuri.org/IChatService1/DisconnectResponse")]
        void Disconnect(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChatService1/Disconnect", ReplyAction="http://tempuri.org/IChatService1/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService1/SendMessage")]
        void SendMessage(string message, int ID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService1/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(string message, int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatService1Callback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatService1/MessageCallBack")]
        void MessageCallBack(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatService1Channel : Client.ServiceReference1.IChatService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatService1Client : System.ServiceModel.DuplexClientBase<Client.ServiceReference1.IChatService1>, Client.ServiceReference1.IChatService1 {
        
        public ChatService1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatService1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatService1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Connect(string name) {
            return base.Channel.Connect(name);
        }
        
        public System.Threading.Tasks.Task<int> ConnectAsync(string name) {
            return base.Channel.ConnectAsync(name);
        }
        
        public void Disconnect(int ID) {
            base.Channel.Disconnect(ID);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(int ID) {
            return base.Channel.DisconnectAsync(ID);
        }
        
        public void SendMessage(string message, int ID) {
            base.Channel.SendMessage(message, ID);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string message, int ID) {
            return base.Channel.SendMessageAsync(message, ID);
        }
    }
}

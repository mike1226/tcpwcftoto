﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Client.TotoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TotoService.ITotoService")]
    public interface ITotoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITotoService/Process", ReplyAction="http://tempuri.org/ITotoService/ProcessResponse")]
        string Process(string strDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITotoService/Process", ReplyAction="http://tempuri.org/ITotoService/ProcessResponse")]
        System.Threading.Tasks.Task<string> ProcessAsync(string strDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITotoServiceChannel : Test_Client.TotoService.ITotoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TotoServiceClient : System.ServiceModel.ClientBase<Test_Client.TotoService.ITotoService>, Test_Client.TotoService.ITotoService {
        
        public TotoServiceClient() {
        }
        
        public TotoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TotoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TotoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TotoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Process(string strDto) {
            return base.Channel.Process(strDto);
        }
        
        public System.Threading.Tasks.Task<string> ProcessAsync(string strDto) {
            return base.Channel.ProcessAsync(strDto);
        }
    }
}

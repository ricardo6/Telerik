﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02.DateTime.ConsoleClient.Operations {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Operations.IDateTimeOperations")]
    public interface IDateTimeOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDateTimeOperations/GetDayOfWeekAsString", ReplyAction="http://tempuri.org/IDateTimeOperations/GetDayOfWeekAsStringResponse")]
        string GetDayOfWeekAsString(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDateTimeOperations/GetDayOfWeekAsString", ReplyAction="http://tempuri.org/IDateTimeOperations/GetDayOfWeekAsStringResponse")]
        System.Threading.Tasks.Task<string> GetDayOfWeekAsStringAsync(System.DateTime dateTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDateTimeOperationsChannel : _02.DateTime.ConsoleClient.Operations.IDateTimeOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DateTimeOperationsClient : System.ServiceModel.ClientBase<_02.DateTime.ConsoleClient.Operations.IDateTimeOperations>, _02.DateTime.ConsoleClient.Operations.IDateTimeOperations {
        
        public DateTimeOperationsClient() {
        }
        
        public DateTimeOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DateTimeOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DateTimeOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DateTimeOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDayOfWeekAsString(System.DateTime dateTime) {
            return base.Channel.GetDayOfWeekAsString(dateTime);
        }
        
        public System.Threading.Tasks.Task<string> GetDayOfWeekAsStringAsync(System.DateTime dateTime) {
            return base.Channel.GetDayOfWeekAsStringAsync(dateTime);
        }
    }
}
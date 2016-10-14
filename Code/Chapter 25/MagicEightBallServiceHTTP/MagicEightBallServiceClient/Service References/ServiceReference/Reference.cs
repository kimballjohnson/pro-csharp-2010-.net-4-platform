﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicEightBallServiceClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MyCompany.com", ConfigurationName="ServiceReference.IEightBall")]
    public interface IEightBall {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MyCompany.com/IEightBall/ObtainAnswerToQuestion", ReplyAction="http://MyCompany.com/IEightBall/ObtainAnswerToQuestionResponse")]
        string ObtainAnswerToQuestion(string userQuestion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEightBallChannel : MagicEightBallServiceClient.ServiceReference.IEightBall, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EightBallClient : System.ServiceModel.ClientBase<MagicEightBallServiceClient.ServiceReference.IEightBall>, MagicEightBallServiceClient.ServiceReference.IEightBall {
        
        public EightBallClient() {
        }
        
        public EightBallClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EightBallClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtainAnswerToQuestion(string userQuestion) {
            return base.Channel.ObtainAnswerToQuestion(userQuestion);
        }
    }
}
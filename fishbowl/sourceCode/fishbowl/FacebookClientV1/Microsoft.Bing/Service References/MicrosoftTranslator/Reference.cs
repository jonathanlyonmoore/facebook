﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30128.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Bing.MicrosoftTranslator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", ConfigurationName="MicrosoftTranslator.LanguageService")]
    internal interface LanguageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguages", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguagesRespon" +
            "se")]
        string[] GetLanguages(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNamesRe" +
            "sponse")]
        string[] GetLanguageNames(string appId, string locale);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/DetectResponse")]
        string Detect(string appId, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/TranslateResponse")]
        string Translate(string appId, string text, string from, string to);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface LanguageServiceChannel : Microsoft.Bing.MicrosoftTranslator.LanguageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class LanguageServiceClient : System.ServiceModel.ClientBase<Microsoft.Bing.MicrosoftTranslator.LanguageService>, Microsoft.Bing.MicrosoftTranslator.LanguageService {
        
        public LanguageServiceClient() {
        }
        
        public LanguageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetLanguages(string appId) {
            return base.Channel.GetLanguages(appId);
        }
        
        public string[] GetLanguageNames(string appId, string locale) {
            return base.Channel.GetLanguageNames(appId, locale);
        }
        
        public string Detect(string appId, string text) {
            return base.Channel.Detect(appId, text);
        }
        
        public string Translate(string appId, string text, string from, string to) {
            return base.Channel.Translate(appId, text, from, to);
        }
    }
}

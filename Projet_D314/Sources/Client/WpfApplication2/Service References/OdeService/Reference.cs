﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication2.OdeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetode.org/", ConfigurationName="OdeService.OdeService")]
    public interface OdeService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/MaterialisationPartielleRequest", ReplyAction="http://projetode.org/OdeService/MaterialisationPartielleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WpfApplication2.OdeService.MaterialisationPartielleResponse MaterialisationPartielle(WpfApplication2.OdeService.MaterialisationPartielleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/MaterialisationPartielleRequest", ReplyAction="http://projetode.org/OdeService/MaterialisationPartielleResponse")]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.MaterialisationPartielleResponse> MaterialisationPartielleAsync(WpfApplication2.OdeService.MaterialisationPartielleRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/GetCombinaisonsRequest", ReplyAction="http://projetode.org/OdeService/GetCombinaisonsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WpfApplication2.OdeService.GetCombinaisonsResponse GetCombinaisons(WpfApplication2.OdeService.GetCombinaisonsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/GetCombinaisonsRequest", ReplyAction="http://projetode.org/OdeService/GetCombinaisonsResponse")]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.GetCombinaisonsResponse> GetCombinaisonsAsync(WpfApplication2.OdeService.GetCombinaisonsRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/MetropolisRequest", ReplyAction="http://projetode.org/OdeService/MetropolisResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WpfApplication2.OdeService.MetropolisResponse Metropolis(WpfApplication2.OdeService.MetropolisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetode.org/OdeService/MetropolisRequest", ReplyAction="http://projetode.org/OdeService/MetropolisResponse")]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.MetropolisResponse> MetropolisAsync(WpfApplication2.OdeService.MetropolisRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://projetode.org/")]
    public partial class dimension : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="MaterialisationPartielle", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class MaterialisationPartielleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplication2.OdeService.dimension[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double arg1;
        
        public MaterialisationPartielleRequest() {
        }
        
        public MaterialisationPartielleRequest(WpfApplication2.OdeService.dimension[] arg0, double arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MaterialisationPartielleResponse", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class MaterialisationPartielleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] @return;
        
        public MaterialisationPartielleResponse() {
        }
        
        public MaterialisationPartielleResponse(int[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCombinaisons", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class GetCombinaisonsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplication2.OdeService.dimension[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("arg1", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplication2.OdeService.dimension[] arg1;
        
        public GetCombinaisonsRequest() {
        }
        
        public GetCombinaisonsRequest(WpfApplication2.OdeService.dimension[] arg0, WpfApplication2.OdeService.dimension[] arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCombinaisonsResponse", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class GetCombinaisonsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplication2.OdeService.dimension[] @return;
        
        public GetCombinaisonsResponse() {
        }
        
        public GetCombinaisonsResponse(WpfApplication2.OdeService.dimension[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Metropolis", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class MetropolisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplication2.OdeService.dimension[] arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg2;
        
        public MetropolisRequest() {
        }
        
        public MetropolisRequest(WpfApplication2.OdeService.dimension[] arg0, double arg1, int arg2) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MetropolisResponse", WrapperNamespace="http://projetode.org/", IsWrapped=true)]
    public partial class MetropolisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://projetode.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int[] @return;
        
        public MetropolisResponse() {
        }
        
        public MetropolisResponse(int[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OdeServiceChannel : WpfApplication2.OdeService.OdeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OdeServiceClient : System.ServiceModel.ClientBase<WpfApplication2.OdeService.OdeService>, WpfApplication2.OdeService.OdeService {
        
        public OdeServiceClient() {
        }
        
        public OdeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OdeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OdeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OdeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApplication2.OdeService.MaterialisationPartielleResponse WpfApplication2.OdeService.OdeService.MaterialisationPartielle(WpfApplication2.OdeService.MaterialisationPartielleRequest request) {
            return base.Channel.MaterialisationPartielle(request);
        }
        
        public int[] MaterialisationPartielle(WpfApplication2.OdeService.dimension[] arg0, double arg1) {
            WpfApplication2.OdeService.MaterialisationPartielleRequest inValue = new WpfApplication2.OdeService.MaterialisationPartielleRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            WpfApplication2.OdeService.MaterialisationPartielleResponse retVal = ((WpfApplication2.OdeService.OdeService)(this)).MaterialisationPartielle(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.MaterialisationPartielleResponse> WpfApplication2.OdeService.OdeService.MaterialisationPartielleAsync(WpfApplication2.OdeService.MaterialisationPartielleRequest request) {
            return base.Channel.MaterialisationPartielleAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApplication2.OdeService.MaterialisationPartielleResponse> MaterialisationPartielleAsync(WpfApplication2.OdeService.dimension[] arg0, double arg1) {
            WpfApplication2.OdeService.MaterialisationPartielleRequest inValue = new WpfApplication2.OdeService.MaterialisationPartielleRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((WpfApplication2.OdeService.OdeService)(this)).MaterialisationPartielleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApplication2.OdeService.GetCombinaisonsResponse WpfApplication2.OdeService.OdeService.GetCombinaisons(WpfApplication2.OdeService.GetCombinaisonsRequest request) {
            return base.Channel.GetCombinaisons(request);
        }
        
        public WpfApplication2.OdeService.dimension[] GetCombinaisons(WpfApplication2.OdeService.dimension[] arg0, WpfApplication2.OdeService.dimension[] arg1) {
            WpfApplication2.OdeService.GetCombinaisonsRequest inValue = new WpfApplication2.OdeService.GetCombinaisonsRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            WpfApplication2.OdeService.GetCombinaisonsResponse retVal = ((WpfApplication2.OdeService.OdeService)(this)).GetCombinaisons(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.GetCombinaisonsResponse> WpfApplication2.OdeService.OdeService.GetCombinaisonsAsync(WpfApplication2.OdeService.GetCombinaisonsRequest request) {
            return base.Channel.GetCombinaisonsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApplication2.OdeService.GetCombinaisonsResponse> GetCombinaisonsAsync(WpfApplication2.OdeService.dimension[] arg0, WpfApplication2.OdeService.dimension[] arg1) {
            WpfApplication2.OdeService.GetCombinaisonsRequest inValue = new WpfApplication2.OdeService.GetCombinaisonsRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((WpfApplication2.OdeService.OdeService)(this)).GetCombinaisonsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApplication2.OdeService.MetropolisResponse WpfApplication2.OdeService.OdeService.Metropolis(WpfApplication2.OdeService.MetropolisRequest request) {
            return base.Channel.Metropolis(request);
        }
        
        public int[] Metropolis(WpfApplication2.OdeService.dimension[] arg0, double arg1, int arg2) {
            WpfApplication2.OdeService.MetropolisRequest inValue = new WpfApplication2.OdeService.MetropolisRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            WpfApplication2.OdeService.MetropolisResponse retVal = ((WpfApplication2.OdeService.OdeService)(this)).Metropolis(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApplication2.OdeService.MetropolisResponse> WpfApplication2.OdeService.OdeService.MetropolisAsync(WpfApplication2.OdeService.MetropolisRequest request) {
            return base.Channel.MetropolisAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApplication2.OdeService.MetropolisResponse> MetropolisAsync(WpfApplication2.OdeService.dimension[] arg0, double arg1, int arg2) {
            WpfApplication2.OdeService.MetropolisRequest inValue = new WpfApplication2.OdeService.MetropolisRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            return ((WpfApplication2.OdeService.OdeService)(this)).MetropolisAsync(inValue);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vista.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoDocumento", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class TipoDocumento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int codigoDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionDocumentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int codigoDocumento {
            get {
                return this.codigoDocumentoField;
            }
            set {
                if ((this.codigoDocumentoField.Equals(value) != true)) {
                    this.codigoDocumentoField = value;
                    this.RaisePropertyChanged("codigoDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string descripcionDocumento {
            get {
                return this.descripcionDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionDocumentoField, value) != true)) {
                    this.descripcionDocumentoField = value;
                    this.RaisePropertyChanged("descripcionDocumento");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento tipo del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarTipoDocumento", ReplyAction="*")]
        Vista.ServiceReference1.agregarTipoDocumentoResponse agregarTipoDocumento(Vista.ServiceReference1.agregarTipoDocumentoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/agregarTipoDocumento", ReplyAction="*")]
        System.Threading.Tasks.Task<Vista.ServiceReference1.agregarTipoDocumentoResponse> agregarTipoDocumentoAsync(Vista.ServiceReference1.agregarTipoDocumentoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento dameListaTipoDocumentosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dameListaTipoDocumentos", ReplyAction="*")]
        Vista.ServiceReference1.dameListaTipoDocumentosResponse dameListaTipoDocumentos(Vista.ServiceReference1.dameListaTipoDocumentosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dameListaTipoDocumentos", ReplyAction="*")]
        System.Threading.Tasks.Task<Vista.ServiceReference1.dameListaTipoDocumentosResponse> dameListaTipoDocumentosAsync(Vista.ServiceReference1.dameListaTipoDocumentosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento eliminarTipoDocResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarTipoDoc", ReplyAction="*")]
        Vista.ServiceReference1.eliminarTipoDocResponse eliminarTipoDoc(Vista.ServiceReference1.eliminarTipoDocRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminarTipoDoc", ReplyAction="*")]
        System.Threading.Tasks.Task<Vista.ServiceReference1.eliminarTipoDocResponse> eliminarTipoDocAsync(Vista.ServiceReference1.eliminarTipoDocRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class agregarTipoDocumentoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="agregarTipoDocumento", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.agregarTipoDocumentoRequestBody Body;
        
        public agregarTipoDocumentoRequest() {
        }
        
        public agregarTipoDocumentoRequest(Vista.ServiceReference1.agregarTipoDocumentoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class agregarTipoDocumentoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Vista.ServiceReference1.TipoDocumento tipo;
        
        public agregarTipoDocumentoRequestBody() {
        }
        
        public agregarTipoDocumentoRequestBody(Vista.ServiceReference1.TipoDocumento tipo) {
            this.tipo = tipo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class agregarTipoDocumentoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="agregarTipoDocumentoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.agregarTipoDocumentoResponseBody Body;
        
        public agregarTipoDocumentoResponse() {
        }
        
        public agregarTipoDocumentoResponse(Vista.ServiceReference1.agregarTipoDocumentoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class agregarTipoDocumentoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agregarTipoDocumentoResult;
        
        public agregarTipoDocumentoResponseBody() {
        }
        
        public agregarTipoDocumentoResponseBody(string agregarTipoDocumentoResult) {
            this.agregarTipoDocumentoResult = agregarTipoDocumentoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class dameListaTipoDocumentosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="dameListaTipoDocumentos", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.dameListaTipoDocumentosRequestBody Body;
        
        public dameListaTipoDocumentosRequest() {
        }
        
        public dameListaTipoDocumentosRequest(Vista.ServiceReference1.dameListaTipoDocumentosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class dameListaTipoDocumentosRequestBody {
        
        public dameListaTipoDocumentosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class dameListaTipoDocumentosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="dameListaTipoDocumentosResponse", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.dameListaTipoDocumentosResponseBody Body;
        
        public dameListaTipoDocumentosResponse() {
        }
        
        public dameListaTipoDocumentosResponse(Vista.ServiceReference1.dameListaTipoDocumentosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class dameListaTipoDocumentosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Vista.ServiceReference1.TipoDocumento[] dameListaTipoDocumentosResult;
        
        public dameListaTipoDocumentosResponseBody() {
        }
        
        public dameListaTipoDocumentosResponseBody(Vista.ServiceReference1.TipoDocumento[] dameListaTipoDocumentosResult) {
            this.dameListaTipoDocumentosResult = dameListaTipoDocumentosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarTipoDocRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarTipoDoc", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.eliminarTipoDocRequestBody Body;
        
        public eliminarTipoDocRequest() {
        }
        
        public eliminarTipoDocRequest(Vista.ServiceReference1.eliminarTipoDocRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarTipoDocRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int codigo;
        
        public eliminarTipoDocRequestBody() {
        }
        
        public eliminarTipoDocRequestBody(int codigo) {
            this.codigo = codigo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class eliminarTipoDocResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="eliminarTipoDocResponse", Namespace="http://tempuri.org/", Order=0)]
        public Vista.ServiceReference1.eliminarTipoDocResponseBody Body;
        
        public eliminarTipoDocResponse() {
        }
        
        public eliminarTipoDocResponse(Vista.ServiceReference1.eliminarTipoDocResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class eliminarTipoDocResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eliminarTipoDocResult;
        
        public eliminarTipoDocResponseBody() {
        }
        
        public eliminarTipoDocResponseBody(string eliminarTipoDocResult) {
            this.eliminarTipoDocResult = eliminarTipoDocResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Vista.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Vista.ServiceReference1.WebService1Soap>, Vista.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Vista.ServiceReference1.agregarTipoDocumentoResponse Vista.ServiceReference1.WebService1Soap.agregarTipoDocumento(Vista.ServiceReference1.agregarTipoDocumentoRequest request) {
            return base.Channel.agregarTipoDocumento(request);
        }
        
        public string agregarTipoDocumento(Vista.ServiceReference1.TipoDocumento tipo) {
            Vista.ServiceReference1.agregarTipoDocumentoRequest inValue = new Vista.ServiceReference1.agregarTipoDocumentoRequest();
            inValue.Body = new Vista.ServiceReference1.agregarTipoDocumentoRequestBody();
            inValue.Body.tipo = tipo;
            Vista.ServiceReference1.agregarTipoDocumentoResponse retVal = ((Vista.ServiceReference1.WebService1Soap)(this)).agregarTipoDocumento(inValue);
            return retVal.Body.agregarTipoDocumentoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Vista.ServiceReference1.agregarTipoDocumentoResponse> Vista.ServiceReference1.WebService1Soap.agregarTipoDocumentoAsync(Vista.ServiceReference1.agregarTipoDocumentoRequest request) {
            return base.Channel.agregarTipoDocumentoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Vista.ServiceReference1.agregarTipoDocumentoResponse> agregarTipoDocumentoAsync(Vista.ServiceReference1.TipoDocumento tipo) {
            Vista.ServiceReference1.agregarTipoDocumentoRequest inValue = new Vista.ServiceReference1.agregarTipoDocumentoRequest();
            inValue.Body = new Vista.ServiceReference1.agregarTipoDocumentoRequestBody();
            inValue.Body.tipo = tipo;
            return ((Vista.ServiceReference1.WebService1Soap)(this)).agregarTipoDocumentoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Vista.ServiceReference1.dameListaTipoDocumentosResponse Vista.ServiceReference1.WebService1Soap.dameListaTipoDocumentos(Vista.ServiceReference1.dameListaTipoDocumentosRequest request) {
            return base.Channel.dameListaTipoDocumentos(request);
        }
        
        public Vista.ServiceReference1.TipoDocumento[] dameListaTipoDocumentos() {
            Vista.ServiceReference1.dameListaTipoDocumentosRequest inValue = new Vista.ServiceReference1.dameListaTipoDocumentosRequest();
            inValue.Body = new Vista.ServiceReference1.dameListaTipoDocumentosRequestBody();
            Vista.ServiceReference1.dameListaTipoDocumentosResponse retVal = ((Vista.ServiceReference1.WebService1Soap)(this)).dameListaTipoDocumentos(inValue);
            return retVal.Body.dameListaTipoDocumentosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Vista.ServiceReference1.dameListaTipoDocumentosResponse> Vista.ServiceReference1.WebService1Soap.dameListaTipoDocumentosAsync(Vista.ServiceReference1.dameListaTipoDocumentosRequest request) {
            return base.Channel.dameListaTipoDocumentosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Vista.ServiceReference1.dameListaTipoDocumentosResponse> dameListaTipoDocumentosAsync() {
            Vista.ServiceReference1.dameListaTipoDocumentosRequest inValue = new Vista.ServiceReference1.dameListaTipoDocumentosRequest();
            inValue.Body = new Vista.ServiceReference1.dameListaTipoDocumentosRequestBody();
            return ((Vista.ServiceReference1.WebService1Soap)(this)).dameListaTipoDocumentosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Vista.ServiceReference1.eliminarTipoDocResponse Vista.ServiceReference1.WebService1Soap.eliminarTipoDoc(Vista.ServiceReference1.eliminarTipoDocRequest request) {
            return base.Channel.eliminarTipoDoc(request);
        }
        
        public string eliminarTipoDoc(int codigo) {
            Vista.ServiceReference1.eliminarTipoDocRequest inValue = new Vista.ServiceReference1.eliminarTipoDocRequest();
            inValue.Body = new Vista.ServiceReference1.eliminarTipoDocRequestBody();
            inValue.Body.codigo = codigo;
            Vista.ServiceReference1.eliminarTipoDocResponse retVal = ((Vista.ServiceReference1.WebService1Soap)(this)).eliminarTipoDoc(inValue);
            return retVal.Body.eliminarTipoDocResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Vista.ServiceReference1.eliminarTipoDocResponse> Vista.ServiceReference1.WebService1Soap.eliminarTipoDocAsync(Vista.ServiceReference1.eliminarTipoDocRequest request) {
            return base.Channel.eliminarTipoDocAsync(request);
        }
        
        public System.Threading.Tasks.Task<Vista.ServiceReference1.eliminarTipoDocResponse> eliminarTipoDocAsync(int codigo) {
            Vista.ServiceReference1.eliminarTipoDocRequest inValue = new Vista.ServiceReference1.eliminarTipoDocRequest();
            inValue.Body = new Vista.ServiceReference1.eliminarTipoDocRequestBody();
            inValue.Body.codigo = codigo;
            return ((Vista.ServiceReference1.WebService1Soap)(this)).eliminarTipoDocAsync(inValue);
        }
    }
}

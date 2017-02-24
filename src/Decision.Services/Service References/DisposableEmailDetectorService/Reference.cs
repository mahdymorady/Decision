﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decision.ServiceLayer.Service_References.DisposableEmailDetectorService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public partial class faultBean : object, System.ComponentModel.INotifyPropertyChanged {
        
        private blame blameField;
        
        private bool blameFieldSpecified;
        
        private int errorCodeField;
        
        private string faultCauseField;
        
        private string messageField;
        
        private bool problemReportedField;
        
        private retry retryOtherServersField;
        
        private retry retrySameServerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public blame blame {
            get {
                return this.blameField;
            }
            set {
                this.blameField = value;
                this.RaisePropertyChanged("blame");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool blameSpecified {
            get {
                return this.blameFieldSpecified;
            }
            set {
                this.blameFieldSpecified = value;
                this.RaisePropertyChanged("blameSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string faultCause {
            get {
                return this.faultCauseField;
            }
            set {
                this.faultCauseField = value;
                this.RaisePropertyChanged("faultCause");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool problemReported {
            get {
                return this.problemReportedField;
            }
            set {
                this.problemReportedField = value;
                this.RaisePropertyChanged("problemReported");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public retry retryOtherServers {
            get {
                return this.retryOtherServersField;
            }
            set {
                this.retryOtherServersField = value;
                this.RaisePropertyChanged("retryOtherServers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public retry retrySameServer {
            get {
                return this.retrySameServerField;
            }
            set {
                this.retrySameServerField = value;
                this.RaisePropertyChanged("retrySameServer");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public enum blame {
        
        /// <remarks/>
        CLIENT,
        
        /// <remarks/>
        SERVER,
        
        /// <remarks/>
        NETWORK,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public partial class retry : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long retryInSecondsField;
        
        private bool retryInSecondsFieldSpecified;
        
        private retryType retryTypeField;
        
        private bool retryTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public long retryInSeconds {
            get {
                return this.retryInSecondsField;
            }
            set {
                this.retryInSecondsField = value;
                this.RaisePropertyChanged("retryInSeconds");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool retryInSecondsSpecified {
            get {
                return this.retryInSecondsFieldSpecified;
            }
            set {
                this.retryInSecondsFieldSpecified = value;
                this.RaisePropertyChanged("retryInSecondsSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public retryType retryType {
            get {
                return this.retryTypeField;
            }
            set {
                this.retryTypeField = value;
                this.RaisePropertyChanged("retryType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool retryTypeSpecified {
            get {
                return this.retryTypeFieldSpecified;
            }
            set {
                this.retryTypeFieldSpecified = value;
                this.RaisePropertyChanged("retryTypeSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public enum retryType {
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        LATER,
        
        /// <remarks/>
        NOW,
        
        /// <remarks/>
        UNKNOWN,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public partial class soapDisposableEmailAddressDetectorResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private maybe disposableField;
        
        private bool disposableFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public maybe disposable {
            get {
                return this.disposableField;
            }
            set {
                this.disposableField = value;
                this.RaisePropertyChanged("disposable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool disposableSpecified {
            get {
                return this.disposableFieldSpecified;
            }
            set {
                this.disposableFieldSpecified = value;
                this.RaisePropertyChanged("disposableSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public enum maybe {
        
        /// <remarks/>
        UNKNOWN,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        YES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public partial class soapContext : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apiKeyField;
        
        private string geoField;
        
        private string languageField;
        
        private priority priorityField;
        
        private bool priorityFieldSpecified;
        
        private soapContextEntry[] propertiesField;
        
        private textCase textCaseField;
        
        private bool textCaseFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apiKey {
            get {
                return this.apiKeyField;
            }
            set {
                this.apiKeyField = value;
                this.RaisePropertyChanged("apiKey");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string geo {
            get {
                return this.geoField;
            }
            set {
                this.geoField = value;
                this.RaisePropertyChanged("geo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
                this.RaisePropertyChanged("language");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public priority priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
                this.RaisePropertyChanged("priority");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prioritySpecified {
            get {
                return this.priorityFieldSpecified;
            }
            set {
                this.priorityFieldSpecified = value;
                this.RaisePropertyChanged("prioritySpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public soapContextEntry[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
                this.RaisePropertyChanged("properties");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public textCase textCase {
            get {
                return this.textCaseField;
            }
            set {
                this.textCaseField = value;
                this.RaisePropertyChanged("textCase");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool textCaseSpecified {
            get {
                return this.textCaseFieldSpecified;
            }
            set {
                this.textCaseFieldSpecified = value;
                this.RaisePropertyChanged("textCaseSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public enum priority {
        
        /// <remarks/>
        REALTIME,
        
        /// <remarks/>
        LOW,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public partial class soapContextEntry : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/")]
    public enum textCase {
        
        /// <remarks/>
        TITLE_CASE,
        
        /// <remarks/>
        UPPER_CASE,
        
        /// <remarks/>
        LOWER_CASE,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/", ConfigurationName="DisposableEmailDetectorService.SoapDisposableEmailAddressDetector")]
    public interface SoapDisposableEmailAddressDetector {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposableRequest", ReplyAction="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposableResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(faultBean), Action="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposable/Fault/AccessDeniedWebServiceExc" +
            "eption", Name="AccessDeniedWebServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(faultBean), Action="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposable/Fault/InvalidInputWebServiceExc" +
            "eption", Name="InvalidInputWebServiceException")]
        [System.ServiceModel.FaultContractAttribute(typeof(faultBean), Action="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposable/Fault/InternalServerErrorWebSer" +
            "viceException", Name="InternalServerErrorWebServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        isDisposableResponse isDisposable(isDisposableRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposableRequest", ReplyAction="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/SoapDisposableEmailAddressDetector/isDisposableResponse")]
        System.Threading.Tasks.Task<isDisposableResponse> isDisposableAsync(isDisposableRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="isDisposable", WrapperNamespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/", IsWrapped=true)]
    public partial class isDisposableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapContext context;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string emailAddress;
        
        public isDisposableRequest() {
        }
        
        public isDisposableRequest(soapContext context, string emailAddress) {
            this.context = context;
            this.emailAddress = emailAddress;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="isDisposableResponse", WrapperNamespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
        "/", IsWrapped=true)]
    public partial class isDisposableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://disposableemailaddressdetector.email.services.v4_0.soap.server.nameapi.org" +
            "/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapDisposableEmailAddressDetectorResult @return;
        
        public isDisposableResponse() {
        }
        
        public isDisposableResponse(soapDisposableEmailAddressDetectorResult @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SoapDisposableEmailAddressDetectorChannel : SoapDisposableEmailAddressDetector, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SoapDisposableEmailAddressDetectorClient : System.ServiceModel.ClientBase<SoapDisposableEmailAddressDetector>, SoapDisposableEmailAddressDetector {
        
        public SoapDisposableEmailAddressDetectorClient() {
        }
        
        public SoapDisposableEmailAddressDetectorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SoapDisposableEmailAddressDetectorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapDisposableEmailAddressDetectorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoapDisposableEmailAddressDetectorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        isDisposableResponse SoapDisposableEmailAddressDetector.isDisposable(isDisposableRequest request) {
            return base.Channel.isDisposable(request);
        }
        
        public soapDisposableEmailAddressDetectorResult isDisposable(soapContext context, string emailAddress) {
            isDisposableRequest inValue = new isDisposableRequest();
            inValue.context = context;
            inValue.emailAddress = emailAddress;
            isDisposableResponse retVal = ((SoapDisposableEmailAddressDetector)(this)).isDisposable(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<isDisposableResponse> SoapDisposableEmailAddressDetector.isDisposableAsync(isDisposableRequest request) {
            return base.Channel.isDisposableAsync(request);
        }
        
        public System.Threading.Tasks.Task<isDisposableResponse> isDisposableAsync(soapContext context, string emailAddress) {
            isDisposableRequest inValue = new isDisposableRequest();
            inValue.context = context;
            inValue.emailAddress = emailAddress;
            return ((SoapDisposableEmailAddressDetector)(this)).isDisposableAsync(inValue);
        }
    }
}

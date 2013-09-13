﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webservice.Client.TestService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.queryexecutor.ttu.ee/", ConfigurationName="TestService.SQLQueryExecutor")]
    public interface SQLQueryExecutor {
        
        // CODEGEN: Parameter 'Table' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.queryexecutor.ttu.ee/SQLQueryExecutor/executeQueryRequest", ReplyAction="http://ws.queryexecutor.ttu.ee/SQLQueryExecutor/executeQueryResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[][]))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Table")]
        Webservice.Client.TestService.executeQueryResponse executeQuery(Webservice.Client.TestService.executeQueryRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1015")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.queryexecutor.ttu.ee/")]
    public partial class table : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool contentAvailableField;
        
        private string infoMessageField;
        
        private string[] columnsField;
        
        private string[][] rowsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool ContentAvailable {
            get {
                return this.contentAvailableField;
            }
            set {
                this.contentAvailableField = value;
                this.RaisePropertyChanged("ContentAvailable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public string InfoMessage {
            get {
                return this.infoMessageField;
            }
            set {
                this.infoMessageField = value;
                this.RaisePropertyChanged("InfoMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] Columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
                this.RaisePropertyChanged("Columns");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("row", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("value", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, NestingLevel=1)]
        public string[][] Rows {
            get {
                return this.rowsField;
            }
            set {
                this.rowsField = value;
                this.RaisePropertyChanged("Rows");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeQuery", WrapperNamespace="http://ws.queryexecutor.ttu.ee/", IsWrapped=true)]
    public partial class executeQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.queryexecutor.ttu.ee/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string query;
        
        public executeQueryRequest() {
        }
        
        public executeQueryRequest(string query) {
            this.query = query;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeQueryResponse", WrapperNamespace="http://ws.queryexecutor.ttu.ee/", IsWrapped=true)]
    public partial class executeQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.queryexecutor.ttu.ee/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Webservice.Client.TestService.table Table;
        
        public executeQueryResponse() {
        }
        
        public executeQueryResponse(Webservice.Client.TestService.table Table) {
            this.Table = Table;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SQLQueryExecutorChannel : Webservice.Client.TestService.SQLQueryExecutor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SQLQueryExecutorClient : System.ServiceModel.ClientBase<Webservice.Client.TestService.SQLQueryExecutor>, Webservice.Client.TestService.SQLQueryExecutor {
        
        public SQLQueryExecutorClient() {
        }
        
        public SQLQueryExecutorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SQLQueryExecutorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SQLQueryExecutorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SQLQueryExecutorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Webservice.Client.TestService.executeQueryResponse Webservice.Client.TestService.SQLQueryExecutor.executeQuery(Webservice.Client.TestService.executeQueryRequest request) {
            return base.Channel.executeQuery(request);
        }
        
        public Webservice.Client.TestService.table executeQuery(string query) {
            Webservice.Client.TestService.executeQueryRequest inValue = new Webservice.Client.TestService.executeQueryRequest();
            inValue.query = query;
            Webservice.Client.TestService.executeQueryResponse retVal = ((Webservice.Client.TestService.SQLQueryExecutor)(this)).executeQuery(inValue);
            return retVal.Table;
        }
    }
}
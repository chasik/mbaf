﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mba_application.MBAImportService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MBAImportService.IImportService")]
    public interface IImportService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/GoodColumn", ReplyAction="http://tempuri.org/IImportService/GoodColumnResponse")]
        mba_model.GoodColumn GoodColumn(string columnHeader);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImportService/GoodColumn", ReplyAction="http://tempuri.org/IImportService/GoodColumnResponse")]
        System.IAsyncResult BeginGoodColumn(string columnHeader, System.AsyncCallback callback, object asyncState);
        
        mba_model.GoodColumn EndGoodColumn(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/GoodColumns", ReplyAction="http://tempuri.org/IImportService/GoodColumnsResponse")]
        mba_model.GoodColumn[] GoodColumns();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImportService/GoodColumns", ReplyAction="http://tempuri.org/IImportService/GoodColumnsResponse")]
        System.IAsyncResult BeginGoodColumns(System.AsyncCallback callback, object asyncState);
        
        mba_model.GoodColumn[] EndGoodColumns(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/Clients", ReplyAction="http://tempuri.org/IImportService/ClientsResponse")]
        mba_model.Client[] Clients();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImportService/Clients", ReplyAction="http://tempuri.org/IImportService/ClientsResponse")]
        System.IAsyncResult BeginClients(System.AsyncCallback callback, object asyncState);
        
        mba_model.Client[] EndClients(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImportService/ImportTypes", ReplyAction="http://tempuri.org/IImportService/ImportTypesResponse")]
        mba_model.ImportType[] ImportTypes();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImportService/ImportTypes", ReplyAction="http://tempuri.org/IImportService/ImportTypesResponse")]
        System.IAsyncResult BeginImportTypes(System.AsyncCallback callback, object asyncState);
        
        mba_model.ImportType[] EndImportTypes(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImportServiceChannel : mba_application.MBAImportService.IImportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GoodColumnCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GoodColumnCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public mba_model.GoodColumn Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((mba_model.GoodColumn)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GoodColumnsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GoodColumnsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public mba_model.GoodColumn[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((mba_model.GoodColumn[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ClientsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public mba_model.Client[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((mba_model.Client[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImportTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ImportTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public mba_model.ImportType[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((mba_model.ImportType[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImportServiceClient : System.ServiceModel.ClientBase<mba_application.MBAImportService.IImportService>, mba_application.MBAImportService.IImportService {
        
        private BeginOperationDelegate onBeginGoodColumnDelegate;
        
        private EndOperationDelegate onEndGoodColumnDelegate;
        
        private System.Threading.SendOrPostCallback onGoodColumnCompletedDelegate;
        
        private BeginOperationDelegate onBeginGoodColumnsDelegate;
        
        private EndOperationDelegate onEndGoodColumnsDelegate;
        
        private System.Threading.SendOrPostCallback onGoodColumnsCompletedDelegate;
        
        private BeginOperationDelegate onBeginClientsDelegate;
        
        private EndOperationDelegate onEndClientsDelegate;
        
        private System.Threading.SendOrPostCallback onClientsCompletedDelegate;
        
        private BeginOperationDelegate onBeginImportTypesDelegate;
        
        private EndOperationDelegate onEndImportTypesDelegate;
        
        private System.Threading.SendOrPostCallback onImportTypesCompletedDelegate;
        
        public ImportServiceClient() {
        }
        
        public ImportServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImportServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GoodColumnCompletedEventArgs> GoodColumnCompleted;
        
        public event System.EventHandler<GoodColumnsCompletedEventArgs> GoodColumnsCompleted;
        
        public event System.EventHandler<ClientsCompletedEventArgs> ClientsCompleted;
        
        public event System.EventHandler<ImportTypesCompletedEventArgs> ImportTypesCompleted;
        
        public mba_model.GoodColumn GoodColumn(string columnHeader) {
            return base.Channel.GoodColumn(columnHeader);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGoodColumn(string columnHeader, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGoodColumn(columnHeader, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public mba_model.GoodColumn EndGoodColumn(System.IAsyncResult result) {
            return base.Channel.EndGoodColumn(result);
        }
        
        private System.IAsyncResult OnBeginGoodColumn(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string columnHeader = ((string)(inValues[0]));
            return this.BeginGoodColumn(columnHeader, callback, asyncState);
        }
        
        private object[] OnEndGoodColumn(System.IAsyncResult result) {
            mba_model.GoodColumn retVal = this.EndGoodColumn(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGoodColumnCompleted(object state) {
            if ((this.GoodColumnCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GoodColumnCompleted(this, new GoodColumnCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GoodColumnAsync(string columnHeader) {
            this.GoodColumnAsync(columnHeader, null);
        }
        
        public void GoodColumnAsync(string columnHeader, object userState) {
            if ((this.onBeginGoodColumnDelegate == null)) {
                this.onBeginGoodColumnDelegate = new BeginOperationDelegate(this.OnBeginGoodColumn);
            }
            if ((this.onEndGoodColumnDelegate == null)) {
                this.onEndGoodColumnDelegate = new EndOperationDelegate(this.OnEndGoodColumn);
            }
            if ((this.onGoodColumnCompletedDelegate == null)) {
                this.onGoodColumnCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGoodColumnCompleted);
            }
            base.InvokeAsync(this.onBeginGoodColumnDelegate, new object[] {
                        columnHeader}, this.onEndGoodColumnDelegate, this.onGoodColumnCompletedDelegate, userState);
        }
        
        public mba_model.GoodColumn[] GoodColumns() {
            return base.Channel.GoodColumns();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGoodColumns(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGoodColumns(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public mba_model.GoodColumn[] EndGoodColumns(System.IAsyncResult result) {
            return base.Channel.EndGoodColumns(result);
        }
        
        private System.IAsyncResult OnBeginGoodColumns(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGoodColumns(callback, asyncState);
        }
        
        private object[] OnEndGoodColumns(System.IAsyncResult result) {
            mba_model.GoodColumn[] retVal = this.EndGoodColumns(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGoodColumnsCompleted(object state) {
            if ((this.GoodColumnsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GoodColumnsCompleted(this, new GoodColumnsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GoodColumnsAsync() {
            this.GoodColumnsAsync(null);
        }
        
        public void GoodColumnsAsync(object userState) {
            if ((this.onBeginGoodColumnsDelegate == null)) {
                this.onBeginGoodColumnsDelegate = new BeginOperationDelegate(this.OnBeginGoodColumns);
            }
            if ((this.onEndGoodColumnsDelegate == null)) {
                this.onEndGoodColumnsDelegate = new EndOperationDelegate(this.OnEndGoodColumns);
            }
            if ((this.onGoodColumnsCompletedDelegate == null)) {
                this.onGoodColumnsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGoodColumnsCompleted);
            }
            base.InvokeAsync(this.onBeginGoodColumnsDelegate, null, this.onEndGoodColumnsDelegate, this.onGoodColumnsCompletedDelegate, userState);
        }
        
        public mba_model.Client[] Clients() {
            return base.Channel.Clients();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginClients(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginClients(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public mba_model.Client[] EndClients(System.IAsyncResult result) {
            return base.Channel.EndClients(result);
        }
        
        private System.IAsyncResult OnBeginClients(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginClients(callback, asyncState);
        }
        
        private object[] OnEndClients(System.IAsyncResult result) {
            mba_model.Client[] retVal = this.EndClients(result);
            return new object[] {
                    retVal};
        }
        
        private void OnClientsCompleted(object state) {
            if ((this.ClientsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ClientsCompleted(this, new ClientsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ClientsAsync() {
            this.ClientsAsync(null);
        }
        
        public void ClientsAsync(object userState) {
            if ((this.onBeginClientsDelegate == null)) {
                this.onBeginClientsDelegate = new BeginOperationDelegate(this.OnBeginClients);
            }
            if ((this.onEndClientsDelegate == null)) {
                this.onEndClientsDelegate = new EndOperationDelegate(this.OnEndClients);
            }
            if ((this.onClientsCompletedDelegate == null)) {
                this.onClientsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnClientsCompleted);
            }
            base.InvokeAsync(this.onBeginClientsDelegate, null, this.onEndClientsDelegate, this.onClientsCompletedDelegate, userState);
        }
        
        public mba_model.ImportType[] ImportTypes() {
            return base.Channel.ImportTypes();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginImportTypes(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginImportTypes(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public mba_model.ImportType[] EndImportTypes(System.IAsyncResult result) {
            return base.Channel.EndImportTypes(result);
        }
        
        private System.IAsyncResult OnBeginImportTypes(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginImportTypes(callback, asyncState);
        }
        
        private object[] OnEndImportTypes(System.IAsyncResult result) {
            mba_model.ImportType[] retVal = this.EndImportTypes(result);
            return new object[] {
                    retVal};
        }
        
        private void OnImportTypesCompleted(object state) {
            if ((this.ImportTypesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ImportTypesCompleted(this, new ImportTypesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ImportTypesAsync() {
            this.ImportTypesAsync(null);
        }
        
        public void ImportTypesAsync(object userState) {
            if ((this.onBeginImportTypesDelegate == null)) {
                this.onBeginImportTypesDelegate = new BeginOperationDelegate(this.OnBeginImportTypes);
            }
            if ((this.onEndImportTypesDelegate == null)) {
                this.onEndImportTypesDelegate = new EndOperationDelegate(this.OnEndImportTypes);
            }
            if ((this.onImportTypesCompletedDelegate == null)) {
                this.onImportTypesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnImportTypesCompleted);
            }
            base.InvokeAsync(this.onBeginImportTypesDelegate, null, this.onEndImportTypesDelegate, this.onImportTypesCompletedDelegate, userState);
        }
    }
}

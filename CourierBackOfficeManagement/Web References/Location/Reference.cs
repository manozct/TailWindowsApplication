﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CourierBackOfficeManagement.Location {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LocationWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class LocationWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LocationNameAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback LocationNameUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback LocationNameGetAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback LocationNameGetByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback LocationNameDeleteByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPageDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchLocationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LocationWebService() {
            this.Url = global::CourierBackOfficeManagement.Properties.Settings.Default.CourierBackOfficeManagement_Location_LocationWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event LocationNameAddCompletedEventHandler LocationNameAddCompleted;
        
        /// <remarks/>
        public event LocationNameUpdateCompletedEventHandler LocationNameUpdateCompleted;
        
        /// <remarks/>
        public event LocationNameGetAllCompletedEventHandler LocationNameGetAllCompleted;
        
        /// <remarks/>
        public event LocationNameGetByIDCompletedEventHandler LocationNameGetByIDCompleted;
        
        /// <remarks/>
        public event LocationNameDeleteByIDCompletedEventHandler LocationNameDeleteByIDCompleted;
        
        /// <remarks/>
        public event GetPageDataCompletedEventHandler GetPageDataCompleted;
        
        /// <remarks/>
        public event SearchLocationCompletedEventHandler SearchLocationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LocationNameAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LocationNameAdd(LocationInfo objInfo, string token) {
            object[] results = this.Invoke("LocationNameAdd", new object[] {
                        objInfo,
                        token});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LocationNameAddAsync(LocationInfo objInfo, string token) {
            this.LocationNameAddAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void LocationNameAddAsync(LocationInfo objInfo, string token, object userState) {
            if ((this.LocationNameAddOperationCompleted == null)) {
                this.LocationNameAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLocationNameAddOperationCompleted);
            }
            this.InvokeAsync("LocationNameAdd", new object[] {
                        objInfo,
                        token}, this.LocationNameAddOperationCompleted, userState);
        }
        
        private void OnLocationNameAddOperationCompleted(object arg) {
            if ((this.LocationNameAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LocationNameAddCompleted(this, new LocationNameAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LocationNameUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LocationNameUpdate(LocationInfo objInfo, string token) {
            object[] results = this.Invoke("LocationNameUpdate", new object[] {
                        objInfo,
                        token});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LocationNameUpdateAsync(LocationInfo objInfo, string token) {
            this.LocationNameUpdateAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void LocationNameUpdateAsync(LocationInfo objInfo, string token, object userState) {
            if ((this.LocationNameUpdateOperationCompleted == null)) {
                this.LocationNameUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLocationNameUpdateOperationCompleted);
            }
            this.InvokeAsync("LocationNameUpdate", new object[] {
                        objInfo,
                        token}, this.LocationNameUpdateOperationCompleted, userState);
        }
        
        private void OnLocationNameUpdateOperationCompleted(object arg) {
            if ((this.LocationNameUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LocationNameUpdateCompleted(this, new LocationNameUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LocationNameGetAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LocationInfo[] LocationNameGetAll(string token) {
            object[] results = this.Invoke("LocationNameGetAll", new object[] {
                        token});
            return ((LocationInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void LocationNameGetAllAsync(string token) {
            this.LocationNameGetAllAsync(token, null);
        }
        
        /// <remarks/>
        public void LocationNameGetAllAsync(string token, object userState) {
            if ((this.LocationNameGetAllOperationCompleted == null)) {
                this.LocationNameGetAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLocationNameGetAllOperationCompleted);
            }
            this.InvokeAsync("LocationNameGetAll", new object[] {
                        token}, this.LocationNameGetAllOperationCompleted, userState);
        }
        
        private void OnLocationNameGetAllOperationCompleted(object arg) {
            if ((this.LocationNameGetAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LocationNameGetAllCompleted(this, new LocationNameGetAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LocationNameGetByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LocationInfo LocationNameGetByID(int LocationID, string token) {
            object[] results = this.Invoke("LocationNameGetByID", new object[] {
                        LocationID,
                        token});
            return ((LocationInfo)(results[0]));
        }
        
        /// <remarks/>
        public void LocationNameGetByIDAsync(int LocationID, string token) {
            this.LocationNameGetByIDAsync(LocationID, token, null);
        }
        
        /// <remarks/>
        public void LocationNameGetByIDAsync(int LocationID, string token, object userState) {
            if ((this.LocationNameGetByIDOperationCompleted == null)) {
                this.LocationNameGetByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLocationNameGetByIDOperationCompleted);
            }
            this.InvokeAsync("LocationNameGetByID", new object[] {
                        LocationID,
                        token}, this.LocationNameGetByIDOperationCompleted, userState);
        }
        
        private void OnLocationNameGetByIDOperationCompleted(object arg) {
            if ((this.LocationNameGetByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LocationNameGetByIDCompleted(this, new LocationNameGetByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LocationNameDeleteByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LocationNameDeleteByID(int LocationID, string DeletedBy, string token) {
            this.Invoke("LocationNameDeleteByID", new object[] {
                        LocationID,
                        DeletedBy,
                        token});
        }
        
        /// <remarks/>
        public void LocationNameDeleteByIDAsync(int LocationID, string DeletedBy, string token) {
            this.LocationNameDeleteByIDAsync(LocationID, DeletedBy, token, null);
        }
        
        /// <remarks/>
        public void LocationNameDeleteByIDAsync(int LocationID, string DeletedBy, string token, object userState) {
            if ((this.LocationNameDeleteByIDOperationCompleted == null)) {
                this.LocationNameDeleteByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLocationNameDeleteByIDOperationCompleted);
            }
            this.InvokeAsync("LocationNameDeleteByID", new object[] {
                        LocationID,
                        DeletedBy,
                        token}, this.LocationNameDeleteByIDOperationCompleted, userState);
        }
        
        private void OnLocationNameDeleteByIDOperationCompleted(object arg) {
            if ((this.LocationNameDeleteByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LocationNameDeleteByIDCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPageData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetPageData(int current, int pagesize, string token) {
            object[] results = this.Invoke("GetPageData", new object[] {
                        current,
                        pagesize,
                        token});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetPageDataAsync(int current, int pagesize, string token) {
            this.GetPageDataAsync(current, pagesize, token, null);
        }
        
        /// <remarks/>
        public void GetPageDataAsync(int current, int pagesize, string token, object userState) {
            if ((this.GetPageDataOperationCompleted == null)) {
                this.GetPageDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPageDataOperationCompleted);
            }
            this.InvokeAsync("GetPageData", new object[] {
                        current,
                        pagesize,
                        token}, this.GetPageDataOperationCompleted, userState);
        }
        
        private void OnGetPageDataOperationCompleted(object arg) {
            if ((this.GetPageDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPageDataCompleted(this, new GetPageDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchLocation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable SearchLocation(string searchText, string token) {
            object[] results = this.Invoke("SearchLocation", new object[] {
                        searchText,
                        token});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void SearchLocationAsync(string searchText, string token) {
            this.SearchLocationAsync(searchText, token, null);
        }
        
        /// <remarks/>
        public void SearchLocationAsync(string searchText, string token, object userState) {
            if ((this.SearchLocationOperationCompleted == null)) {
                this.SearchLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchLocationOperationCompleted);
            }
            this.InvokeAsync("SearchLocation", new object[] {
                        searchText,
                        token}, this.SearchLocationOperationCompleted, userState);
        }
        
        private void OnSearchLocationOperationCompleted(object arg) {
            if ((this.SearchLocationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchLocationCompleted(this, new SearchLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class LocationInfo {
        
        private int locationIDField;
        
        private int countryIDField;
        
        private int stateIDField;
        
        private string locationNameField;
        
        private string addedByField;
        
        private string editedByField;
        
        private string deletedByField;
        
        private System.DateTime addedDateField;
        
        private System.DateTime editedDateField;
        
        private System.DateTime deletedDateField;
        
        private bool isModifiedField;
        
        private bool isDeletedField;
        
        /// <remarks/>
        public int LocationID {
            get {
                return this.locationIDField;
            }
            set {
                this.locationIDField = value;
            }
        }
        
        /// <remarks/>
        public int CountryID {
            get {
                return this.countryIDField;
            }
            set {
                this.countryIDField = value;
            }
        }
        
        /// <remarks/>
        public int StateID {
            get {
                return this.stateIDField;
            }
            set {
                this.stateIDField = value;
            }
        }
        
        /// <remarks/>
        public string LocationName {
            get {
                return this.locationNameField;
            }
            set {
                this.locationNameField = value;
            }
        }
        
        /// <remarks/>
        public string AddedBy {
            get {
                return this.addedByField;
            }
            set {
                this.addedByField = value;
            }
        }
        
        /// <remarks/>
        public string EditedBy {
            get {
                return this.editedByField;
            }
            set {
                this.editedByField = value;
            }
        }
        
        /// <remarks/>
        public string DeletedBy {
            get {
                return this.deletedByField;
            }
            set {
                this.deletedByField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime AddedDate {
            get {
                return this.addedDateField;
            }
            set {
                this.addedDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime EditedDate {
            get {
                return this.editedDateField;
            }
            set {
                this.editedDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DeletedDate {
            get {
                return this.deletedDateField;
            }
            set {
                this.deletedDateField = value;
            }
        }
        
        /// <remarks/>
        public bool IsModified {
            get {
                return this.isModifiedField;
            }
            set {
                this.isModifiedField = value;
            }
        }
        
        /// <remarks/>
        public bool IsDeleted {
            get {
                return this.isDeletedField;
            }
            set {
                this.isDeletedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LocationNameAddCompletedEventHandler(object sender, LocationNameAddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LocationNameAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LocationNameAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LocationNameUpdateCompletedEventHandler(object sender, LocationNameUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LocationNameUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LocationNameUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LocationNameGetAllCompletedEventHandler(object sender, LocationNameGetAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LocationNameGetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LocationNameGetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LocationInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LocationInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LocationNameGetByIDCompletedEventHandler(object sender, LocationNameGetByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LocationNameGetByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LocationNameGetByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LocationInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LocationInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void LocationNameDeleteByIDCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void GetPageDataCompletedEventHandler(object sender, GetPageDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPageDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPageDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void SearchLocationCompletedEventHandler(object sender, SearchLocationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
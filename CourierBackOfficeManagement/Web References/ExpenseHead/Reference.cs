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

namespace CourierBackOfficeManagement.ExpenseHead {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ExpenseHeadWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ExpenseHeadWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ExpenseHeadAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseHeadUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseHeadGetAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseHeadGetByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseHeadDeleteByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPageDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback BindExpenseHeadOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ExpenseHeadWebService() {
            this.Url = global::CourierBackOfficeManagement.Properties.Settings.Default.CourierBackOfficeManagement_ExpenseHead_ExpenseHeadWebService;
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
        public event ExpenseHeadAddCompletedEventHandler ExpenseHeadAddCompleted;
        
        /// <remarks/>
        public event ExpenseHeadUpdateCompletedEventHandler ExpenseHeadUpdateCompleted;
        
        /// <remarks/>
        public event ExpenseHeadGetAllCompletedEventHandler ExpenseHeadGetAllCompleted;
        
        /// <remarks/>
        public event ExpenseHeadGetByIDCompletedEventHandler ExpenseHeadGetByIDCompleted;
        
        /// <remarks/>
        public event ExpenseHeadDeleteByIDCompletedEventHandler ExpenseHeadDeleteByIDCompleted;
        
        /// <remarks/>
        public event GetPageDataCompletedEventHandler GetPageDataCompleted;
        
        /// <remarks/>
        public event BindExpenseHeadCompletedEventHandler BindExpenseHeadCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseHeadAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ExpenseHeadAdd(ExpenseHeadInfo objInfo, string token) {
            object[] results = this.Invoke("ExpenseHeadAdd", new object[] {
                        objInfo,
                        token});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseHeadAddAsync(ExpenseHeadInfo objInfo, string token) {
            this.ExpenseHeadAddAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void ExpenseHeadAddAsync(ExpenseHeadInfo objInfo, string token, object userState) {
            if ((this.ExpenseHeadAddOperationCompleted == null)) {
                this.ExpenseHeadAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseHeadAddOperationCompleted);
            }
            this.InvokeAsync("ExpenseHeadAdd", new object[] {
                        objInfo,
                        token}, this.ExpenseHeadAddOperationCompleted, userState);
        }
        
        private void OnExpenseHeadAddOperationCompleted(object arg) {
            if ((this.ExpenseHeadAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseHeadAddCompleted(this, new ExpenseHeadAddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseHeadUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ExpenseHeadUpdate(ExpenseHeadInfo objInfo, string token) {
            object[] results = this.Invoke("ExpenseHeadUpdate", new object[] {
                        objInfo,
                        token});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseHeadUpdateAsync(ExpenseHeadInfo objInfo, string token) {
            this.ExpenseHeadUpdateAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void ExpenseHeadUpdateAsync(ExpenseHeadInfo objInfo, string token, object userState) {
            if ((this.ExpenseHeadUpdateOperationCompleted == null)) {
                this.ExpenseHeadUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseHeadUpdateOperationCompleted);
            }
            this.InvokeAsync("ExpenseHeadUpdate", new object[] {
                        objInfo,
                        token}, this.ExpenseHeadUpdateOperationCompleted, userState);
        }
        
        private void OnExpenseHeadUpdateOperationCompleted(object arg) {
            if ((this.ExpenseHeadUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseHeadUpdateCompleted(this, new ExpenseHeadUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseHeadGetAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseHeadInfo[] ExpenseHeadGetAll(string token) {
            object[] results = this.Invoke("ExpenseHeadGetAll", new object[] {
                        token});
            return ((ExpenseHeadInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseHeadGetAllAsync(string token) {
            this.ExpenseHeadGetAllAsync(token, null);
        }
        
        /// <remarks/>
        public void ExpenseHeadGetAllAsync(string token, object userState) {
            if ((this.ExpenseHeadGetAllOperationCompleted == null)) {
                this.ExpenseHeadGetAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseHeadGetAllOperationCompleted);
            }
            this.InvokeAsync("ExpenseHeadGetAll", new object[] {
                        token}, this.ExpenseHeadGetAllOperationCompleted, userState);
        }
        
        private void OnExpenseHeadGetAllOperationCompleted(object arg) {
            if ((this.ExpenseHeadGetAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseHeadGetAllCompleted(this, new ExpenseHeadGetAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseHeadGetByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseHeadInfo ExpenseHeadGetByID(int ExpenseHeadID, string token) {
            object[] results = this.Invoke("ExpenseHeadGetByID", new object[] {
                        ExpenseHeadID,
                        token});
            return ((ExpenseHeadInfo)(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseHeadGetByIDAsync(int ExpenseHeadID, string token) {
            this.ExpenseHeadGetByIDAsync(ExpenseHeadID, token, null);
        }
        
        /// <remarks/>
        public void ExpenseHeadGetByIDAsync(int ExpenseHeadID, string token, object userState) {
            if ((this.ExpenseHeadGetByIDOperationCompleted == null)) {
                this.ExpenseHeadGetByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseHeadGetByIDOperationCompleted);
            }
            this.InvokeAsync("ExpenseHeadGetByID", new object[] {
                        ExpenseHeadID,
                        token}, this.ExpenseHeadGetByIDOperationCompleted, userState);
        }
        
        private void OnExpenseHeadGetByIDOperationCompleted(object arg) {
            if ((this.ExpenseHeadGetByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseHeadGetByIDCompleted(this, new ExpenseHeadGetByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseHeadDeleteByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExpenseHeadDeleteByID(int ExpenseHeadID, string token) {
            this.Invoke("ExpenseHeadDeleteByID", new object[] {
                        ExpenseHeadID,
                        token});
        }
        
        /// <remarks/>
        public void ExpenseHeadDeleteByIDAsync(int ExpenseHeadID, string token) {
            this.ExpenseHeadDeleteByIDAsync(ExpenseHeadID, token, null);
        }
        
        /// <remarks/>
        public void ExpenseHeadDeleteByIDAsync(int ExpenseHeadID, string token, object userState) {
            if ((this.ExpenseHeadDeleteByIDOperationCompleted == null)) {
                this.ExpenseHeadDeleteByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseHeadDeleteByIDOperationCompleted);
            }
            this.InvokeAsync("ExpenseHeadDeleteByID", new object[] {
                        ExpenseHeadID,
                        token}, this.ExpenseHeadDeleteByIDOperationCompleted, userState);
        }
        
        private void OnExpenseHeadDeleteByIDOperationCompleted(object arg) {
            if ((this.ExpenseHeadDeleteByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseHeadDeleteByIDCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BindExpenseHead", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable BindExpenseHead(string text, string token) {
            object[] results = this.Invoke("BindExpenseHead", new object[] {
                        text,
                        token});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void BindExpenseHeadAsync(string text, string token) {
            this.BindExpenseHeadAsync(text, token, null);
        }
        
        /// <remarks/>
        public void BindExpenseHeadAsync(string text, string token, object userState) {
            if ((this.BindExpenseHeadOperationCompleted == null)) {
                this.BindExpenseHeadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBindExpenseHeadOperationCompleted);
            }
            this.InvokeAsync("BindExpenseHead", new object[] {
                        text,
                        token}, this.BindExpenseHeadOperationCompleted, userState);
        }
        
        private void OnBindExpenseHeadOperationCompleted(object arg) {
            if ((this.BindExpenseHeadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BindExpenseHeadCompleted(this, new BindExpenseHeadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class ExpenseHeadInfo {
        
        private int expenseHeadIDField;
        
        private string expenseHeadField;
        
        private System.DateTime addedDateField;
        
        private string addedByField;
        
        private string editedByField;
        
        private string deletedByField;
        
        private bool isDeletedField;
        
        private bool isModifiedField;
        
        private System.DateTime editedDateField;
        
        /// <remarks/>
        public int ExpenseHeadID {
            get {
                return this.expenseHeadIDField;
            }
            set {
                this.expenseHeadIDField = value;
            }
        }
        
        /// <remarks/>
        public string ExpenseHead {
            get {
                return this.expenseHeadField;
            }
            set {
                this.expenseHeadField = value;
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
        public bool IsDeleted {
            get {
                return this.isDeletedField;
            }
            set {
                this.isDeletedField = value;
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
        public System.DateTime EditedDate {
            get {
                return this.editedDateField;
            }
            set {
                this.editedDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseHeadAddCompletedEventHandler(object sender, ExpenseHeadAddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseHeadAddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseHeadAddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ExpenseHeadUpdateCompletedEventHandler(object sender, ExpenseHeadUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseHeadUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseHeadUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ExpenseHeadGetAllCompletedEventHandler(object sender, ExpenseHeadGetAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseHeadGetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseHeadGetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseHeadInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseHeadInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseHeadGetByIDCompletedEventHandler(object sender, ExpenseHeadGetByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseHeadGetByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseHeadGetByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseHeadInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseHeadInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseHeadDeleteByIDCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
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
    public delegate void BindExpenseHeadCompletedEventHandler(object sender, BindExpenseHeadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BindExpenseHeadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BindExpenseHeadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
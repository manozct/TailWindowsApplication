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

namespace CourierBackOfficeManagement.Expense {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ExpenseWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ExpenseWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ExpenseAddOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPageDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseGetAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback FilterByExpanseHeadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseGetByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExpenseDeleteByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectExpenseHeadExpenseOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ExpenseWebService() {
            this.Url = global::CourierBackOfficeManagement.Properties.Settings.Default.CourierBackOfficeManagement_Expense_ExpenseWebService;
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
        public event ExpenseAddCompletedEventHandler ExpenseAddCompleted;
        
        /// <remarks/>
        public event ExpenseUpdateCompletedEventHandler ExpenseUpdateCompleted;
        
        /// <remarks/>
        public event GetPageDataCompletedEventHandler GetPageDataCompleted;
        
        /// <remarks/>
        public event ExpenseGetAllCompletedEventHandler ExpenseGetAllCompleted;
        
        /// <remarks/>
        public event FilterByExpanseHeadCompletedEventHandler FilterByExpanseHeadCompleted;
        
        /// <remarks/>
        public event ExpenseGetByIDCompletedEventHandler ExpenseGetByIDCompleted;
        
        /// <remarks/>
        public event ExpenseDeleteByIDCompletedEventHandler ExpenseDeleteByIDCompleted;
        
        /// <remarks/>
        public event SelectExpenseHeadExpenseCompletedEventHandler SelectExpenseHeadExpenseCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseAdd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExpenseAdd(ExpenseInfo objInfo, string token) {
            this.Invoke("ExpenseAdd", new object[] {
                        objInfo,
                        token});
        }
        
        /// <remarks/>
        public void ExpenseAddAsync(ExpenseInfo objInfo, string token) {
            this.ExpenseAddAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void ExpenseAddAsync(ExpenseInfo objInfo, string token, object userState) {
            if ((this.ExpenseAddOperationCompleted == null)) {
                this.ExpenseAddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseAddOperationCompleted);
            }
            this.InvokeAsync("ExpenseAdd", new object[] {
                        objInfo,
                        token}, this.ExpenseAddOperationCompleted, userState);
        }
        
        private void OnExpenseAddOperationCompleted(object arg) {
            if ((this.ExpenseAddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseAddCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExpenseUpdate(ExpenseInfo objInfo, string token) {
            this.Invoke("ExpenseUpdate", new object[] {
                        objInfo,
                        token});
        }
        
        /// <remarks/>
        public void ExpenseUpdateAsync(ExpenseInfo objInfo, string token) {
            this.ExpenseUpdateAsync(objInfo, token, null);
        }
        
        /// <remarks/>
        public void ExpenseUpdateAsync(ExpenseInfo objInfo, string token, object userState) {
            if ((this.ExpenseUpdateOperationCompleted == null)) {
                this.ExpenseUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseUpdateOperationCompleted);
            }
            this.InvokeAsync("ExpenseUpdate", new object[] {
                        objInfo,
                        token}, this.ExpenseUpdateOperationCompleted, userState);
        }
        
        private void OnExpenseUpdateOperationCompleted(object arg) {
            if ((this.ExpenseUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseUpdateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseGetAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseInfo[] ExpenseGetAll(string token) {
            object[] results = this.Invoke("ExpenseGetAll", new object[] {
                        token});
            return ((ExpenseInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseGetAllAsync(string token) {
            this.ExpenseGetAllAsync(token, null);
        }
        
        /// <remarks/>
        public void ExpenseGetAllAsync(string token, object userState) {
            if ((this.ExpenseGetAllOperationCompleted == null)) {
                this.ExpenseGetAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseGetAllOperationCompleted);
            }
            this.InvokeAsync("ExpenseGetAll", new object[] {
                        token}, this.ExpenseGetAllOperationCompleted, userState);
        }
        
        private void OnExpenseGetAllOperationCompleted(object arg) {
            if ((this.ExpenseGetAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseGetAllCompleted(this, new ExpenseGetAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FilterByExpanseHead", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseInfo[] FilterByExpanseHead(int ExpenseHeadID, string token) {
            object[] results = this.Invoke("FilterByExpanseHead", new object[] {
                        ExpenseHeadID,
                        token});
            return ((ExpenseInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void FilterByExpanseHeadAsync(int ExpenseHeadID, string token) {
            this.FilterByExpanseHeadAsync(ExpenseHeadID, token, null);
        }
        
        /// <remarks/>
        public void FilterByExpanseHeadAsync(int ExpenseHeadID, string token, object userState) {
            if ((this.FilterByExpanseHeadOperationCompleted == null)) {
                this.FilterByExpanseHeadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFilterByExpanseHeadOperationCompleted);
            }
            this.InvokeAsync("FilterByExpanseHead", new object[] {
                        ExpenseHeadID,
                        token}, this.FilterByExpanseHeadOperationCompleted, userState);
        }
        
        private void OnFilterByExpanseHeadOperationCompleted(object arg) {
            if ((this.FilterByExpanseHeadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FilterByExpanseHeadCompleted(this, new FilterByExpanseHeadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseGetByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseInfo ExpenseGetByID(int ExpenseID, string token) {
            object[] results = this.Invoke("ExpenseGetByID", new object[] {
                        ExpenseID,
                        token});
            return ((ExpenseInfo)(results[0]));
        }
        
        /// <remarks/>
        public void ExpenseGetByIDAsync(int ExpenseID, string token) {
            this.ExpenseGetByIDAsync(ExpenseID, token, null);
        }
        
        /// <remarks/>
        public void ExpenseGetByIDAsync(int ExpenseID, string token, object userState) {
            if ((this.ExpenseGetByIDOperationCompleted == null)) {
                this.ExpenseGetByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseGetByIDOperationCompleted);
            }
            this.InvokeAsync("ExpenseGetByID", new object[] {
                        ExpenseID,
                        token}, this.ExpenseGetByIDOperationCompleted, userState);
        }
        
        private void OnExpenseGetByIDOperationCompleted(object arg) {
            if ((this.ExpenseGetByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseGetByIDCompleted(this, new ExpenseGetByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExpenseDeleteByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ExpenseDeleteByID(int ExpenseID, string token) {
            this.Invoke("ExpenseDeleteByID", new object[] {
                        ExpenseID,
                        token});
        }
        
        /// <remarks/>
        public void ExpenseDeleteByIDAsync(int ExpenseID, string token) {
            this.ExpenseDeleteByIDAsync(ExpenseID, token, null);
        }
        
        /// <remarks/>
        public void ExpenseDeleteByIDAsync(int ExpenseID, string token, object userState) {
            if ((this.ExpenseDeleteByIDOperationCompleted == null)) {
                this.ExpenseDeleteByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExpenseDeleteByIDOperationCompleted);
            }
            this.InvokeAsync("ExpenseDeleteByID", new object[] {
                        ExpenseID,
                        token}, this.ExpenseDeleteByIDOperationCompleted, userState);
        }
        
        private void OnExpenseDeleteByIDOperationCompleted(object arg) {
            if ((this.ExpenseDeleteByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExpenseDeleteByIDCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectExpenseHeadExpense", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ExpenseInfo[] SelectExpenseHeadExpense(string token) {
            object[] results = this.Invoke("SelectExpenseHeadExpense", new object[] {
                        token});
            return ((ExpenseInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void SelectExpenseHeadExpenseAsync(string token) {
            this.SelectExpenseHeadExpenseAsync(token, null);
        }
        
        /// <remarks/>
        public void SelectExpenseHeadExpenseAsync(string token, object userState) {
            if ((this.SelectExpenseHeadExpenseOperationCompleted == null)) {
                this.SelectExpenseHeadExpenseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectExpenseHeadExpenseOperationCompleted);
            }
            this.InvokeAsync("SelectExpenseHeadExpense", new object[] {
                        token}, this.SelectExpenseHeadExpenseOperationCompleted, userState);
        }
        
        private void OnSelectExpenseHeadExpenseOperationCompleted(object arg) {
            if ((this.SelectExpenseHeadExpenseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectExpenseHeadExpenseCompleted(this, new SelectExpenseHeadExpenseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class ExpenseInfo {
        
        private int expenseIDField;
        
        private int expenseHeadIDField;
        
        private string expenseHeadField;
        
        private decimal expenseField;
        
        private System.DateTime addedDateField;
        
        private string addedByField;
        
        private string editedByField;
        
        private string deletedByField;
        
        private bool isDeletedField;
        
        private bool isModifiedField;
        
        private bool isActiveField;
        
        private string noteField;
        
        private System.DateTime editedDateField;
        
        /// <remarks/>
        public int ExpenseID {
            get {
                return this.expenseIDField;
            }
            set {
                this.expenseIDField = value;
            }
        }
        
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
        public decimal Expense {
            get {
                return this.expenseField;
            }
            set {
                this.expenseField = value;
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
        public bool IsActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
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
    public delegate void ExpenseAddCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseUpdateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
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
    public delegate void ExpenseGetAllCompletedEventHandler(object sender, ExpenseGetAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseGetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseGetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void FilterByExpanseHeadCompletedEventHandler(object sender, FilterByExpanseHeadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FilterByExpanseHeadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FilterByExpanseHeadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseInfo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseGetByIDCompletedEventHandler(object sender, ExpenseGetByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExpenseGetByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExpenseGetByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void ExpenseDeleteByIDCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    public delegate void SelectExpenseHeadExpenseCompletedEventHandler(object sender, SelectExpenseHeadExpenseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectExpenseHeadExpenseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectExpenseHeadExpenseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ExpenseInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ExpenseInfo[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
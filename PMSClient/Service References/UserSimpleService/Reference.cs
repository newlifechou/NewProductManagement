﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMSClient.UserSimpleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DcUser", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class DcUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RealNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid RoleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateTime {
            get {
                return this.CreateTimeField;
            }
            set {
                if ((this.CreateTimeField.Equals(value) != true)) {
                    this.CreateTimeField = value;
                    this.RaisePropertyChanged("CreateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RealName {
            get {
                return this.RealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RealNameField, value) != true)) {
                    this.RealNameField = value;
                    this.RaisePropertyChanged("RealName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid RoleID {
            get {
                return this.RoleIDField;
            }
            set {
                if ((this.RoleIDField.Equals(value) != true)) {
                    this.RoleIDField = value;
                    this.RaisePropertyChanged("RoleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DcUserRole", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class DcUserRole : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtraInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GroupNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateTime {
            get {
                return this.CreateTimeField;
            }
            set {
                if ((this.CreateTimeField.Equals(value) != true)) {
                    this.CreateTimeField = value;
                    this.RaisePropertyChanged("CreateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExtraInformation {
            get {
                return this.ExtraInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtraInformationField, value) != true)) {
                    this.ExtraInformationField = value;
                    this.RaisePropertyChanged("ExtraInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GroupName {
            get {
                return this.GroupNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupNameField, value) != true)) {
                    this.GroupNameField = value;
                    this.RaisePropertyChanged("GroupName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DcUserAccess", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class DcUserAccess : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccessCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccessNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtraInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccessCode {
            get {
                return this.AccessCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AccessCodeField, value) != true)) {
                    this.AccessCodeField = value;
                    this.RaisePropertyChanged("AccessCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccessName {
            get {
                return this.AccessNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AccessNameField, value) != true)) {
                    this.AccessNameField = value;
                    this.RaisePropertyChanged("AccessName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExtraInformation {
            get {
                return this.ExtraInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtraInformationField, value) != true)) {
                    this.ExtraInformationField = value;
                    this.RaisePropertyChanged("ExtraInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserSimpleService.IUserSimpleService")]
    public interface IUserSimpleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetUser", ReplyAction="http://tempuri.org/IUserSimpleService/GetUserResponse")]
        PMSClient.UserSimpleService.DcUser GetUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetUser", ReplyAction="http://tempuri.org/IUserSimpleService/GetUserResponse")]
        System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUser> GetUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetRole", ReplyAction="http://tempuri.org/IUserSimpleService/GetRoleResponse")]
        PMSClient.UserSimpleService.DcUserRole GetRole(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetRole", ReplyAction="http://tempuri.org/IUserSimpleService/GetRoleResponse")]
        System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUserRole> GetRoleAsync(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetAccesses", ReplyAction="http://tempuri.org/IUserSimpleService/GetAccessesResponse")]
        PMSClient.UserSimpleService.DcUserAccess[] GetAccesses(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserSimpleService/GetAccesses", ReplyAction="http://tempuri.org/IUserSimpleService/GetAccessesResponse")]
        System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUserAccess[]> GetAccessesAsync(System.Guid roleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserSimpleServiceChannel : PMSClient.UserSimpleService.IUserSimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserSimpleServiceClient : System.ServiceModel.ClientBase<PMSClient.UserSimpleService.IUserSimpleService>, PMSClient.UserSimpleService.IUserSimpleService {
        
        public UserSimpleServiceClient() {
        }
        
        public UserSimpleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserSimpleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserSimpleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserSimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PMSClient.UserSimpleService.DcUser GetUser(string username, string password) {
            return base.Channel.GetUser(username, password);
        }
        
        public System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUser> GetUserAsync(string username, string password) {
            return base.Channel.GetUserAsync(username, password);
        }
        
        public PMSClient.UserSimpleService.DcUserRole GetRole(System.Guid roleId) {
            return base.Channel.GetRole(roleId);
        }
        
        public System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUserRole> GetRoleAsync(System.Guid roleId) {
            return base.Channel.GetRoleAsync(roleId);
        }
        
        public PMSClient.UserSimpleService.DcUserAccess[] GetAccesses(System.Guid roleId) {
            return base.Channel.GetAccesses(roleId);
        }
        
        public System.Threading.Tasks.Task<PMSClient.UserSimpleService.DcUserAccess[]> GetAccessesAsync(System.Guid roleId) {
            return base.Channel.GetAccessesAsync(roleId);
        }
    }
}

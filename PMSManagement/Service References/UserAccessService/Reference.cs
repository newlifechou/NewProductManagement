﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMSManagement.UserAccessService {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserAccessService.IUserAccessService")]
    public interface IUserAccessService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllUsers", ReplyAction="http://tempuri.org/IUserAccessService/GetAllUsersResponse")]
        PMSManagement.UserAccessService.DcUser[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllUsers", ReplyAction="http://tempuri.org/IUserAccessService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUser[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllRoles", ReplyAction="http://tempuri.org/IUserAccessService/GetAllRolesResponse")]
        PMSManagement.UserAccessService.DcUserRole[] GetAllRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllRoles", ReplyAction="http://tempuri.org/IUserAccessService/GetAllRolesResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserRole[]> GetAllRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllAccesses", ReplyAction="http://tempuri.org/IUserAccessService/GetAllAccessesResponse")]
        PMSManagement.UserAccessService.DcUserAccess[] GetAllAccesses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAllAccesses", ReplyAction="http://tempuri.org/IUserAccessService/GetAllAccessesResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserAccess[]> GetAllAccessesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/IsUserNameExsit", ReplyAction="http://tempuri.org/IUserAccessService/IsUserNameExsitResponse")]
        bool IsUserNameExsit(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/IsUserNameExsit", ReplyAction="http://tempuri.org/IUserAccessService/IsUserNameExsitResponse")]
        System.Threading.Tasks.Task<bool> IsUserNameExsitAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetUser", ReplyAction="http://tempuri.org/IUserAccessService/GetUserResponse")]
        PMSManagement.UserAccessService.DcUser GetUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetUser", ReplyAction="http://tempuri.org/IUserAccessService/GetUserResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUser> GetUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetRole", ReplyAction="http://tempuri.org/IUserAccessService/GetRoleResponse")]
        PMSManagement.UserAccessService.DcUserRole GetRole(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetRole", ReplyAction="http://tempuri.org/IUserAccessService/GetRoleResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserRole> GetRoleAsync(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAccesses", ReplyAction="http://tempuri.org/IUserAccessService/GetAccessesResponse")]
        PMSManagement.UserAccessService.DcUserAccess[] GetAccesses(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/GetAccesses", ReplyAction="http://tempuri.org/IUserAccessService/GetAccessesResponse")]
        System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserAccess[]> GetAccessesAsync(System.Guid roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddUser", ReplyAction="http://tempuri.org/IUserAccessService/AddUserResponse")]
        int AddUser(PMSManagement.UserAccessService.DcUser model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddUser", ReplyAction="http://tempuri.org/IUserAccessService/AddUserResponse")]
        System.Threading.Tasks.Task<int> AddUserAsync(PMSManagement.UserAccessService.DcUser model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddRole", ReplyAction="http://tempuri.org/IUserAccessService/AddRoleResponse")]
        int AddRole(PMSManagement.UserAccessService.DcUserRole model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddRole", ReplyAction="http://tempuri.org/IUserAccessService/AddRoleResponse")]
        System.Threading.Tasks.Task<int> AddRoleAsync(PMSManagement.UserAccessService.DcUserRole model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddAccess", ReplyAction="http://tempuri.org/IUserAccessService/AddAccessResponse")]
        int AddAccess(PMSManagement.UserAccessService.DcUserAccess model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/AddAccess", ReplyAction="http://tempuri.org/IUserAccessService/AddAccessResponse")]
        System.Threading.Tasks.Task<int> AddAccessAsync(PMSManagement.UserAccessService.DcUserAccess model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateUser", ReplyAction="http://tempuri.org/IUserAccessService/UpdateUserResponse")]
        int UpdateUser(PMSManagement.UserAccessService.DcUser model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateUser", ReplyAction="http://tempuri.org/IUserAccessService/UpdateUserResponse")]
        System.Threading.Tasks.Task<int> UpdateUserAsync(PMSManagement.UserAccessService.DcUser model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateRole", ReplyAction="http://tempuri.org/IUserAccessService/UpdateRoleResponse")]
        int UpdateRole(PMSManagement.UserAccessService.DcUserRole model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateRole", ReplyAction="http://tempuri.org/IUserAccessService/UpdateRoleResponse")]
        System.Threading.Tasks.Task<int> UpdateRoleAsync(PMSManagement.UserAccessService.DcUserRole model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateAccess", ReplyAction="http://tempuri.org/IUserAccessService/UpdateAccessResponse")]
        int UpdateAccess(PMSManagement.UserAccessService.DcUserAccess model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/UpdateAccess", ReplyAction="http://tempuri.org/IUserAccessService/UpdateAccessResponse")]
        System.Threading.Tasks.Task<int> UpdateAccessAsync(PMSManagement.UserAccessService.DcUserAccess model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteUser", ReplyAction="http://tempuri.org/IUserAccessService/DeleteUserResponse")]
        int DeleteUser(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteUser", ReplyAction="http://tempuri.org/IUserAccessService/DeleteUserResponse")]
        System.Threading.Tasks.Task<int> DeleteUserAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteRole", ReplyAction="http://tempuri.org/IUserAccessService/DeleteRoleResponse")]
        int DeleteRole(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteRole", ReplyAction="http://tempuri.org/IUserAccessService/DeleteRoleResponse")]
        System.Threading.Tasks.Task<int> DeleteRoleAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteAccess", ReplyAction="http://tempuri.org/IUserAccessService/DeleteAccessResponse")]
        int DeleteAccess(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserAccessService/DeleteAccess", ReplyAction="http://tempuri.org/IUserAccessService/DeleteAccessResponse")]
        System.Threading.Tasks.Task<int> DeleteAccessAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserAccessServiceChannel : PMSManagement.UserAccessService.IUserAccessService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserAccessServiceClient : System.ServiceModel.ClientBase<PMSManagement.UserAccessService.IUserAccessService>, PMSManagement.UserAccessService.IUserAccessService {
        
        public UserAccessServiceClient() {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccessServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserAccessServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PMSManagement.UserAccessService.DcUser[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUser[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public PMSManagement.UserAccessService.DcUserRole[] GetAllRoles() {
            return base.Channel.GetAllRoles();
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserRole[]> GetAllRolesAsync() {
            return base.Channel.GetAllRolesAsync();
        }
        
        public PMSManagement.UserAccessService.DcUserAccess[] GetAllAccesses() {
            return base.Channel.GetAllAccesses();
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserAccess[]> GetAllAccessesAsync() {
            return base.Channel.GetAllAccessesAsync();
        }
        
        public bool IsUserNameExsit(string userName) {
            return base.Channel.IsUserNameExsit(userName);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserNameExsitAsync(string userName) {
            return base.Channel.IsUserNameExsitAsync(userName);
        }
        
        public PMSManagement.UserAccessService.DcUser GetUser(string username, string password) {
            return base.Channel.GetUser(username, password);
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUser> GetUserAsync(string username, string password) {
            return base.Channel.GetUserAsync(username, password);
        }
        
        public PMSManagement.UserAccessService.DcUserRole GetRole(System.Guid roleId) {
            return base.Channel.GetRole(roleId);
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserRole> GetRoleAsync(System.Guid roleId) {
            return base.Channel.GetRoleAsync(roleId);
        }
        
        public PMSManagement.UserAccessService.DcUserAccess[] GetAccesses(System.Guid roleId) {
            return base.Channel.GetAccesses(roleId);
        }
        
        public System.Threading.Tasks.Task<PMSManagement.UserAccessService.DcUserAccess[]> GetAccessesAsync(System.Guid roleId) {
            return base.Channel.GetAccessesAsync(roleId);
        }
        
        public int AddUser(PMSManagement.UserAccessService.DcUser model) {
            return base.Channel.AddUser(model);
        }
        
        public System.Threading.Tasks.Task<int> AddUserAsync(PMSManagement.UserAccessService.DcUser model) {
            return base.Channel.AddUserAsync(model);
        }
        
        public int AddRole(PMSManagement.UserAccessService.DcUserRole model) {
            return base.Channel.AddRole(model);
        }
        
        public System.Threading.Tasks.Task<int> AddRoleAsync(PMSManagement.UserAccessService.DcUserRole model) {
            return base.Channel.AddRoleAsync(model);
        }
        
        public int AddAccess(PMSManagement.UserAccessService.DcUserAccess model) {
            return base.Channel.AddAccess(model);
        }
        
        public System.Threading.Tasks.Task<int> AddAccessAsync(PMSManagement.UserAccessService.DcUserAccess model) {
            return base.Channel.AddAccessAsync(model);
        }
        
        public int UpdateUser(PMSManagement.UserAccessService.DcUser model) {
            return base.Channel.UpdateUser(model);
        }
        
        public System.Threading.Tasks.Task<int> UpdateUserAsync(PMSManagement.UserAccessService.DcUser model) {
            return base.Channel.UpdateUserAsync(model);
        }
        
        public int UpdateRole(PMSManagement.UserAccessService.DcUserRole model) {
            return base.Channel.UpdateRole(model);
        }
        
        public System.Threading.Tasks.Task<int> UpdateRoleAsync(PMSManagement.UserAccessService.DcUserRole model) {
            return base.Channel.UpdateRoleAsync(model);
        }
        
        public int UpdateAccess(PMSManagement.UserAccessService.DcUserAccess model) {
            return base.Channel.UpdateAccess(model);
        }
        
        public System.Threading.Tasks.Task<int> UpdateAccessAsync(PMSManagement.UserAccessService.DcUserAccess model) {
            return base.Channel.UpdateAccessAsync(model);
        }
        
        public int DeleteUser(System.Guid id) {
            return base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteUserAsync(System.Guid id) {
            return base.Channel.DeleteUserAsync(id);
        }
        
        public int DeleteRole(System.Guid id) {
            return base.Channel.DeleteRole(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteRoleAsync(System.Guid id) {
            return base.Channel.DeleteRoleAsync(id);
        }
        
        public int DeleteAccess(System.Guid id) {
            return base.Channel.DeleteAccess(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAccessAsync(System.Guid id) {
            return base.Channel.DeleteAccessAsync(id);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMSClient.Sample {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DcSample", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class DcSample : PMSClient.Sample.DcModelBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GDMSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ICPOESField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IGAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoreInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalRequirementField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherTestResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PMINumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string POField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PermittivityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SampleForField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SampleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SampleTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThermalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TraceInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrackingStageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WeightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Composition {
            get {
                return this.CompositionField;
            }
            set {
                if ((object.ReferenceEquals(this.CompositionField, value) != true)) {
                    this.CompositionField = value;
                    this.RaisePropertyChanged("Composition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GDMS {
            get {
                return this.GDMSField;
            }
            set {
                if ((object.ReferenceEquals(this.GDMSField, value) != true)) {
                    this.GDMSField = value;
                    this.RaisePropertyChanged("GDMS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ICPOES {
            get {
                return this.ICPOESField;
            }
            set {
                if ((object.ReferenceEquals(this.ICPOESField, value) != true)) {
                    this.ICPOESField = value;
                    this.RaisePropertyChanged("ICPOES");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IGA {
            get {
                return this.IGAField;
            }
            set {
                if ((object.ReferenceEquals(this.IGAField, value) != true)) {
                    this.IGAField = value;
                    this.RaisePropertyChanged("IGA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MoreInformation {
            get {
                return this.MoreInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.MoreInformationField, value) != true)) {
                    this.MoreInformationField = value;
                    this.RaisePropertyChanged("MoreInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalRequirement {
            get {
                return this.OriginalRequirementField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalRequirementField, value) != true)) {
                    this.OriginalRequirementField = value;
                    this.RaisePropertyChanged("OriginalRequirement");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherTestResult {
            get {
                return this.OtherTestResultField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherTestResultField, value) != true)) {
                    this.OtherTestResultField = value;
                    this.RaisePropertyChanged("OtherTestResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PMINumber {
            get {
                return this.PMINumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PMINumberField, value) != true)) {
                    this.PMINumberField = value;
                    this.RaisePropertyChanged("PMINumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PO {
            get {
                return this.POField;
            }
            set {
                if ((object.ReferenceEquals(this.POField, value) != true)) {
                    this.POField = value;
                    this.RaisePropertyChanged("PO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Permittivity {
            get {
                return this.PermittivityField;
            }
            set {
                if ((object.ReferenceEquals(this.PermittivityField, value) != true)) {
                    this.PermittivityField = value;
                    this.RaisePropertyChanged("Permittivity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIDField, value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SampleFor {
            get {
                return this.SampleForField;
            }
            set {
                if ((object.ReferenceEquals(this.SampleForField, value) != true)) {
                    this.SampleForField = value;
                    this.RaisePropertyChanged("SampleFor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SampleID {
            get {
                return this.SampleIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SampleIDField, value) != true)) {
                    this.SampleIDField = value;
                    this.RaisePropertyChanged("SampleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SampleType {
            get {
                return this.SampleTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SampleTypeField, value) != true)) {
                    this.SampleTypeField = value;
                    this.RaisePropertyChanged("SampleType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Thermal {
            get {
                return this.ThermalField;
            }
            set {
                if ((object.ReferenceEquals(this.ThermalField, value) != true)) {
                    this.ThermalField = value;
                    this.RaisePropertyChanged("Thermal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TraceInformation {
            get {
                return this.TraceInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.TraceInformationField, value) != true)) {
                    this.TraceInformationField = value;
                    this.RaisePropertyChanged("TraceInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrackingStage {
            get {
                return this.TrackingStageField;
            }
            set {
                if ((object.ReferenceEquals(this.TrackingStageField, value) != true)) {
                    this.TrackingStageField = value;
                    this.RaisePropertyChanged("TrackingStage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((object.ReferenceEquals(this.WeightField, value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DcModelBase", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PMSClient.Sample.DcSample))]
    public partial class DcModelBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatorField;
        
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
        public string Creator {
            get {
                return this.CreatorField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatorField, value) != true)) {
                    this.CreatorField = value;
                    this.RaisePropertyChanged("Creator");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DcDeliveryItemSampleCheckModel", Namespace="http://schemas.datacontract.org/2004/07/PMSWCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class DcDeliveryItemSampleCheckModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DeliveryTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PMINumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SampleDeliveryInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SampleInformationField;
        
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
        public string Composition {
            get {
                return this.CompositionField;
            }
            set {
                if ((object.ReferenceEquals(this.CompositionField, value) != true)) {
                    this.CompositionField = value;
                    this.RaisePropertyChanged("Composition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DeliveryTime {
            get {
                return this.DeliveryTimeField;
            }
            set {
                if ((this.DeliveryTimeField.Equals(value) != true)) {
                    this.DeliveryTimeField = value;
                    this.RaisePropertyChanged("DeliveryTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PMINumber {
            get {
                return this.PMINumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PMINumberField, value) != true)) {
                    this.PMINumberField = value;
                    this.RaisePropertyChanged("PMINumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIDField, value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SampleDeliveryInformation {
            get {
                return this.SampleDeliveryInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.SampleDeliveryInformationField, value) != true)) {
                    this.SampleDeliveryInformationField = value;
                    this.RaisePropertyChanged("SampleDeliveryInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SampleInformation {
            get {
                return this.SampleInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.SampleInformationField, value) != true)) {
                    this.SampleInformationField = value;
                    this.RaisePropertyChanged("SampleInformation");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Sample.ISampleService")]
    public interface ISampleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleAll", ReplyAction="http://tempuri.org/ISampleService/GetSampleAllResponse")]
        PMSClient.Sample.DcSample[] GetSampleAll(int s, int t, string pminumber, string productid, string composition, string trackingstage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleAll", ReplyAction="http://tempuri.org/ISampleService/GetSampleAllResponse")]
        System.Threading.Tasks.Task<PMSClient.Sample.DcSample[]> GetSampleAllAsync(int s, int t, string pminumber, string productid, string composition, string trackingstage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleAllCount", ReplyAction="http://tempuri.org/ISampleService/GetSampleAllCountResponse")]
        int GetSampleAllCount(string pminumber, string productid, string composition, string trackingstage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleAllCount", ReplyAction="http://tempuri.org/ISampleService/GetSampleAllCountResponse")]
        System.Threading.Tasks.Task<int> GetSampleAllCountAsync(string pminumber, string productid, string composition, string trackingstage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleByPMINumberCount", ReplyAction="http://tempuri.org/ISampleService/GetSampleByPMINumberCountResponse")]
        int GetSampleByPMINumberCount(string pminumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/GetSampleByPMINumberCount", ReplyAction="http://tempuri.org/ISampleService/GetSampleByPMINumberCountResponse")]
        System.Threading.Tasks.Task<int> GetSampleByPMINumberCountAsync(string pminumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AddSample", ReplyAction="http://tempuri.org/ISampleService/AddSampleResponse")]
        void AddSample(PMSClient.Sample.DcSample model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AddSample", ReplyAction="http://tempuri.org/ISampleService/AddSampleResponse")]
        System.Threading.Tasks.Task AddSampleAsync(PMSClient.Sample.DcSample model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/UpdateSample", ReplyAction="http://tempuri.org/ISampleService/UpdateSampleResponse")]
        void UpdateSample(PMSClient.Sample.DcSample model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/UpdateSample", ReplyAction="http://tempuri.org/ISampleService/UpdateSampleResponse")]
        System.Threading.Tasks.Task UpdateSampleAsync(PMSClient.Sample.DcSample model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/CheckDeliveryItemSampleStatus", ReplyAction="http://tempuri.org/ISampleService/CheckDeliveryItemSampleStatusResponse")]
        PMSClient.Sample.DcDeliveryItemSampleCheckModel[] CheckDeliveryItemSampleStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/CheckDeliveryItemSampleStatus", ReplyAction="http://tempuri.org/ISampleService/CheckDeliveryItemSampleStatusResponse")]
        System.Threading.Tasks.Task<PMSClient.Sample.DcDeliveryItemSampleCheckModel[]> CheckDeliveryItemSampleStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleServiceChannel : PMSClient.Sample.ISampleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<PMSClient.Sample.ISampleService>, PMSClient.Sample.ISampleService {
        
        public SampleServiceClient() {
        }
        
        public SampleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PMSClient.Sample.DcSample[] GetSampleAll(int s, int t, string pminumber, string productid, string composition, string trackingstage) {
            return base.Channel.GetSampleAll(s, t, pminumber, productid, composition, trackingstage);
        }
        
        public System.Threading.Tasks.Task<PMSClient.Sample.DcSample[]> GetSampleAllAsync(int s, int t, string pminumber, string productid, string composition, string trackingstage) {
            return base.Channel.GetSampleAllAsync(s, t, pminumber, productid, composition, trackingstage);
        }
        
        public int GetSampleAllCount(string pminumber, string productid, string composition, string trackingstage) {
            return base.Channel.GetSampleAllCount(pminumber, productid, composition, trackingstage);
        }
        
        public System.Threading.Tasks.Task<int> GetSampleAllCountAsync(string pminumber, string productid, string composition, string trackingstage) {
            return base.Channel.GetSampleAllCountAsync(pminumber, productid, composition, trackingstage);
        }
        
        public int GetSampleByPMINumberCount(string pminumber) {
            return base.Channel.GetSampleByPMINumberCount(pminumber);
        }
        
        public System.Threading.Tasks.Task<int> GetSampleByPMINumberCountAsync(string pminumber) {
            return base.Channel.GetSampleByPMINumberCountAsync(pminumber);
        }
        
        public void AddSample(PMSClient.Sample.DcSample model) {
            base.Channel.AddSample(model);
        }
        
        public System.Threading.Tasks.Task AddSampleAsync(PMSClient.Sample.DcSample model) {
            return base.Channel.AddSampleAsync(model);
        }
        
        public void UpdateSample(PMSClient.Sample.DcSample model) {
            base.Channel.UpdateSample(model);
        }
        
        public System.Threading.Tasks.Task UpdateSampleAsync(PMSClient.Sample.DcSample model) {
            return base.Channel.UpdateSampleAsync(model);
        }
        
        public PMSClient.Sample.DcDeliveryItemSampleCheckModel[] CheckDeliveryItemSampleStatus() {
            return base.Channel.CheckDeliveryItemSampleStatus();
        }
        
        public System.Threading.Tasks.Task<PMSClient.Sample.DcDeliveryItemSampleCheckModel[]> CheckDeliveryItemSampleStatusAsync() {
            return base.Channel.CheckDeliveryItemSampleStatusAsync();
        }
    }
}

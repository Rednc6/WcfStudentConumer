﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfStudentConumer.WcfServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfStudentService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfStudentService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _nameField;
        
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
        public string _name {
            get {
                return this._nameField;
            }
            set {
                if ((object.ReferenceEquals(this._nameField, value) != true)) {
                    this._nameField = value;
                    this.RaisePropertyChanged("_name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceReference.IStudentService")]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetData", ReplyAction="http://tempuri.org/IStudentService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetData", ReplyAction="http://tempuri.org/IStudentService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IStudentService/GetDataUsingDataContractResponse")]
        WcfStudentConumer.WcfServiceReference.CompositeType GetDataUsingDataContract(WcfStudentConumer.WcfServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IStudentService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.CompositeType> GetDataUsingDataContractAsync(WcfStudentConumer.WcfServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/AddStudent", ReplyAction="http://tempuri.org/IStudentService/AddStudentResponse")]
        WcfStudentConumer.WcfServiceReference.Student AddStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/AddStudent", ReplyAction="http://tempuri.org/IStudentService/AddStudentResponse")]
        System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.Student> AddStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/FindStudent", ReplyAction="http://tempuri.org/IStudentService/FindStudentResponse")]
        string FindStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/FindStudent", ReplyAction="http://tempuri.org/IStudentService/FindStudentResponse")]
        System.Threading.Tasks.Task<string> FindStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/RemoveStudent", ReplyAction="http://tempuri.org/IStudentService/RemoveStudentResponse")]
        void RemoveStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/RemoveStudent", ReplyAction="http://tempuri.org/IStudentService/RemoveStudentResponse")]
        System.Threading.Tasks.Task RemoveStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/EditStudent", ReplyAction="http://tempuri.org/IStudentService/EditStudentResponse")]
        void EditStudent(string findName, string replacerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/EditStudent", ReplyAction="http://tempuri.org/IStudentService/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(string findName, string replacerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetAllStudents", ReplyAction="http://tempuri.org/IStudentService/GetAllStudentsResponse")]
        WcfStudentConumer.WcfServiceReference.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetAllStudents", ReplyAction="http://tempuri.org/IStudentService/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.Student[]> GetAllStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : WcfStudentConumer.WcfServiceReference.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<WcfStudentConumer.WcfServiceReference.IStudentService>, WcfStudentConumer.WcfServiceReference.IStudentService {
        
        public StudentServiceClient() {
        }
        
        public StudentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfStudentConumer.WcfServiceReference.CompositeType GetDataUsingDataContract(WcfStudentConumer.WcfServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.CompositeType> GetDataUsingDataContractAsync(WcfStudentConumer.WcfServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WcfStudentConumer.WcfServiceReference.Student AddStudent(string name) {
            return base.Channel.AddStudent(name);
        }
        
        public System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.Student> AddStudentAsync(string name) {
            return base.Channel.AddStudentAsync(name);
        }
        
        public string FindStudent(string name) {
            return base.Channel.FindStudent(name);
        }
        
        public System.Threading.Tasks.Task<string> FindStudentAsync(string name) {
            return base.Channel.FindStudentAsync(name);
        }
        
        public void RemoveStudent(string name) {
            base.Channel.RemoveStudent(name);
        }
        
        public System.Threading.Tasks.Task RemoveStudentAsync(string name) {
            return base.Channel.RemoveStudentAsync(name);
        }
        
        public void EditStudent(string findName, string replacerName) {
            base.Channel.EditStudent(findName, replacerName);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(string findName, string replacerName) {
            return base.Channel.EditStudentAsync(findName, replacerName);
        }
        
        public WcfStudentConumer.WcfServiceReference.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<WcfStudentConumer.WcfServiceReference.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
    }
}

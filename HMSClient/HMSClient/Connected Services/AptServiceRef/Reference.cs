﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMSClient.AptServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AllAppointmentDetails", Namespace="http://schemas.datacontract.org/2004/07/HMSService")]
    [System.SerializableAttribute()]
    public partial class AllAppointmentDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string doctorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string patientNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan slot_endField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan slot_startField;
        
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
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string doctorName {
            get {
                return this.doctorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.doctorNameField, value) != true)) {
                    this.doctorNameField = value;
                    this.RaisePropertyChanged("doctorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string patientName {
            get {
                return this.patientNameField;
            }
            set {
                if ((object.ReferenceEquals(this.patientNameField, value) != true)) {
                    this.patientNameField = value;
                    this.RaisePropertyChanged("patientName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan slot_end {
            get {
                return this.slot_endField;
            }
            set {
                if ((this.slot_endField.Equals(value) != true)) {
                    this.slot_endField = value;
                    this.RaisePropertyChanged("slot_end");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan slot_start {
            get {
                return this.slot_startField;
            }
            set {
                if ((this.slot_startField.Equals(value) != true)) {
                    this.slot_startField = value;
                    this.RaisePropertyChanged("slot_start");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AppointmentDetails", Namespace="http://schemas.datacontract.org/2004/07/HMSService")]
    [System.SerializableAttribute()]
    public partial class AppointmentDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int doctorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int patientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan slot_endField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan slot_startField;
        
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
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int doctorId {
            get {
                return this.doctorIdField;
            }
            set {
                if ((this.doctorIdField.Equals(value) != true)) {
                    this.doctorIdField = value;
                    this.RaisePropertyChanged("doctorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int patientId {
            get {
                return this.patientIdField;
            }
            set {
                if ((this.patientIdField.Equals(value) != true)) {
                    this.patientIdField = value;
                    this.RaisePropertyChanged("patientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan slot_end {
            get {
                return this.slot_endField;
            }
            set {
                if ((this.slot_endField.Equals(value) != true)) {
                    this.slot_endField = value;
                    this.RaisePropertyChanged("slot_end");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan slot_start {
            get {
                return this.slot_startField;
            }
            set {
                if ((this.slot_startField.Equals(value) != true)) {
                    this.slot_startField = value;
                    this.RaisePropertyChanged("slot_start");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AptServiceRef.IAppointmentService")]
    public interface IAppointmentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointments", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentsResponse")]
        HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointments", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentsResponse")]
        System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointmentByDoctorId", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentByDoctorIdResponse")]
        HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointmentByDoctorId(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointmentByDoctorId", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentByDoctorIdResponse")]
        System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentByDoctorIdAsync(int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointmentByPatientId", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentByPatientIdResponse")]
        HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointmentByPatientId(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/ViewAppointmentByPatientId", ReplyAction="http://tempuri.org/IAppointmentService/ViewAppointmentByPatientIdResponse")]
        System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentByPatientIdAsync(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/BookAppointment", ReplyAction="http://tempuri.org/IAppointmentService/BookAppointmentResponse")]
        string BookAppointment(HMSClient.AptServiceRef.AppointmentDetails appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/BookAppointment", ReplyAction="http://tempuri.org/IAppointmentService/BookAppointmentResponse")]
        System.Threading.Tasks.Task<string> BookAppointmentAsync(HMSClient.AptServiceRef.AppointmentDetails appointment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/GetAvailableSlots", ReplyAction="http://tempuri.org/IAppointmentService/GetAvailableSlotsResponse")]
        System.TimeSpan[] GetAvailableSlots(System.DateTime selectedDate, int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/GetAvailableSlots", ReplyAction="http://tempuri.org/IAppointmentService/GetAvailableSlotsResponse")]
        System.Threading.Tasks.Task<System.TimeSpan[]> GetAvailableSlotsAsync(System.DateTime selectedDate, int doctorId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/DeleteAppointment", ReplyAction="http://tempuri.org/IAppointmentService/DeleteAppointmentResponse")]
        string DeleteAppointment(int doctorId, int patientId, System.DateTime date, System.TimeSpan slotStart, System.TimeSpan slotEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppointmentService/DeleteAppointment", ReplyAction="http://tempuri.org/IAppointmentService/DeleteAppointmentResponse")]
        System.Threading.Tasks.Task<string> DeleteAppointmentAsync(int doctorId, int patientId, System.DateTime date, System.TimeSpan slotStart, System.TimeSpan slotEnd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppointmentServiceChannel : HMSClient.AptServiceRef.IAppointmentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppointmentServiceClient : System.ServiceModel.ClientBase<HMSClient.AptServiceRef.IAppointmentService>, HMSClient.AptServiceRef.IAppointmentService {
        
        public AppointmentServiceClient() {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppointmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointments() {
            return base.Channel.ViewAppointments();
        }
        
        public System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentsAsync() {
            return base.Channel.ViewAppointmentsAsync();
        }
        
        public HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointmentByDoctorId(int doctorId) {
            return base.Channel.ViewAppointmentByDoctorId(doctorId);
        }
        
        public System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentByDoctorIdAsync(int doctorId) {
            return base.Channel.ViewAppointmentByDoctorIdAsync(doctorId);
        }
        
        public HMSClient.AptServiceRef.AllAppointmentDetails[] ViewAppointmentByPatientId(int patientId) {
            return base.Channel.ViewAppointmentByPatientId(patientId);
        }
        
        public System.Threading.Tasks.Task<HMSClient.AptServiceRef.AllAppointmentDetails[]> ViewAppointmentByPatientIdAsync(int patientId) {
            return base.Channel.ViewAppointmentByPatientIdAsync(patientId);
        }
        
        public string BookAppointment(HMSClient.AptServiceRef.AppointmentDetails appointment) {
            return base.Channel.BookAppointment(appointment);
        }
        
        public System.Threading.Tasks.Task<string> BookAppointmentAsync(HMSClient.AptServiceRef.AppointmentDetails appointment) {
            return base.Channel.BookAppointmentAsync(appointment);
        }
        
        public System.TimeSpan[] GetAvailableSlots(System.DateTime selectedDate, int doctorId) {
            return base.Channel.GetAvailableSlots(selectedDate, doctorId);
        }
        
        public System.Threading.Tasks.Task<System.TimeSpan[]> GetAvailableSlotsAsync(System.DateTime selectedDate, int doctorId) {
            return base.Channel.GetAvailableSlotsAsync(selectedDate, doctorId);
        }
        
        public string DeleteAppointment(int doctorId, int patientId, System.DateTime date, System.TimeSpan slotStart, System.TimeSpan slotEnd) {
            return base.Channel.DeleteAppointment(doctorId, patientId, date, slotStart, slotEnd);
        }
        
        public System.Threading.Tasks.Task<string> DeleteAppointmentAsync(int doctorId, int patientId, System.DateTime date, System.TimeSpan slotStart, System.TimeSpan slotEnd) {
            return base.Channel.DeleteAppointmentAsync(doctorId, patientId, date, slotStart, slotEnd);
        }
    }
}

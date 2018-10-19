﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProteinTrackerClient.ProteinTrackerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int GoalField;
        
        private int TotalField;
        
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Goal {
            get {
                return this.GoalField;
            }
            set {
                if ((this.GoalField.Equals(value) != true)) {
                    this.GoalField = value;
                    this.RaisePropertyChanged("Goal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProteinTrackerService.ProteinTrackerWebServiceSoap")]
    public interface ProteinTrackerWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddProtein", ReplyAction="*")]
        int AddProtein(int amount, int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddProtein", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userID);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        ProteinTrackerClient.ProteinTrackerService.AddUserResponse AddUser(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> AddUserAsync(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request);
        
        // CODEGEN: Generating message contract since element name UsersListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsersList", ReplyAction="*")]
        ProteinTrackerClient.ProteinTrackerService.UsersListResponse UsersList(ProteinTrackerClient.ProteinTrackerService.UsersListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UsersList", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.UsersListResponse> UsersListAsync(ProteinTrackerClient.ProteinTrackerService.UsersListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUser", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody Body;
        
        public AddUserRequest() {
        }
        
        public AddUserRequest(ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int goal;
        
        public AddUserRequestBody() {
        }
        
        public AddUserRequestBody(string name, int goal) {
            this.name = name;
            this.goal = goal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.AddUserResponseBody Body;
        
        public AddUserResponse() {
        }
        
        public AddUserResponse(ProteinTrackerClient.ProteinTrackerService.AddUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddUserResult;
        
        public AddUserResponseBody() {
        }
        
        public AddUserResponseBody(int AddUserResult) {
            this.AddUserResult = AddUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UsersListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UsersList", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.UsersListRequestBody Body;
        
        public UsersListRequest() {
        }
        
        public UsersListRequest(ProteinTrackerClient.ProteinTrackerService.UsersListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UsersListRequestBody {
        
        public UsersListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UsersListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UsersListResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.UsersListResponseBody Body;
        
        public UsersListResponse() {
        }
        
        public UsersListResponse(ProteinTrackerClient.ProteinTrackerService.UsersListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UsersListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProteinTrackerClient.ProteinTrackerService.User[] UsersListResult;
        
        public UsersListResponseBody() {
        }
        
        public UsersListResponseBody(ProteinTrackerClient.ProteinTrackerService.User[] UsersListResult) {
            this.UsersListResult = UsersListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProteinTrackerWebServiceSoapChannel : ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProteinTrackerWebServiceSoapClient : System.ServiceModel.ClientBase<ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap>, ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap {
        
        public ProteinTrackerWebServiceSoapClient() {
        }
        
        public ProteinTrackerWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProteinTrackerWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackerWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackerWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddProtein(int amount, int userID) {
            return base.Channel.AddProtein(amount, userID);
        }
        
        public System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userID) {
            return base.Channel.AddProteinAsync(amount, userID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.AddUserResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap.AddUser(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request) {
            return base.Channel.AddUser(request);
        }
        
        public int AddUser(string name, int goal) {
            ProteinTrackerClient.ProteinTrackerService.AddUserRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddUserRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            ProteinTrackerClient.ProteinTrackerService.AddUserResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap)(this)).AddUser(inValue);
            return retVal.Body.AddUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap.AddUserAsync(ProteinTrackerClient.ProteinTrackerService.AddUserRequest request) {
            return base.Channel.AddUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddUserResponse> AddUserAsync(string name, int goal) {
            ProteinTrackerClient.ProteinTrackerService.AddUserRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddUserRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap)(this)).AddUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.UsersListResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap.UsersList(ProteinTrackerClient.ProteinTrackerService.UsersListRequest request) {
            return base.Channel.UsersList(request);
        }
        
        public ProteinTrackerClient.ProteinTrackerService.User[] UsersList() {
            ProteinTrackerClient.ProteinTrackerService.UsersListRequest inValue = new ProteinTrackerClient.ProteinTrackerService.UsersListRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.UsersListRequestBody();
            ProteinTrackerClient.ProteinTrackerService.UsersListResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap)(this)).UsersList(inValue);
            return retVal.Body.UsersListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.UsersListResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap.UsersListAsync(ProteinTrackerClient.ProteinTrackerService.UsersListRequest request) {
            return base.Channel.UsersListAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.UsersListResponse> UsersListAsync() {
            ProteinTrackerClient.ProteinTrackerService.UsersListRequest inValue = new ProteinTrackerClient.ProteinTrackerService.UsersListRequest();
            inValue.Body = new ProteinTrackerClient.ProteinTrackerService.UsersListRequestBody();
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackerWebServiceSoap)(this)).UsersListAsync(inValue);
        }
    }
}
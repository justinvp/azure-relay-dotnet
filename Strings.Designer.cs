﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Relay {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Relay.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument is out of range. It should be between {0} and {1}..
        /// </summary>
        internal static string ArgumentOutOfRange {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; cannot exceed {1} characters..
        /// </summary>
        internal static string ArgumentStringTooBig {
            get {
                return ResourceManager.GetString("ArgumentStringTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; contained character &apos;{1}&apos; which is not allowed because it is reserved in the Uri scheme..
        /// </summary>
        internal static string CharacterReservedForUriScheme {
            get {
                return ResourceManager.GetString("CharacterReservedForUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate connection ID..
        /// </summary>
        internal static string DuplicateConnectionId {
            get {
                return ResourceManager.GetString("DuplicateConnectionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because the entity has been closed or aborted..
        /// </summary>
        internal static string EntityClosedOrAborted {
            get {
                return ResourceManager.GetString("EntityClosedOrAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This &apos;{0}&apos; instance has already been started once. To start another instance, please create a new &apos;{0}&apos; object and start that..
        /// </summary>
        internal static string InstanceAlreadyRunning {
            get {
                return ResourceManager.GetString("InstanceAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified Async result object is null or invalid..
        /// </summary>
        internal static string InvalidAsyncResult {
            get {
                return ResourceManager.GetString("InvalidAsyncResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        internal static string InvalidEncoding {
            get {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided URI scheme &apos;{0}&apos; is invalid; expected &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidUriScheme {
            get {
                return ResourceManager.GetString("InvalidUriScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception in {0}::{1} - {2}..
        /// </summary>
        internal static string net_log_exception {
            get {
                return ResourceManager.GetString("net_log_exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is not supported for a relative URI..
        /// </summary>
        internal static string net_uri_NotAbsolute {
            get {
                return ResourceManager.GetString("net_uri_NotAbsolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket request or response operation was called with unsupported protocol(s)..
        /// </summary>
        internal static string net_WebSockets_AcceptUnsupportedProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_AcceptUnsupportedProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket has already been started..
        /// </summary>
        internal static string net_WebSockets_AlreadyStarted {
            get {
                return ResourceManager.GetString("net_WebSockets_AlreadyStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The byte array must have a length of at least &apos;{0}&apos; bytes..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_InternalBuffer {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_InternalBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the &apos;{0}&apos; parameter ({1}) must be less than or equal to {2}..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_TooBig {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_TooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be a value greater than {0}..
        /// </summary>
        internal static string net_WebSockets_ArgumentOutOfRange_TooSmall {
            get {
                return ResourceManager.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server returned status code &apos;{0}&apos; when status code &apos;101&apos; was expected..
        /// </summary>
        internal static string net_WebSockets_Connect101Expected {
            get {
                return ResourceManager.GetString("net_WebSockets_Connect101Expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket protocol &apos;{0}&apos; is invalid because it contains the invalid character &apos;{1}&apos;..
        /// </summary>
        internal static string net_WebSockets_InvalidCharInProtocolString {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidCharInProtocolString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty string is not a valid subprotocol value. Please use \&quot;null\&quot; to specify no value..
        /// </summary>
        internal static string net_WebSockets_InvalidEmptySubProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidEmptySubProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket schemes must be registered with the HttpWebRequest class..
        /// </summary>
        internal static string net_WebSockets_InvalidRegistration {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; header value &apos;{1}&apos; is invalid..
        /// </summary>
        internal static string net_WebSockets_InvalidResponseHeader {
            get {
                return ResourceManager.GetString("net_WebSockets_InvalidResponseHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate protocols are not allowed: &apos;{0}&apos;..
        /// </summary>
        internal static string net_WebSockets_NoDuplicateProtocol {
            get {
                return ResourceManager.GetString("net_WebSockets_NoDuplicateProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebSocket is not connected..
        /// </summary>
        internal static string net_WebSockets_NotConnected {
            get {
                return ResourceManager.GetString("net_WebSockets_NotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only Uris starting with &apos;ws://&apos; or &apos;wss://&apos; are supported..
        /// </summary>
        internal static string net_WebSockets_Scheme {
            get {
                return ResourceManager.GetString("net_WebSockets_Scheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to the remote server.
        /// </summary>
        internal static string net_webstatus_ConnectFailure {
            get {
                return ResourceManager.GetString("net_webstatus_ConnectFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation cannot be performed because the object has been closed or aborted..
        /// </summary>
        internal static string ObjectClosedOrAborted {
            get {
                return ResourceManager.GetString("ObjectClosedOrAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is read-only and cannot be modified..
        /// </summary>
        internal static string ObjectIsReadOnly {
            get {
                return ResourceManager.GetString("ObjectIsReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is not in an open state..
        /// </summary>
        internal static string ObjectNotOpened {
            get {
                return ResourceManager.GetString("ObjectNotOpened", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a non-negative timeout value. The provided value was {1}..
        /// </summary>
        internal static string TimeoutMustBeNonNegative {
            get {
                return ResourceManager.GetString("TimeoutMustBeNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a positive timeout value. The provided value was {1}..
        /// </summary>
        internal static string TimeoutMustBePositive {
            get {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;Audience&apos; value..
        /// </summary>
        internal static string TokenMissingAudience {
            get {
                return ResourceManager.GetString("TokenMissingAudience", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided token does not specify the &apos;ExpiresOn&apos; value..
        /// </summary>
        internal static string TokenMissingExpiresOn {
            get {
                return ResourceManager.GetString("TokenMissingExpiresOn", resourceCulture);
            }
        }
    }
}

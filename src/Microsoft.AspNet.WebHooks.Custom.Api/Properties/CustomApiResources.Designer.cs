﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNet.WebHooks.Properties {
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
    internal class CustomApiResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CustomApiResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.WebHooks.Properties.CustomApiResources", typeof(CustomApiResources).Assembly);
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
        ///   Looks up a localized string similar to The WebHook test launcher is not enabled. To enable the test launcher for testing purposes, please set the &apos;{0}&apos; application setting to &apos;{1}&apos;. The test launcher should not be enabled in production environments..
        /// </summary>
        internal static string LaunchController_NotEnabled {
            get {
                return ResourceManager.GetString("LaunchController_NotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete WebHooks due to error: {0}.
        /// </summary>
        internal static string RegistrationController_DeleteAllFailure {
            get {
                return ResourceManager.GetString("RegistrationController_DeleteAllFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete WebHook due to error: {0}.
        /// </summary>
        internal static string RegistrationController_DeleteFailure {
            get {
                return ResourceManager.GetString("RegistrationController_DeleteFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following filters are not valid: &apos;{0}&apos;. A list of valid filters can be obtained from the path &apos;{1}&apos;..
        /// </summary>
        internal static string RegistrationController_InvalidFilters {
            get {
                return ResourceManager.GetString("RegistrationController_InvalidFilters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; implementation of &apos;{1}&apos; caused an exception: {2}.
        /// </summary>
        internal static string RegistrationController_RegistrarException {
            get {
                return ResourceManager.GetString("RegistrationController_RegistrarException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; implementation of &apos;{1}&apos; resulted in an HTTP response with status code {2}.
        /// </summary>
        internal static string RegistrationController_RegistrarStatusCode {
            get {
                return ResourceManager.GetString("RegistrationController_RegistrarStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not register WebHook due to error: {0}.
        /// </summary>
        internal static string RegistrationController_RegistrationFailure {
            get {
                return ResourceManager.GetString("RegistrationController_RegistrationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not update WebHook due to error: {0}.
        /// </summary>
        internal static string RegistrationController_UpdateFailure {
            get {
                return ResourceManager.GetString("RegistrationController_UpdateFailure", resourceCulture);
            }
        }
    }
}

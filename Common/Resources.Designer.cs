﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.Plugins.Common {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.Plugins.Common.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Assembly located: {0}.
        /// </summary>
        internal static string Resolver_AssemblyLocated {
            get {
                return ResourceManager.GetString("Resolver_AssemblyLocated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No search paths were supplied..
        /// </summary>
        internal static string Resolver_ConstructorNoPaths {
            get {
                return ResourceManager.GetString("Resolver_ConstructorNoPaths", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to resolve assembly..
        /// </summary>
        internal static string Resolver_FailedToResolveAssembly {
            get {
                return ResourceManager.GetString("Resolver_FailedToResolveAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding AssemblyResolver to current AppDomain assembly resolution..
        /// </summary>
        internal static string Resolver_Initialize {
            get {
                return ResourceManager.GetString("Resolver_Initialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly rejected: incorrect version &apos;{0}&apos;.
        /// </summary>
        internal static string Resolver_RejectedAssembly {
            get {
                return ResourceManager.GetString("Resolver_RejectedAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to resolve assembly &apos;{0}&apos;, requested by &apos;{1}&apos;.
        /// </summary>
        internal static string Resolver_ResolvingAssembly {
            get {
                return ResourceManager.GetString("Resolver_ResolvingAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not instantiate analyzers from &apos;{0}&apos;. 
        ///
        ///Error: {1}.
        /// </summary>
        internal static string Scanner_AnalyzerInstantiationFail {
            get {
                return ResourceManager.GetString("Scanner_AnalyzerInstantiationFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded analyser: {0}.
        /// </summary>
        internal static string Scanner_AnalyzerLoaded {
            get {
                return ResourceManager.GetString("Scanner_AnalyzerLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded: {0} analysers..
        /// </summary>
        internal static string Scanner_AnalyzersLoadSuccess {
            get {
                return ResourceManager.GetString("Scanner_AnalyzersLoadSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded assembly: {0}.
        /// </summary>
        internal static string Scanner_AssemblyLoadSuccess {
            get {
                return ResourceManager.GetString("Scanner_AssemblyLoadSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No analyzers found in assembly..
        /// </summary>
        internal static string Scanner_NoAnalysers {
            get {
                return ResourceManager.GetString("Scanner_NoAnalysers", resourceCulture);
            }
        }
    }
}

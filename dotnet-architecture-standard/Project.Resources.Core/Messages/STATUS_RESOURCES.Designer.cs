﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Resources.Core.Messages {
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
    public class STATUS_RESOURCES {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal STATUS_RESOURCES() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Project.Resources.Core.Messages.STATUS_RESOURCES", typeof(STATUS_RESOURCES).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ativo.
        /// </summary>
        public static string ACTIVE {
            get {
                return ResourceManager.GetString("ACTIVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aprovado.
        /// </summary>
        public static string APPROVED {
            get {
                return ResourceManager.GetString("APPROVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reprovado.
        /// </summary>
        public static string DISAPPROVED {
            get {
                return ResourceManager.GetString("DISAPPROVED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Em Avaliação.
        /// </summary>
        public static string EVALUATION {
            get {
                return ResourceManager.GetString("EVALUATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inativo.
        /// </summary>
        public static string INACTIVE {
            get {
                return ResourceManager.GetString("INACTIVE", resourceCulture);
            }
        }
    }
}
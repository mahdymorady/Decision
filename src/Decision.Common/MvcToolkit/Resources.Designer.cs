﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decision.Common.MvcToolkit {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NTierMvcFramework.Common.MvcToolkit.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to امکان حذف وجود ندارد؛ رکورد مورد نظر توسط کاربر دیگری در شبکه حذف شده است..
        /// </summary>
        internal static string RecordDeletedByAnotherUserOnDeleting {
            get {
                return ResourceManager.GetString("RecordDeletedByAnotherUserOnDeleting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to امکان ذخیره سازی تغییرات وجود ندارد؛ رکورد مورد نظر توسط کاربر دیگری در شبکه حذف شده است..
        /// </summary>
        internal static string RecordDeletedByAnotherUserOnEditing {
            get {
                return ResourceManager.GetString("RecordDeletedByAnotherUserOnEditing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to عملیات حذف لغو شد؛ رکورد مورد نظر توسط کاربر دیگری در شبکه تغییر کرده است.
        ///برای حذف رکورد دوباره بر روی دکمه حذف کلیک کنید..
        /// </summary>
        internal static string RecordModifiedByAnotherUserOnDeleting {
            get {
                return ResourceManager.GetString("RecordModifiedByAnotherUserOnDeleting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to عملیات ویرایش لغو شد؛ رکورد مورد نظر توسط کاربر دیگری در شبکه تغییر کرده است.
        ///برای اعمال تغییرات، دوباره برروی دکمه ذخیره کلیک کنید..
        /// </summary>
        internal static string RecordModifiedByAnotherUserOnEditing {
            get {
                return ResourceManager.GetString("RecordModifiedByAnotherUserOnEditing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to امکان ذخیره سازی تغییرات وجود ندارد. دوباره سعی کنید، و اگر مشکل برطرف نشد با مدیریت سیستم تماس بگیرید..
        /// </summary>
        internal static string UnableToSaveChanges {
            get {
                return ResourceManager.GetString("UnableToSaveChanges", resourceCulture);
            }
        }
    }
}

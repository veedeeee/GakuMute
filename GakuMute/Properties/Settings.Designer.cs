﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GakuMute.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsAutoMuteEnabled {
            get {
                return ((bool)(this["IsAutoMuteEnabled"]));
            }
            set {
                this["IsAutoMuteEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public short VolumeInForeground {
            get {
                return ((short)(this["VolumeInForeground"]));
            }
            set {
                this["VolumeInForeground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public short VolumeInBackground {
            get {
                return ((short)(this["VolumeInBackground"]));
            }
            set {
                this["VolumeInBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsLaunchUmamusumeWhenGakuMuteHasLaunched {
            get {
                return ((bool)(this["IsLaunchUmamusumeWhenGakuMuteHasLaunched"]));
            }
            set {
                this["IsLaunchUmamusumeWhenGakuMuteHasLaunched"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsLaunchGakuMuteWhenWindowsHasBooted {
            get {
                return ((bool)(this["IsLaunchGakuMuteWhenWindowsHasBooted"]));
            }
            set {
                this["IsLaunchGakuMuteWhenWindowsHasBooted"] = value;
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yal.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>%USERPROFILE%\Desktop</string>
  <string>%APPDATA%\Microsoft\Windows\Start Menu</string>
  <string>%ProgramData%\Microsoft\Windows\Start Menu\Programs</string>
  <string>%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection FoldersToIndex {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FoldersToIndex"]));
            }
            set {
                this["FoldersToIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("exe,lnk,txt,pdf,mkv,mp4,avi,mp3,doc,docx,ppt,pptx,odt,odp,xls,xlsx")]
        public string Extensions {
            get {
                return ((string)(this["Extensions"]));
            }
            set {
                this["Extensions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Subdirectories {
            get {
                return ((bool)(this["Subdirectories"]));
            }
            set {
                this["Subdirectories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1970-01-01")]
        public global::System.DateTime DateLastIndexed {
            get {
                return ((global::System.DateTime)(this["DateLastIndexed"]));
            }
            set {
                this["DateLastIndexed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int Opacity {
            get {
                return ((int)(this["Opacity"]));
            }
            set {
                this["Opacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool VAlignment {
            get {
                return ((bool)(this["VAlignment"]));
            }
            set {
                this["VAlignment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HAlignment {
            get {
                return ((bool)(this["HAlignment"]));
            }
            set {
                this["HAlignment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point Location {
            get {
                return ((global::System.Drawing.Point)(this["Location"]));
            }
            set {
                this["Location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TopMost {
            get {
                return ((bool)(this["TopMost"]));
            }
            set {
                this["TopMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MoveWithCtrl {
            get {
                return ((bool)(this["MoveWithCtrl"]));
            }
            set {
                this["MoveWithCtrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Space")]
        public global::System.Windows.Forms.Keys FocusKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["FocusKey"]));
            }
            set {
                this["FocusKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ALT")]
        public global::Yal.FsModifier FocusModifier {
            get {
                return ((global::Yal.FsModifier)(this["FocusModifier"]));
            }
            set {
                this["FocusModifier"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int AutoIndexingInterval {
            get {
                return ((int)(this["AutoIndexingInterval"]));
            }
            set {
                this["AutoIndexingInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Autostart {
            get {
                return ((bool)(this["Autostart"]));
            }
            set {
                this["Autostart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Gray")]
        public global::System.Drawing.Color InterfaceColor {
            get {
                return ((global::System.Drawing.Color)(this["InterfaceColor"]));
            }
            set {
                this["InterfaceColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int MaxFetched {
            get {
                return ((int)(this["MaxFetched"]));
            }
            set {
                this["MaxFetched"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int MaxVisible {
            get {
                return ((int)(this["MaxVisible"]));
            }
            set {
                this["MaxVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int SearchDelay {
            get {
                return ((int)(this["SearchDelay"]));
            }
            set {
                this["SearchDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExtensionInFileName {
            get {
                return ((bool)(this["ExtensionInFileName"]));
            }
            set {
                this["ExtensionInFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoIndexing {
            get {
                return ((bool)(this["AutoIndexing"]));
            }
            set {
                this["AutoIndexing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MatchAnywhere {
            get {
                return ((bool)(this["MatchAnywhere"]));
            }
            set {
                this["MatchAnywhere"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int MaxHistorySize {
            get {
                return ((int)(this["MaxHistorySize"]));
            }
            set {
                this["MaxHistorySize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("999")]
        public int MaxHistoryVisible {
            get {
                return ((int)(this["MaxHistoryVisible"]));
            }
            set {
                this["MaxHistoryVisible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection FoldersToExclude {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FoldersToExclude"]));
            }
            set {
                this["FoldersToExclude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PluginSelectionsInHistory {
            get {
                return ((bool)(this["PluginSelectionsInHistory"]));
            }
            set {
                this["PluginSelectionsInHistory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MaxVisiblePluginItems {
            get {
                return ((int)(this["MaxVisiblePluginItems"]));
            }
            set {
                this["MaxVisiblePluginItems"] = value;
            }
        }
    }
}

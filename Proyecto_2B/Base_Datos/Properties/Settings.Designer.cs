﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base_Datos.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ANGEL;Initial Catalog=Tienda_Musical_Base_prueba;Integrated Security=" +
            "True")]
        public string Tienda_Musical_Base_pruebaConnectionString {
            get {
                return ((string)(this["Tienda_Musical_Base_pruebaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KEVIN-SISA-17;Initial Catalog=Tienda_Musical;Integrated Security=True" +
            "")]
        public string Tienda_MusicalConnectionString {
            get {
                return ((string)(this["Tienda_MusicalConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-KL07H5O1;Initial Catalog=Tienda_Musical;Integrated Security=Tr" +
            "ue")]
        public string Tienda_MusicalConnectionString1 {
            get {
                return ((string)(this["Tienda_MusicalConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=kevin-servidor.database.windows.net;Initial Catalog=Proyecto_Musical;" +
            "User ID=kevin;Password=davidSC1999")]
        public string Proyecto_MusicalConnectionString {
            get {
                return ((string)(this["Proyecto_MusicalConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-KL07H5O1;Initial Catalog=Tienda_Musical_2;Integrated Security=" +
            "True")]
        public string Tienda_Musical_2ConnectionString {
            get {
                return ((string)(this["Tienda_Musical_2ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=kevin-servidor.database.windows.net;Initial Catalog=Tienda_Musica;Use" +
            "r ID=kevin;Password=davidSC1999")]
        public string Tienda_MusicaConnectionString {
            get {
                return ((string)(this["Tienda_MusicaConnectionString"]));
            }
        }
    }
}

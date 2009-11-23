﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace NPanday.Model {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/AutomationExtensibility", IsNullable=false)]
    public partial class Extensibility {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Addin", typeof(ExtensibilityAddin))]
        [System.Xml.Serialization.XmlElementAttribute("HostApplication", typeof(ExtensibilityHostApplication))]
        [System.Xml.Serialization.XmlElementAttribute("ToolsOptionsPage", typeof(ExtensibilityToolsOptionsPageCategory[]))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ExtensibilityAddin {
        
        private string[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AboutBoxDetails", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("AboutIconData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Assembly", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CommandLineSafe", typeof(string), DataType="integer")]
        [System.Xml.Serialization.XmlElementAttribute("CommandPreload", typeof(string), DataType="integer")]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FriendlyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FullClassName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LoadBehavior", typeof(string), DataType="integer")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/AutomationExtensibility", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        AboutBoxDetails,
        
        /// <remarks/>
        AboutIconData,
        
        /// <remarks/>
        Assembly,
        
        /// <remarks/>
        CommandLineSafe,
        
        /// <remarks/>
        CommandPreload,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        FriendlyName,
        
        /// <remarks/>
        FullClassName,
        
        /// <remarks/>
        LoadBehavior,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ExtensibilityHostApplication {
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Version", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/AutomationExtensibility", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        Name,
        
        /// <remarks/>
        Version,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ExtensibilityToolsOptionsPageCategory {
        
        private ExtensibilityToolsOptionsPageCategorySubCategory[] subCategoryField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubCategory")]
        public ExtensibilityToolsOptionsPageCategorySubCategory[] SubCategory {
            get {
                return this.subCategoryField;
            }
            set {
                this.subCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ExtensibilityToolsOptionsPageCategorySubCategory {
        
        private string[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Assembly", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FullClassName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/AutomationExtensibility", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        /// <remarks/>
        Assembly,
        
        /// <remarks/>
        FullClassName,
    }
}

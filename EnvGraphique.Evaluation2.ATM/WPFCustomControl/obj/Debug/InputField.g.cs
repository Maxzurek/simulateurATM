﻿#pragma checksum "..\..\InputField.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E77D80020E0BB7F4B79503497EB1EEC25079505C4B0E612B417F5110BACAFBF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFCustomControl;


namespace WPFCustomControl {
    
    
    /// <summary>
    /// InputField
    /// </summary>
    public partial class InputField : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\InputField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\InputField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fieldNameLabel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\InputField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox field;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\InputField.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label tooltipLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFCustomControl;component/inputfield.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InputField.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\InputField.xaml"
            ((WPFCustomControl.InputField)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.fieldNameLabel = ((System.Windows.Controls.Label)(target));
            
            #line 22 "..\..\InputField.xaml"
            this.fieldNameLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.fieldName_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.field = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\InputField.xaml"
            this.field.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.field_MouseDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\InputField.xaml"
            this.field.GotFocus += new System.Windows.RoutedEventHandler(this.field_GotFocus);
            
            #line default
            #line hidden
            
            #line 24 "..\..\InputField.xaml"
            this.field.LostFocus += new System.Windows.RoutedEventHandler(this.field_LostFocus);
            
            #line default
            #line hidden
            
            #line 25 "..\..\InputField.xaml"
            this.field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.field_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tooltipLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

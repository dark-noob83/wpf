﻿#pragma checksum "..\..\..\register_client.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E205A8169B5F750ADE220AEC97902BAF8C94022E"
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
using System.Windows.Controls.Ribbon;
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// register_client
    /// </summary>
    public partial class register_client : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterCNameInput;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterCFamilyInput;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterCIDInput;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterCPhoneNumberInput;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegisterCEmailInput;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label usernameLable;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\register_client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label passwordLable;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/register_client.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\register_client.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RegisterCNameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RegisterCFamilyInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RegisterCIDInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RegisterCPhoneNumberInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RegisterCEmailInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.usernameLable = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.passwordLable = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 149 "..\..\..\register_client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClientRegisterEnter);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 157 "..\..\..\register_client.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Loginclicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


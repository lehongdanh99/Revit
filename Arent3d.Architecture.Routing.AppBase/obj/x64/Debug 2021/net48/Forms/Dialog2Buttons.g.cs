﻿#pragma checksum "..\..\..\..\..\Forms\Dialog2Buttons.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E6CFB76B57093E2F24AA20D94976BD4D1A3F9F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Arent3d.Architecture.Routing.AppBase.Forms;
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


namespace Arent3d.Architecture.Routing.AppBase.Forms {
    
    
    /// <summary>
    /// Dialog2Buttons
    /// </summary>
    public partial class Dialog2Buttons : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arent3d.Architecture.Routing.AppBase.Forms.Dialog2Buttons root;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Left;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Right;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Arent3d.Architecture.Routing.AppBase;V1.0.21.1122;component/forms/dialog2buttons" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.root = ((Arent3d.Architecture.Routing.AppBase.Forms.Dialog2Buttons)(target));
            return;
            case 2:
            this.Left = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
            this.Left.Click += new System.Windows.RoutedEventHandler(this.Left_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Right = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\..\Forms\Dialog2Buttons.xaml"
            this.Right.Click += new System.Windows.RoutedEventHandler(this.Right_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


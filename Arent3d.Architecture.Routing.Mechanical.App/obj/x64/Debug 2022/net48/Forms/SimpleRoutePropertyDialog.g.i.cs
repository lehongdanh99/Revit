﻿#pragma checksum "..\..\..\..\..\Forms\SimpleRoutePropertyDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CBF27D604221E22C12373978C2042E85DF9F4F2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Arent3d.Architecture.Routing.AppBase.Forms;
using Arent3d.Architecture.Routing.Mechanical.App.Forms;
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


namespace Arent3d.Architecture.Routing.Mechanical.App.Forms {
    
    
    /// <summary>
    /// SimpleRoutePropertyDialog
    /// </summary>
    public partial class SimpleRoutePropertyDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Forms\SimpleRoutePropertyDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arent3d.Architecture.Routing.Mechanical.App.Forms.SimpleFromToEditControl FromToEdit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Arent3d.Architecture.Routing.Mechanical.App;V1.0.21.1214;component/forms/simpler" +
                    "outepropertydialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\SimpleRoutePropertyDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FromToEdit = ((Arent3d.Architecture.Routing.Mechanical.App.Forms.SimpleFromToEditControl)(target));
            return;
            case 2:
            
            #line 26 "..\..\..\..\..\Forms\SimpleRoutePropertyDialog.xaml"
            ((Arent3d.Architecture.Routing.AppBase.Forms.Dialog2Buttons)(target)).LeftOnClick += new Arent3d.Architecture.Routing.AppBase.Forms.ClickEventHandler(this.Dialog2Buttons_OnLeftOnClick);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\Forms\SimpleRoutePropertyDialog.xaml"
            ((Arent3d.Architecture.Routing.AppBase.Forms.Dialog2Buttons)(target)).RightOnClick += new Arent3d.Architecture.Routing.AppBase.Forms.ClickEventHandler(this.Dialog2Buttons_OnRightOnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


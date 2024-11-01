﻿#pragma checksum "..\..\..\..\..\Forms\ContentDisplayDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E7726746BED191B54A54AFED2BC87623178B3969"
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
    /// ContentDisplayDialog
    /// </summary>
    public partial class ContentDisplayDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDisplaySwitching;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExportFile;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Arent3d.Architecture.Routing.AppBase;V1.0.21.1122;component/forms/contentdisplay" +
                    "dialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
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
            this.DtGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.DtGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DataGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.Button_Update);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnDisplaySwitching = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnDisplaySwitching.Click += new System.Windows.RoutedEventHandler(this.Button_DisplaySwitching);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnExportFile = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnExportFile.Click += new System.Windows.RoutedEventHandler(this.Button_ExportFile);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.Button_Save);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\..\Forms\ContentDisplayDialog.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.Button_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F12825DC8C1FCD66F815FC512CCC1647639218BD"
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
using Arent3d.Architecture.Routing.AppBase.Forms.ValueConverters;
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
    /// SimpleFromToEditControl
    /// </summary>
    public partial class SimpleFromToEditControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 120 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FromHeightSetting;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromLocationTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arent3d.Architecture.Routing.AppBase.Forms.NumericUpDownEx FromFixedHeightNumericUpDown;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ToHeightSetting;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ToLocationTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arent3d.Architecture.Routing.AppBase.Forms.NumericUpDownEx ToFixedHeightNumericUpDown;
        
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
            System.Uri resourceLocater = new System.Uri("/Arent3d.Architecture.Routing.Mechanical.App;V1.0.21.1214;component/forms/simplef" +
                    "romtoeditcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            
            #line 65 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SystemTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 91 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiameterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FromHeightSetting = ((System.Windows.Controls.CheckBox)(target));
            
            #line 122 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.FromHeightSetting.Checked += new System.Windows.RoutedEventHandler(this.Height_OnChecked);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.FromHeightSetting.Unchecked += new System.Windows.RoutedEventHandler(this.Height_OnUnchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FromLocationTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 128 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.FromLocationTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LocationTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FromFixedHeightNumericUpDown = ((Arent3d.Architecture.Routing.AppBase.Forms.NumericUpDownEx)(target));
            
            #line 149 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.FromFixedHeightNumericUpDown.ValueChanged += new ControlLib.ValueChangedEventHandler(this.FromFixedHeightNumericUpDown_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ToHeightSetting = ((System.Windows.Controls.CheckBox)(target));
            
            #line 207 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.ToHeightSetting.Checked += new System.Windows.RoutedEventHandler(this.ToHeight_OnChecked);
            
            #line default
            #line hidden
            
            #line 208 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.ToHeightSetting.Unchecked += new System.Windows.RoutedEventHandler(this.ToHeight_OnUnchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ToLocationTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 213 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.ToLocationTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LocationTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ToFixedHeightNumericUpDown = ((Arent3d.Architecture.Routing.AppBase.Forms.NumericUpDownEx)(target));
            
            #line 234 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            this.ToFixedHeightNumericUpDown.ValueChanged += new ControlLib.ValueChangedEventHandler(this.ToFixedHeightNumericUpDown_OnValueChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 274 "..\..\..\..\..\Forms\SimpleFromToEditControl.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AvoidTypeComboBox_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


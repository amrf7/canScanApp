﻿#pragma checksum "..\..\..\Ventanas\CaptureWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F97A167F54C9A9D2174F9FDAD3923492BD370EB897C6B440D69245F6226D478A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using Microsoft.Windows.Themes;
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
using canScanApp;


namespace canScanApp {
    
    
    /// <summary>
    /// CaptureWindow
    /// </summary>
    public partial class CaptureWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 572 "..\..\..\Ventanas\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeWindow;
        
        #line default
        #line hidden
        
        
        #line 613 "..\..\..\Ventanas\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox1;
        
        #line default
        #line hidden
        
        
        #line 634 "..\..\..\Ventanas\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fileType;
        
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
            System.Uri resourceLocater = new System.Uri("/canScanApp;component/ventanas/capturewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\CaptureWindow.xaml"
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
            this.closeWindow = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            
            #line 607 "..\..\..\Ventanas\CaptureWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            
            #line 608 "..\..\..\Ventanas\CaptureWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Textboxx);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textbox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 620 "..\..\..\Ventanas\CaptureWindow.xaml"
            this.textbox1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Textbooxx);
            
            #line default
            #line hidden
            return;
            case 4:
            this.fileType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 642 "..\..\..\Ventanas\CaptureWindow.xaml"
            this.fileType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.fileType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 655 "..\..\..\Ventanas\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveFile);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


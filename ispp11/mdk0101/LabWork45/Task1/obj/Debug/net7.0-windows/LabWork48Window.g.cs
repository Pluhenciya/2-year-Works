﻿#pragma checksum "..\..\..\LabWork48Window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E224EC68E61DC9D18C69527EFCA2DFE8E1CA9121"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Task1;


namespace Task1 {
    
    
    /// <summary>
    /// LabWork48Window
    /// </summary>
    public partial class LabWork48Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\LabWork48Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button simpleInsertAuthorButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\LabWork48Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertGetIdAuthorBuuton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\LabWork48Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectBookByPriceButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\LabWork48Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid contentDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Task1;component/labwork48window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LabWork48Window.xaml"
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
            this.simpleInsertAuthorButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\LabWork48Window.xaml"
            this.simpleInsertAuthorButton.Click += new System.Windows.RoutedEventHandler(this.SimpleInsertAuthorButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.insertGetIdAuthorBuuton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\LabWork48Window.xaml"
            this.insertGetIdAuthorBuuton.Click += new System.Windows.RoutedEventHandler(this.InsertGetIdAuthorBuuton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.selectBookByPriceButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\LabWork48Window.xaml"
            this.selectBookByPriceButton.Click += new System.Windows.RoutedEventHandler(this.SelectBookByPriceButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.contentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

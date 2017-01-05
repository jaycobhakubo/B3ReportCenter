﻿#pragma checksum "..\..\..\View\ReportView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "76302C91177E4F39532CCF0836330CB9"
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


namespace B3ReportCenter.View {
    
    
    /// <summary>
    /// ReportView
    /// </summary>
    public partial class ReportView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition ReportMenuColumn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter ReportsTransitionControl;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border errBackground;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse errIcon;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtblckErr;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdrSettingMenuCol;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\View\ReportView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbx_ReportList;
        
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
            System.Uri resourceLocater = new System.Uri("/B3ReportCenter;component/view/reportview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ReportView.xaml"
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
            this.ReportMenuColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 2:
            this.ReportsTransitionControl = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 3:
            this.errBackground = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.errIcon = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.txtblckErr = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.brdrSettingMenuCol = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.lstbx_ReportList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


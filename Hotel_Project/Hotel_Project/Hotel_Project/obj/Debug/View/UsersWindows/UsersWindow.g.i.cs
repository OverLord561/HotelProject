﻿#pragma checksum "..\..\..\..\View\UsersWindows\UsersWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "890843BD8E2193B295F193824684EB55"
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


namespace Hotel_Project.View.UsersWindows {
    
    
    /// <summary>
    /// UsersWindow
    /// </summary>
    public partial class UsersWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listUsers;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdLastInfo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_DateStart;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_DateEnd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/Hotel_Project;component/view/userswindows/userswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
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
            this.listUsers = ((System.Windows.Controls.ListView)(target));
            
            #line 13 "..\..\..\..\View\UsersWindows\UsersWindow.xaml"
            this.listUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listUsers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grdLastInfo = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.lbl_DateStart = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbl_DateEnd = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.listOrders = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


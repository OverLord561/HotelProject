﻿#pragma checksum "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "398C8BF3BF9B344C3BEC9485A8D7BB37"
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


namespace Hotel_Project.View.RoomsWindows {
    
    
    /// <summary>
    /// FreeRoomWindow
    /// </summary>
    public partial class FreeRoomWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_Hotels;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbx_RoomTypes;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listRooms;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_freeRoom;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Hotel_Project;component/view/roomswindows/freeroomwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
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
            this.cbx_Hotels = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
            this.cbx_Hotels.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbx_Hotels_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbx_RoomTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
            this.cbx_RoomTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbx_RoomTypes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listRooms = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.btn_freeRoom = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
            this.btn_freeRoom.Click += new System.Windows.RoutedEventHandler(this.btn_freeRoom_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\RoomsWindows\FreeRoomWindow.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

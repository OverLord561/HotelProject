﻿#pragma checksum "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B9959EAD6D9EF1592285C9115BEC7730"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18408
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


namespace Hotel_Project.View.HotelsWindows {
    
    
    /// <summary>
    /// AddHotelWindow
    /// </summary>
    public partial class AddHotelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Name;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Address;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Description;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Stars;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_RoomsCount;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txt_Photo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image picture;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_addHotel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancelHotel;
        
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
            System.Uri resourceLocater = new System.Uri("/Hotel_Project;component/view/hotelswindows/addhotelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
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
            this.txt_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_Address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_Stars = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_RoomsCount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txt_Photo = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
            this.txt_Photo.Click += new System.Windows.RoutedEventHandler(this.txt_Photo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.picture = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.btn_addHotel = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
            this.btn_addHotel.Click += new System.Windows.RoutedEventHandler(this.btn_addHotel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_cancelHotel = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\View\HotelsWindows\AddHotelWindow.xaml"
            this.btn_cancelHotel.Click += new System.Windows.RoutedEventHandler(this.btn_cancelHotel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

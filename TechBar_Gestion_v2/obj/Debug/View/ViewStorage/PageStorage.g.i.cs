﻿#pragma checksum "..\..\..\..\View\ViewStorage\PageStorage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97E9ECD47877372197BFC4D27C4C97B7CF6A459D1CC965A1CFD96F18839E82A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
using TechBar_Gestion_v2.View.ViewStorage;


namespace TechBar_Gestion_v2.View.ViewStorage {
    
    
    /// <summary>
    /// PageStorage
    /// </summary>
    public partial class PageStorage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatagridBeer;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup_modbeer;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup_delbeer;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup_addbeer;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Name;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Description;
        
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
            System.Uri resourceLocater = new System.Uri("/TechBar_Gestion_v2;component/view/viewstorage/pagestorage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
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
            this.DatagridBeer = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 62 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_addbeer);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 66 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Refresh);
            
            #line default
            #line hidden
            return;
            case 6:
            this.popup_modbeer = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 7:
            
            #line 81 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Cancel_mod);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 82 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Confirm_mod);
            
            #line default
            #line hidden
            return;
            case 9:
            this.popup_delbeer = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 10:
            
            #line 95 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Cancel_del);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 96 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Confirm_del);
            
            #line default
            #line hidden
            return;
            case 12:
            this.popup_addbeer = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 13:
            this.TB_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.TB_Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 115 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_add_Cancel);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 116 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_add_Confirm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 36 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Mod);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 39 "..\..\..\..\View\ViewStorage\PageStorage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Click_BTN_Remove);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

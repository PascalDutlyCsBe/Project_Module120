﻿#pragma checksum "..\..\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207DF1387353C73C169351861FFAF32BBC2D7CD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt_120;
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


namespace Projekt_120 {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Main;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel SwitchContainer;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Avatar;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekt_120;component/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainMenu.xaml"
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
            this.Main = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            
            #line 17 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseDown);
            
            #line default
            #line hidden
            
            #line 17 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.TabItem_KeyDown);
            
            #line default
            #line hidden
            
            #line 18 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseUp_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.TabItem_KeyDown);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseUp_2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.TabItem_KeyDown);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseUp_3);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SwitchContainer = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 7:
            this.Avatar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 26 "..\..\MainMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\forms\windows.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "676F16472E61535B17D5E50B6B89B69007E8EC7C0DB1E13EA8AFCCF31CF7431B"
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
using practika.forms;


namespace practika.forms {
    
    
    /// <summary>
    /// windows
    /// </summary>
    public partial class windows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbname;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbauthor;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbyears;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbgenre;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbdecs;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbsearch;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbut;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button renameBut;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delBut;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbut;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\forms\windows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgbooks;
        
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
            System.Uri resourceLocater = new System.Uri("/practika;component/forms/windows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\forms\windows.xaml"
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
            this.tbname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbauthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbyears = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\forms\windows.xaml"
            this.tbyears.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbgenre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbdecs = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbsearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\forms\windows.xaml"
            this.tbsearch.KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addbut = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\forms\windows.xaml"
            this.addbut.Click += new System.Windows.RoutedEventHandler(this.AddNewRows);
            
            #line default
            #line hidden
            return;
            case 8:
            this.renameBut = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\forms\windows.xaml"
            this.renameBut.Click += new System.Windows.RoutedEventHandler(this.UpdateSelectedRow);
            
            #line default
            #line hidden
            return;
            case 9:
            this.delBut = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\forms\windows.xaml"
            this.delBut.Click += new System.Windows.RoutedEventHandler(this.DeleteSelectedRow);
            
            #line default
            #line hidden
            return;
            case 10:
            this.exitbut = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\forms\windows.xaml"
            this.exitbut.Click += new System.Windows.RoutedEventHandler(this.clickexit);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgbooks = ((System.Windows.Controls.DataGrid)(target));
            
            #line 106 "..\..\..\forms\windows.xaml"
            this.dgbooks.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgbooks_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\forms\secondform.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8773841697893F692BCE3F9D8D252B0D9862A07F622F8B6FCBEE062649A6921F"
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
    /// secondform
    /// </summary>
    public partial class secondform : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\forms\secondform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbForDB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\forms\secondform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label namebooks;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\forms\secondform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label aftor;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\forms\secondform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dsate;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\forms\secondform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDecs;
        
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
            System.Uri resourceLocater = new System.Uri("/practika;component/forms/secondform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\forms\secondform.xaml"
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
            this.lbForDB = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\forms\secondform.xaml"
            this.lbForDB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.namebooks = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.aftor = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.dsate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.tbDecs = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 46 "..\..\..\forms\secondform.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clickexit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\CheckBankAccountWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9067D0787F00516A48E2FB91BD81B851E6A130CCD57123B1ABDFAE75C57AB3A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WPF_UI;


namespace WPF_UI {
    
    
    /// <summary>
    /// CheckBankAccountWindow
    /// </summary>
    public partial class CheckBankAccountWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ok;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bankaccountnumber;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mynamecombobox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mybranchnumbercombobox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox collectionclearence;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\CheckBankAccountWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_UI;component/checkbankaccountwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CheckBankAccountWindow.xaml"
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
            this.logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.ok = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CheckBankAccountWindow.xaml"
            this.ok.Click += new System.Windows.RoutedEventHandler(this.ok_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bankaccountnumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\CheckBankAccountWindow.xaml"
            this.bankaccountnumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextAllow1);
            
            #line default
            #line hidden
            
            #line 22 "..\..\CheckBankAccountWindow.xaml"
            this.bankaccountnumber.GotFocus += new System.Windows.RoutedEventHandler(this.bankaccountnumberenter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\CheckBankAccountWindow.xaml"
            this.bankaccountnumber.LostFocus += new System.Windows.RoutedEventHandler(this.bankaccountnumberleave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mynamecombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\CheckBankAccountWindow.xaml"
            this.mynamecombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.mynamecombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mybranchnumbercombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\CheckBankAccountWindow.xaml"
            this.mybranchnumbercombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.mybranchnumbercombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.collectionclearence = ((System.Windows.Controls.CheckBox)(target));
            
            #line 48 "..\..\CheckBankAccountWindow.xaml"
            this.collectionclearence.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_collectionclearence);
            
            #line default
            #line hidden
            
            #line 48 "..\..\CheckBankAccountWindow.xaml"
            this.collectionclearence.Unchecked += new System.Windows.RoutedEventHandler(this.UncheckBox_collectionclearence);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\CheckBankAccountWindow.xaml"
            this.cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\FinalizeGRWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66986CC52B7F6320B5A9C108BAA8DC54A94FE56BBC9BE3F92AE6F4D91BD6986E"
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
    /// FinalizeGRWindow
    /// </summary>
    public partial class FinalizeGRWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addrequest;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox family;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Private;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mail;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\FinalizeGRWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox newsletter;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\FinalizeGRWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WPF_UI;component/finalizegrwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FinalizeGRWindow.xaml"
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
            this.addrequest = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\FinalizeGRWindow.xaml"
            this.addrequest.Click += new System.Windows.RoutedEventHandler(this.addrequest_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.family = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\FinalizeGRWindow.xaml"
            this.family.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChangedFamily);
            
            #line default
            #line hidden
            
            #line 30 "..\..\FinalizeGRWindow.xaml"
            this.family.GotFocus += new System.Windows.RoutedEventHandler(this.familyenter);
            
            #line default
            #line hidden
            
            #line 30 "..\..\FinalizeGRWindow.xaml"
            this.family.LostFocus += new System.Windows.RoutedEventHandler(this.familyleave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Private = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\FinalizeGRWindow.xaml"
            this.Private.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChangedPrivate);
            
            #line default
            #line hidden
            
            #line 33 "..\..\FinalizeGRWindow.xaml"
            this.Private.GotFocus += new System.Windows.RoutedEventHandler(this.privateenter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\FinalizeGRWindow.xaml"
            this.Private.LostFocus += new System.Windows.RoutedEventHandler(this.privateleave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mail = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\FinalizeGRWindow.xaml"
            this.mail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChangedMail);
            
            #line default
            #line hidden
            
            #line 36 "..\..\FinalizeGRWindow.xaml"
            this.mail.GotFocus += new System.Windows.RoutedEventHandler(this.mailenter);
            
            #line default
            #line hidden
            
            #line 36 "..\..\FinalizeGRWindow.xaml"
            this.mail.LostFocus += new System.Windows.RoutedEventHandler(this.mailleave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.newsletter = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\FinalizeGRWindow.xaml"
            this.newsletter.Checked += new System.Windows.RoutedEventHandler(this.newsletter_Checked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\FinalizeGRWindow.xaml"
            this.newsletter.Unchecked += new System.Windows.RoutedEventHandler(this.newsletter_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\FinalizeGRWindow.xaml"
            this.cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

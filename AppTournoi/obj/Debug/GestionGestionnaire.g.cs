﻿#pragma checksum "..\..\GestionGestionnaire.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B7AD77836D5D7EB5F640F2BF270FD13398F78EF6824E0DC4D4E0E36C080D94CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppTournoi;
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


namespace AppTournoi {
    
    
    /// <summary>
    /// GestionGestionnaire
    /// </summary>
    public partial class GestionGestionnaire : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvGestionnaireGestion;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ContextMenuListTournoi;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuContextSupprimerGestionnaire;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuContextModifierGestionnaire;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label text;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbMDP;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbVerifMDP;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\GestionGestionnaire.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAjouterGestionnaire;
        
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
            System.Uri resourceLocater = new System.Uri("/AppTournoi;component/gestiongestionnaire.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionGestionnaire.xaml"
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
            this.lvGestionnaireGestion = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.ContextMenuListTournoi = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 3:
            this.MenuContextSupprimerGestionnaire = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\GestionGestionnaire.xaml"
            this.MenuContextSupprimerGestionnaire.Click += new System.Windows.RoutedEventHandler(this.MenuContextSupprimerGesionnaire_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenuContextModifierGestionnaire = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\GestionGestionnaire.xaml"
            this.MenuContextModifierGestionnaire.Click += new System.Windows.RoutedEventHandler(this.MenuContextModifierGestionnaire_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 43 "..\..\GestionGestionnaire.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Deco_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.text = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\GestionGestionnaire.xaml"
            this.tbLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbChanger);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbMDP = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\GestionGestionnaire.xaml"
            this.tbMDP.PasswordChanged += new System.Windows.RoutedEventHandler(this.tbChanger);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbVerifMDP = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 54 "..\..\GestionGestionnaire.xaml"
            this.tbVerifMDP.PasswordChanged += new System.Windows.RoutedEventHandler(this.tbChanger);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonAjouterGestionnaire = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\GestionGestionnaire.xaml"
            this.ButtonAjouterGestionnaire.Click += new System.Windows.RoutedEventHandler(this.Ajouter_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 57 "..\..\GestionGestionnaire.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Quitter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


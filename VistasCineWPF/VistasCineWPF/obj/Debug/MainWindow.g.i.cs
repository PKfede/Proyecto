﻿#pragma checksum "..\..\Mainwindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3785059178A42F5B7BA84A7328DED4F4DC31596C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using VistasCineWPF;


namespace VistasCineWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContraseña;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIniciarSesion;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNuevoUsuario;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Mainwindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuarios;
        
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
            System.Uri resourceLocater = new System.Uri("/VistasCineWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Mainwindow.xaml"
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
            this.txtContraseña = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnIniciarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Mainwindow.xaml"
            this.btnIniciarSesion.Click += new System.Windows.RoutedEventHandler(this.BtnIniciarSesion_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNuevoUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Mainwindow.xaml"
            this.btnNuevoUsuario.Click += new System.Windows.RoutedEventHandler(this.BtnNuevoUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtUsuarios = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\Mainwindow.xaml"
            this.txtUsuarios.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUsuario_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


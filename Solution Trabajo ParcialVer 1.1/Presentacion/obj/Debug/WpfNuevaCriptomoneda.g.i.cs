﻿#pragma checksum "..\..\WpfNuevaCriptomoneda.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DE7DE12E8DB4503B0E1AFE49972A190B6C2310E67C9648A92A3D5F560D40097E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion;
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


namespace Presentacion {
    
    
    /// <summary>
    /// WpfNuevaCriptomoneda
    /// </summary>
    public partial class WpfNuevaCriptomoneda : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\WpfNuevaCriptomoneda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_CodigoEspecial;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WpfNuevaCriptomoneda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_NombreNuevaCriptomoneda;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WpfNuevaCriptomoneda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Atras;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WpfNuevaCriptomoneda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_BorrarTodo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WpfNuevaCriptomoneda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Empezar;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/wpfnuevacriptomoneda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WpfNuevaCriptomoneda.xaml"
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
            this.txb_CodigoEspecial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txb_NombreNuevaCriptomoneda = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btn_Atras = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\WpfNuevaCriptomoneda.xaml"
            this.btn_Atras.Click += new System.Windows.RoutedEventHandler(this.btn_Atras_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_BorrarTodo = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\WpfNuevaCriptomoneda.xaml"
            this.btn_BorrarTodo.Click += new System.Windows.RoutedEventHandler(this.btn_BorrarTodo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Empezar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\WpfNuevaCriptomoneda.xaml"
            this.btn_Empezar.Click += new System.Windows.RoutedEventHandler(this.btn_Empezar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\WpfEditarComponentesCreador.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9EAEED91255A3FE1106E2342168131E31D42E55ECE43D50A13376B80F963B776"
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
    /// WpfEditarComponentesCreador
    /// </summary>
    public partial class WpfEditarComponentesCreador : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Modificar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_CodigoEspecial;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_CodigoHardware;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Volver;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_3horas;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_6horas;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_12horas;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WpfEditarComponentesCreador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdb_24horas;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/wpfeditarcomponentescreador.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WpfEditarComponentesCreador.xaml"
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
            this.btn_Modificar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\WpfEditarComponentesCreador.xaml"
            this.btn_Modificar.Click += new System.Windows.RoutedEventHandler(this.btn_Modificar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txb_CodigoEspecial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txb_CodigoHardware = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_Volver = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\WpfEditarComponentesCreador.xaml"
            this.btn_Volver.Click += new System.Windows.RoutedEventHandler(this.btn_Volver_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rdb_3horas = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.rdb_6horas = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.rdb_12horas = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.rdb_24horas = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

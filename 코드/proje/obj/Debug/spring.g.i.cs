﻿#pragma checksum "..\..\spring.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "778228E2E06D36AD4DD41D6CACA38664A8C8163A515C1C8E3BBAC51AA0AB8910"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using proje;


namespace proje {
    
    
    /// <summary>
    /// spring
    /// </summary>
    public partial class spring : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button money;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox userlastnum;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phonnum;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userfirnum;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox buynum;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\spring.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox packname;
        
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
            System.Uri resourceLocater = new System.Uri("/proje;component/spring.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\spring.xaml"
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
            
            #line 16 "..\..\spring.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.username = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\spring.xaml"
            this.username.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.money = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\spring.xaml"
            this.money.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.userlastnum = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 33 "..\..\spring.xaml"
            this.userlastnum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.userlastnum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.phonnum = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\spring.xaml"
            this.phonnum.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\spring.xaml"
            this.phonnum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.phonnum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.userfirnum = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\spring.xaml"
            this.userfirnum.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 37 "..\..\spring.xaml"
            this.userfirnum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.userfirnum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buynum = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\spring.xaml"
            this.buynum.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 38 "..\..\spring.xaml"
            this.buynum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.buynum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.packname = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\spring.xaml"
            this.packname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


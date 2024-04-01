﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FEF9398CE843CC4703AAE9C30B6CB40E66C528AA31F094FC843AFAE676E2E37"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using JobSearchApp;
using JobSearchApp.Commands;
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


namespace JobSearchApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_btn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minSalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maxSalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FilterByJobType;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox jobTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OrderBy;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sortByComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/JobSearchApp;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.listBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToFavoritesButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FavoritesButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Search_btn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.Search_btn.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.minSalaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.maxSalaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 66 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplySalaryFilter_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FilterByJobType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.jobTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            
            #line 77 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplyJobTypeFilter_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.OrderBy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.sortByComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 17:
            
            #line 89 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplySort_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 93 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnglishButton_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 94 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RussianButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


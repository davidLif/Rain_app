﻿

#pragma checksum "C:\Users\David\Documents\Rain_app\App8\App8\RouteBuilder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "054516BB1D1F808FCA950C22B937F5F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App8
{
    partial class RouteBuilder : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.acceptAppBar_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 14 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.undoAppBar_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 15 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.enableAddress_Checked;
                 #line default
                 #line hidden
                #line 15 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Unchecked += this.enableAddress_Unchecked;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 41 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.map_Loaded;
                 #line default
                 #line hidden
                #line 41 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.Controls.Maps.MapControl)(target)).MapTapped += this.map_MapTapped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 52 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.TextBox_GotFocus;
                 #line default
                 #line hidden
                #line 52 "..\..\RouteBuilder.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.addressTextBox_KeyDown;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



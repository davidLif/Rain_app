﻿

#pragma checksum "C:\Users\Denis\documents\visual studio 2013\Projects\RainMan\RainMan\Main.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93EB695B099DC7FBBD3CEC2692C67094"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RainMan
{
    partial class Main : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 55 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.CurrentGridFadeOut_Completed;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 64 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.CurrentGridShow_Completed;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 94 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.AppBar)(target)).Opened += this.commandBar_Opened;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 95 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.mapAppButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 100 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.rainAreas_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 101 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.routesAppBar_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 106 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.creditsApp_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 214 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.fadeOutCredits_Completed;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 257 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.close_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 190 "..\..\Main.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.predictionGrid_ItemClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



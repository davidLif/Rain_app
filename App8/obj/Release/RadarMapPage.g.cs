﻿

#pragma checksum "C:\Users\Denis\documents\visual studio 2013\Projects\App8\App8\RadarMapPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A1A2E15976587F470D1B2B9C1CF3EA8"
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
    partial class RadarMapPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 14 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click_1;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 47 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 17 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)(target)).Opening += this.Flyout_Opening;
                 #line default
                 #line hidden
                #line 17 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.FlyoutBase)(target)).Closed += this.Flyout_Closed;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 35 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.location_TextChanged;
                 #line default
                 #line hidden
                #line 35 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.location_GotFocus;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 36 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.goButton_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 72 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.map_Loaded;
                 #line default
                 #line hidden
                #line 72 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Maps.MapControl)(target)).ZoomLevelChanged += this.map_ZoomLevelChanged;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 107 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.RangeBase)(target)).ValueChanged += this.timeSlider_ValueChanged;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 82 "..\..\RadarMapPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Image)(target)).ImageOpened += this.Image_ImageOpened;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}



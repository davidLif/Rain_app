﻿

#pragma checksum "C:\Users\Denis\documents\visual studio 2013\Projects\RainMan\RainMan\RoutePredictions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B270A087ED2AF58025B7E5E57DDA5604"
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
    partial class RoutePredictions : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.DataTemplate PathNameTemplate; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.ImageBrush pushpinImage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarToggleButton appInfo; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton routesAppBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid LayoutRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid mapGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid informationGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid CurrentTimeGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid SuggestionGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid PathNamesGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard fadeInPaths; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard fadeOutPaths; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView listPathNames; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnClose; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard fadeOutStoryBoardSuggestion; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock suggestionPathName; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock suggestionExitTime; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard fadeInTime; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid routeInformationGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid exitTimeSliderGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider exitTimeSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock pathNameText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock estimatedTimeText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock estimatedLengthText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock averageRainText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::RainMan.ColorSlider colorSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Maps.MapControl map; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///RoutePredictions.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            PathNameTemplate = (global::Windows.UI.Xaml.DataTemplate)this.FindName("PathNameTemplate");
            pushpinImage = (global::Windows.UI.Xaml.Media.ImageBrush)this.FindName("pushpinImage");
            appInfo = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.FindName("appInfo");
            routesAppBar = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("routesAppBar");
            LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("LayoutRoot");
            mapGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("mapGrid");
            informationGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("informationGrid");
            CurrentTimeGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("CurrentTimeGrid");
            SuggestionGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("SuggestionGrid");
            PathNamesGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("PathNamesGrid");
            fadeInPaths = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("fadeInPaths");
            fadeOutPaths = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("fadeOutPaths");
            listPathNames = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("listPathNames");
            btnClose = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnClose");
            fadeOutStoryBoardSuggestion = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("fadeOutStoryBoardSuggestion");
            suggestionPathName = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("suggestionPathName");
            suggestionExitTime = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("suggestionExitTime");
            fadeInTime = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("fadeInTime");
            routeInformationGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("routeInformationGrid");
            exitTimeSliderGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("exitTimeSliderGrid");
            exitTimeSlider = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("exitTimeSlider");
            pathNameText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("pathNameText");
            estimatedTimeText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("estimatedTimeText");
            estimatedLengthText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("estimatedLengthText");
            averageRainText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("averageRainText");
            colorSlider = (global::RainMan.ColorSlider)this.FindName("colorSlider");
            map = (global::Windows.UI.Xaml.Controls.Maps.MapControl)this.FindName("map");
        }
    }
}




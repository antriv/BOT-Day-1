﻿#pragma checksum "C:\Users\antriv\Documents\GitHub\BOT-Day-1\CognitiveServices\Samples-IntelligentKiosk\Kiosk\Views\PersonDetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "30CA8CA237955525F90DBF8EB3589E15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class PersonDetailsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element1 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 13 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element1).Click += this.DeleteSelectedImagesClicked;
                    #line default
                }
                break;
            case 2:
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3:
                {
                    this.imagesGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 4:
                {
                    this.progressControl = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Image element5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 54 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element5).RightTapped += this.ImageRightTapped;
                    #line 54 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)element5).DataContextChanged += this.OnImageDataContextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.AddFacesAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 32 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.OnDeletePersonClicked;
                    #line default
                }
                break;
            case 8:
                {
                    this.trainingImageCollectorFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 9:
                {
                    this.bingSearchControl = (global::IntelligentKioskSample.Controls.ImageSearchUserControl)(target);
                    #line 28 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)this.bingSearchControl).OnImageSearchCompleted += this.OnImageSearchCompleted;
                    #line 28 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)this.bingSearchControl).OnImageSearchCanceled += this.OnImageSearchCanceled;
                    #line 28 "..\..\..\Views\PersonDetailsPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)this.bingSearchControl).OnImageSearchLocalFilesProvided += this.OnImageSearchLocalFilesProvided;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


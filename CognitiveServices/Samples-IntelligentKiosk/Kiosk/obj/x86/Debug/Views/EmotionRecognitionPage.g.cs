﻿#pragma checksum "C:\Users\antriv\Documents\GitHub\BOT-Day-1\CognitiveServices\Samples-IntelligentKiosk\Kiosk\Views\EmotionRecognitionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8005A556B4D6DBD12F7AFAFD86EA43F"
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
    partial class EmotionRecognitionPage : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\Views\EmotionRecognitionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.OnPageSizeChanged;
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
                    this.webCamHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.imageWithFacesControl = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 5:
                {
                    this.imageFromCameraWithFaces = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 6:
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 20 "..\..\..\Views\EmotionRecognitionPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.OnWebCamButtonClicked;
                    #line default
                }
                break;
            case 8:
                {
                    this.PicturesAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 9:
                {
                    this.imageSearchFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 10:
                {
                    global::IntelligentKioskSample.Controls.ImageSearchUserControl element10 = (global::IntelligentKioskSample.Controls.ImageSearchUserControl)(target);
                    #line 24 "..\..\..\Views\EmotionRecognitionPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element10).OnImageSearchCompleted += this.OnImageSearchCompleted;
                    #line 24 "..\..\..\Views\EmotionRecognitionPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element10).OnImageSearchCanceled += this.OnImageSearchCanceled;
                    #line 24 "..\..\..\Views\EmotionRecognitionPage.xaml"
                    ((global::IntelligentKioskSample.Controls.ImageSearchUserControl)element10).OnImageSearchLocalFilesProvided += this.OnImageSearchLocalFilesProvided;
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


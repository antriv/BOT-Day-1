﻿#pragma checksum "C:\Users\antriv\Documents\GitHub\BOT-Day-1\CognitiveServices\Samples-IntelligentKiosk\Kiosk\Views\MallKioskPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DE71F94FE37F29852264F59D2A3CB0BC"
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
    partial class MallKioskPage : 
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
                    #line 9 "..\..\..\Views\MallKioskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).SizeChanged += this.PageSizeChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.webView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 3:
                {
                    this.webCamHostGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.imageFromCameraWithFaces = (global::IntelligentKioskSample.Controls.ImageWithFaceBorderUserControl)(target);
                }
                break;
            case 5:
                {
                    this.cameraControl = (global::IntelligentKioskSample.Controls.CameraControl)(target);
                }
                break;
            case 6:
                {
                    this.speechToTextControl = (global::IntelligentKioskSample.Controls.SpeechToTextControl)(target);
                }
                break;
            case 7:
                {
                    this.emotionResponseFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    #line 36 "..\..\..\Views\MallKioskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.emotionResponseFlyout).Opened += this.OnEmotionTrackingFlyoutOpened;
                    #line 36 "..\..\..\Views\MallKioskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)this.emotionResponseFlyout).Closed += this.OnEmotionTrackingFlyoutClosed;
                    #line default
                }
                break;
            case 8:
                {
                    this.emotionFacesGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 9:
                {
                    this.emotionFacesToggle = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 61 "..\..\..\Views\MallKioskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.emotionFacesToggle).Unchecked += this.OnEmotionFacesToggleUnchecked;
                    #line 61 "..\..\..\Views\MallKioskPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.emotionFacesToggle).Checked += this.OnEmotionFacesToggleChecked;
                    #line default
                }
                break;
            case 10:
                {
                    this.sentimentControl = (global::IntelligentKioskSample.Controls.SentimentControl)(target);
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


﻿#pragma checksum "C:\Users\antriv\Documents\GitHub\BOT-Day-1\CognitiveServices\Samples-IntelligentKiosk\Kiosk\Controls\SpeechToTextControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C8B2DB58F130CF1B245DF85C4B6EE87"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class SpeechToTextControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    global::Windows.UI.Xaml.Controls.Flyout element1 = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    #line 15 "..\..\..\Controls\SpeechToTextControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)element1).Opened += this.OnSpeechRecognitionFlyoutOpened;
                    #line 15 "..\..\..\Controls\SpeechToTextControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Flyout)element1).Closed += this.OnSpeechRecognitionFlyoutClosed;
                    #line default
                }
                break;
            case 2:
                {
                    this.sentimentControl = (global::IntelligentKioskSample.Controls.SentimentControl)(target);
                }
                break;
            case 3:
                {
                    this.speechRecognitionTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.speechRecognitionControlButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Controls\SpeechToTextControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.speechRecognitionControlButton).Click += this.SpeechRecognitionButtonClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.speechRecognitionControlButtonSymbol = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
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


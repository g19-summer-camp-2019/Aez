﻿#pragma checksum "C:\Users\LeoSh\source\repos\Aez\Aez\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14F5A2F80DE41CF920500D6F40DD11E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aez
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.nvSample = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvSample).Loaded += this.NvSample_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvSample).SelectionChanged += this.NvSample_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvSample).ItemInvoked += this.NvSample_ItemInvoked;
                }
                break;
            case 3: // MainPage.xaml line 42
                {
                    this.OutPutText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 43
                {
                    this.AniType = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // MainPage.xaml line 50
                {
                    this.Btn_Send = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Btn_Send).Click += this.Btn_Send_Click;
                }
                break;
            case 6: // MainPage.xaml line 55
                {
                    this.Tb_Answer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


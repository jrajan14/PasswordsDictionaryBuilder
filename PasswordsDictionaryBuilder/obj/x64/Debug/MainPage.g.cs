﻿#pragma checksum "C:\Users\jraja\Documents\GitHub\PasswordsDictionaryBuilder\PasswordsDictionaryBuilder\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3923A818F24AE9C53CC3CD7B1F1C621F977E316D3817432D7306D8DCB1E7D0FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordsDictionaryBuilder
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.ListOfCharacters = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 13
                {
                    this.AddToList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddToList).Click += this.AddToList_Click;
                }
                break;
            case 4: // MainPage.xaml line 14
                {
                    this.RemoveFromList = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RemoveFromList).Click += this.RemoveFromList_Click;
                }
                break;
            case 5: // MainPage.xaml line 15
                {
                    this.TxtCharacter = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 22
                {
                    this.BtnSetPassLen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSetPassLen).Click += this.BtnSetPassLen_Click;
                }
                break;
            case 7: // MainPage.xaml line 23
                {
                    this.BtnPassGen = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnPassGen).Click += this.BtnPassGen_Click;
                }
                break;
            case 8: // MainPage.xaml line 24
                {
                    this.TxtGenPasswds = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // MainPage.xaml line 25
                {
                    this.BtnAddCapsAZ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnAddCapsAZ).Click += this.BtnAddCapsAZ_Click;
                }
                break;
            case 10: // MainPage.xaml line 26
                {
                    this.BtnAddLowAZ = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnAddLowAZ).Click += this.BtnAddLowAZ_Click;
                }
                break;
            case 11: // MainPage.xaml line 27
                {
                    this.BtnAddNum = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnAddNum).Click += this.BtnAddNum_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


﻿#pragma checksum "C:\Users\toshiba\GitHub\Tim6-NN\Projekat\iGym\iGym\forme\RegistracijaNovogClana.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4068C5551ADA952A09CA808A44B39E04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iGym
{
    partial class RegistracijaNovogClana : 
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
                    this.profil = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.Slika = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.DugmeUnesiSliku = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.profilImeLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.profilPrezimeLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.profilSpolLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.profilBrTelLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.profilAdresaLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.profilClanarinaLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.profilDatumUplateLabela = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.DugmeRegistruj = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 12:
                {
                    this.DugmeIdinazad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\forme\RegistracijaNovogClana.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DugmeIdinazad).Click += this.Klik_RegistracijaIdiNazad;
                    #line default
                }
                break;
            case 13:
                {
                    this.ProfilIme = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.ProfilPrezime = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.ProfilSpolMuski = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 16:
                {
                    this.ProfilSpolZenski = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 17:
                {
                    this.ProfilBrTel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18:
                {
                    this.ProfilAdresa = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19:
                {
                    this.ProfilClanarina = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.ProfilDatumUplate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
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


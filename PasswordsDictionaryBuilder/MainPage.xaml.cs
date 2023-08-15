using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PasswordsDictionaryBuilder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Password Length
        int PassLen = 1;

        public MainPage()
        {
            this.InitializeComponent();
        }

        //Set Password Length
        private void BtnSetPassLen_Click(object sender, RoutedEventArgs e)
        {
            PassLen = Convert.ToInt32(PassLen);
        }

        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            if(TxtCharacter.Text.Length > 1)
            {
                //LOG ERROR
            }
            else if(!ListOfCharacters.Items.Contains(TxtCharacter.Text))
            {
                ListOfCharacters.Items.Add(TxtCharacter.Text);
                //LOG ITEM ADDED
            }
            else
            {
                //LOG ERROR
            }

        }

        private void RemoveFromList_Click(object sender, RoutedEventArgs e)
        {
            while (ListOfCharacters.SelectedItems.Count > 0)
            {
                //Removed multiple items from the list
                //Also removes duplicate items that are "ABOVE" on the list
                ListOfCharacters.Items.RemoveAt(ListOfCharacters.Items.IndexOf(ListOfCharacters.SelectedItem));
               
            }

        }

        private void BtnPassGen_Click(object sender, RoutedEventArgs e)
        {
            TxtGenPasswds.Text = "";
            if(ListOfCharacters.Items.Count > 0)
            {
                List<string> charList = new List<string>();
                foreach(string s in ListOfCharacters.Items)
                {
                    charList.Add(s);
                }

                                

            }
        }
    }
}

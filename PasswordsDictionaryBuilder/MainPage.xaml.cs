using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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


namespace PasswordsDictionaryBuilder
{
    
    public sealed partial class MainPage : Page
    {
        //Password Length
        int PassLen = 3;

        //List of Characters
        List<char> charList = new List<char>();

        //List of Generated Passwords
        List<string> Passwords = new List<string>();

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
                char newChar = char.Parse(TxtCharacter.Text);
                ListOfCharacters.Items.Add(newChar);
                //LOG ITEM ADDED
            }
            else
            {
                //LOG ERROR
            }

        }

        //Remove Selected items from list
        private void RemoveFromList_Click(object sender, RoutedEventArgs e)
        {
            while (ListOfCharacters.SelectedItems.Count > 0)
            {
                //Removed multiple items from the list
                //Also removes duplicate items that are "ABOVE" on the list
                ListOfCharacters.Items.RemoveAt(ListOfCharacters.Items.IndexOf(ListOfCharacters.SelectedItem));
               
            }

        }

        //Add all Upper Case Alphabets to the list ( A to Z )
        private void BtnAddCapsAZ_Click(object sender, RoutedEventArgs e)
        {
            char[] CapsAlphaBets = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for(int i = 0; i<CapsAlphaBets.Length; i++) 
            {
                if (!ListOfCharacters.Items.Contains(CapsAlphaBets[i]))
                {
                    ListOfCharacters.Items.Add(CapsAlphaBets[i]);
                }
            }
            
        }

        //Add all Lower Case Alphabets to the list ( a to z ) 
        private void BtnAddLowAZ_Click(object sender, RoutedEventArgs e)
        {
            char[] LowerAlphaBets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < LowerAlphaBets.Length; i++)
            {
                if (!ListOfCharacters.Items.Contains(LowerAlphaBets[i]))
                {
                    ListOfCharacters.Items.Add(LowerAlphaBets[i]);
                }
            }
        }

        //Add all Numbers to the list ( 0 - 9 )
        private void BtnAddNum_Click(object sender, RoutedEventArgs e)
        {
            char[] AllNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < AllNums.Length; i++)
            {
                if (!ListOfCharacters.Items.Contains(AllNums[i]))
                {
                    ListOfCharacters.Items.Add(AllNums[i]);
                }
            }
        }

        /*
                                WORD GENERATOR                  
        */
        private void BtnPassGen_Click(object sender, RoutedEventArgs e)
        {
            TxtGenPasswds.Text = ""; //CLEAR

            if (ListOfCharacters.Items.Count > 0)
            {
                foreach (char s in ListOfCharacters.Items)
                {
                    charList.Add(s);
                }

                GeneratePasswords();

                //Print all passwords
                foreach (string word in Passwords)
                {
                    TxtGenPasswds.Text += word + " ";
                }

                Passwords.Clear();

            }
        }

        private void GeneratePasswords()
        {
            //LOGIC HERE
        }      
    }
}
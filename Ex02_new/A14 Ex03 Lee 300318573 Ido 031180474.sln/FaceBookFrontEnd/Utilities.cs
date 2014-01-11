using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FaceBookBackEnd;
using FindTagsAround;
using FaceBookFrontEnd;
using System.Windows.Forms;

namespace FaceBookFrontEnd
{
    public class Utilities
    {
        internal static readonly string Sr_FillField = "Please fill this field";
        internal static readonly string Sr_FillFieldNumber = "Please fill this field, numbers ONLY";
        internal static readonly string Sr_Likes = "Likes";
        internal static readonly string Sr_Comments = "Comments";
        internal static readonly string Sr_Messages = "Messages";
        
        internal void clearListBox(params ListBox[] listBoxex)
        {
            foreach (ListBox listBox in listBoxex)
            {
                listBox.Items.Clear();
            }
        }
        
        internal void disableControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }

        internal void enableControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }

        internal bool isUserTextValid(string i_userText)
        {
            bool isValid = true;
            
            if (i_userText == string.Empty)
            {
                isValid = false;
            }
            
            return isValid;
        }
        
        internal bool isValidNunber(string i_UserInput)
        {
            bool isValid = true;
            int inputNumber;
            
            if (i_UserInput == string.Empty || !Int32.TryParse(i_UserInput, out inputNumber))
            {
                isValid = false;
            }
            
            return isValid;
        }
        
        internal string noItem(string type)
        {
            StringBuilder message = new StringBuilder();
            
            message.Append("No ").Append(type).Append(" on this checkin.");
            
            return message.ToString();
        }
    }
}
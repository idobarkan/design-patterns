using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FaceBookBackEnd;
using FindTagsAround;
using FaceBookFrontEnd;
using BasicFacebookFeatures.WithSingltonAppSettings;

namespace FaceBookFrontEnd
{
    public partial class FindCheckinByLocationForm : Form
    {
        private Utilities m_Util;
        private CheckinHolder m_CheckinHolder;
        private User m_LoggedInUser;
        private ErrorProvider m_ErrorProviderNumber;
        private ErrorProvider m_ErrorProviderText;
        private double UserDistance { get; set; }
        private int MaxCount { get; set; }
        private FindTagsAround.eRecommendationSortKey SortBy { get; set; }
        private string UserLocation { get; set; }
        private DateTime Date { get; set; }

        public FindCheckinByLocationForm(User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            this.m_ErrorProviderNumber = new ErrorProvider();
            this.m_ErrorProviderText = new ErrorProvider();
            this.m_Util = new Utilities();
            this.m_CheckinHolder = new CheckinHolder();
        }

        private bool validateControls(Func<string, bool> i_IsValid, ErrorProvider i_ErrorProvider, params Control[] i_ControlsToValidate)
        {
            bool isControlsValid = true;
            foreach (var control in i_ControlsToValidate)
            {
                isControlsValid = i_IsValid(control.Text);

                if (!isControlsValid)
                {
                    i_ErrorProvider.SetError(control, Utilities.Sr_FillField);
                }
                else
                {
                    i_ErrorProvider.SetError(control, string.Empty);
                    i_ErrorProvider.Clear();
                }
            }

            return isControlsValid;
        }

        private void initializeUserCheckinInput()
        {
            this.UserDistance = Convert.ToDouble(textBoxDistance.Text);
            this.SortBy = (FindTagsAround.eRecommendationSortKey)Enum.Parse(
                typeof(FindTagsAround.eRecommendationSortKey),
                this.comboBoxSortBy.SelectedItem.ToString());
            this.MaxCount = int.Parse(this.comboBoxMaxCount.SelectedItem.ToString());
            this.Date = this.dateTimePickerUser.Value.Date;
        }

        private void updateControls()
        {
            this.m_Util.clearListBox(this.listBoxViewCheckinLikes, this.listBoxViewCheckinComments);

            this.listBoxViewCheckinLikes.Visible = false;
            this.listBoxViewCheckinComments.Visible = false;
        }

        private void fetchCheckinByPlace()
        {
            this.m_CheckinHolder.setRecentCheckins(this.m_LoggedInUser, this.Date, this.SortBy, this.MaxCount);

            if (this.listBoxAddressSuggestion.InvokeRequired)
            {
                this.listBoxAddressSuggestion.Invoke(new MethodInvoker(() =>
                    this.m_CheckinHolder.setAllCheckinByPlace(this.UserLocation, this.UserDistance, this.listBoxAddressSuggestion.SelectedItem.ToString())));
            }

            this.listBoxCheckinByPlace.DisplayMember = "Checkin";
            var allCheckinByPlace = this.m_CheckinHolder.CheckinByPlace;

            if (allCheckinByPlace != null)
            {
                if (!this.listBoxCheckinByPlace.InvokeRequired)
                {
                    this.listBoxCheckinByPlace.Invoke(new Action(() => this.checkinBindingSource.DataSource = allCheckinByPlace));
                }
                else
                {
                    this.listBoxCheckinByPlace.Invoke(new Action(() => this.checkinBindingSource.DataSource = allCheckinByPlace));
                }
            }
            else
            {
                MessageBox.Show(Utilities.Sr_Messages);
            }
        }

        private void fetchCheckinLikes()
        {
            if (this.listBoxCheckinByPlace.SelectedItems.Count == 1)
            {
                Checkin selectedCheckin = this.listBoxCheckinByPlace.SelectedItem as Checkin;

                foreach (User user in selectedCheckin.LikedBy)
                {
                    listBoxViewCheckinLikes.Items.Add(user);
                }

                if (listBoxViewCheckinLikes.Items.Count == 0)
                {
                    listBoxViewCheckinLikes.Items.Add(this.m_Util.noItem(Utilities.Sr_Likes));
                }

                listBoxViewCheckinLikes.Visible = true;
            }
        }

        private void fetchCheckinComments()
        {
            if (this.listBoxCheckinByPlace.SelectedItems.Count == 1)
            {
                Checkin selectedCheckin = this.listBoxCheckinByPlace.SelectedItem as Checkin;
                foreach (Comment comment in selectedCheckin.Comments)
                {
                    listBoxViewCheckinComments.Items.Add(comment);
                }

                if (listBoxViewCheckinComments.Items.Count == 0)
                {
                    listBoxViewCheckinComments.Items.Add(this.m_Util.noItem(Utilities.Sr_Comments));
                }

                listBoxViewCheckinComments.Visible = true;
            }
        }

        private void fetchAddressSuggestion()
        {
            this.m_CheckinHolder.setUserAddresses(this.UserLocation);

            foreach (GoogleMapsReference address in this.m_CheckinHolder.UserAddressSuggestions)
            {
                this.listBoxAddressSuggestion.Items.Add(address.Description);
            }
        }

        private void clearForm()
        {
            this.updateControls();
            this.m_Util.clearListBox(this.listBoxAddressSuggestion);
            this.m_Util.disableControls(this.ButtonCheckin, this.linkLabelLikes, this.linkLabelComments);
        }

        private void buttonFindLocation_Click(object sender, EventArgs e)
        {
            this.clearForm();

            bool isLocationValid = this.validateControls(this.m_Util.isUserTextValid, this.m_ErrorProviderText, this.textBoxLocation);

            if (isLocationValid)
            {
                this.UserLocation = textBoxLocation.Text;
                this.fetchAddressSuggestion();
            }
            else
            {
                return;
            }
        }

        private void ButtonCheckin_Click(object sender, EventArgs e)
        {
            bool isControlsNumbersValid = this.validateControls(this.m_Util.isValidNunber, this.m_ErrorProviderNumber, this.textBoxDistance);
            bool isControlsTextValid = this.validateControls(this.m_Util.isUserTextValid, this.m_ErrorProviderText, this.dateTimePickerUser, this.comboBoxSortBy, this.comboBoxMaxCount);

            if (isControlsTextValid & isControlsNumbersValid)
            {
                this.initializeUserCheckinInput();
            }
            else
            {
                return;
            }

            new Thread(this.fetchCheckinByPlace).Start();
        }

        private void listBoxAddressSuggestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxAddressSuggestion.SelectedItems.Count == 1)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.m_Util.enableControls(this.ButtonCheckin);
            }
        }

        private void listBoxCheckinByPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateControls();
            this.m_Util.enableControls(this.linkLabelComments, this.linkLabelLikes);
        }

        private void linkLabelComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.m_Util.clearListBox(this.listBoxViewCheckinComments);
            this.fetchCheckinComments();
        }

        private void linkLabelLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.m_Util.clearListBox(this.listBoxViewCheckinLikes);
            this.fetchCheckinLikes();
        }
    }
}

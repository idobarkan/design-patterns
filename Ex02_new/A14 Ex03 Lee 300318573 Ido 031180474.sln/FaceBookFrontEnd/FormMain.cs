using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FaceBookBackEnd;
using FindTagsAround;
using FaceBookFrontEnd;

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public partial class FacebookForm : Form
    {
        private User m_LoggedInUser;
        private FacebookBackend m_FacebookEnd;

        public FacebookForm(User i_LoggedIngUser, FacebookBackend i_FacebookEnd)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedIngUser;
            this.m_FacebookEnd = i_FacebookEnd;
            loadPictureAndStatus();
        }

        private void loadPictureAndStatus()
        {
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Statuses.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Statuses[0].Message;
            }
        }

        private void FindFriendsCheckin_Click(object sender, EventArgs e)
        {
            FindCheckinByLocationForm findCheckin = new FindCheckinByLocationForm(m_LoggedInUser);
            findCheckin.ShowDialog();
        }

        private void buttonSuggestFriends_Click(object sender, EventArgs e)
        {
            SuggestFriendsForm suggestFriend = new SuggestFriendsForm(m_LoggedInUser, m_FacebookEnd);
            suggestFriend.ShowDialog();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            m_LoggedInUser.PostStatus(textBoxStatus.Text);
        }

        private void fetchNewsFeed()
        {
            StringBuilder postInfo = null;

            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                postInfo = new StringBuilder();

                if (post.Message != null)
                {
                    postInfo.Append(post.From).Append(": ").Append(post.Message);
                    listBoxNewsFeed.Items.Add(postInfo);
                }
                else if (post.Caption != null)
                {
                    postInfo.Append(post.From).Append(": ").Append(post.Caption);
                    listBoxNewsFeed.Items.Add(postInfo);
                }
                else if (post.Link != null)
                {
                    postInfo.Append(post.From).Append(": ").Append(post.Link);
                    listBoxNewsFeed.Items.Add(postInfo);
                }
                else
                {
                    listBoxNewsFeed.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchFriends();
        }

        private void fetchFriends()
        {
            /// this operation is the operation that takes time, and should be executed in the separate thread 
            var allFriends = m_LoggedInUser.Friends;
            if (!listBoxFriends.InvokeRequired)
            {
                // binding the data source of the binding source, to our data source: userBindingSource.DataSource = allFriends; } else { // In case of cross-thread operation, invoking the binding code on the listBox's thread: 
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchEvents();
        }

        private void fetchEvents()
        {
            var allEvents = m_LoggedInUser.Events;
            if (!listBoxEvents.InvokeRequired)
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = allEvents));
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
            }
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in m_LoggedInUser.Checkins)
            {
                listBoxCheckins.Items.Add(checkin);
            }
        }

        private void linkLabelCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxCheckins.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            fetchCheckins();
        }

        private void linkLabelNewsFedds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxNewsFeed.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            fetchNewsFeed();
        }
    }
}

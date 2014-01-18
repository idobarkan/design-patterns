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

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    public partial class FacebookForm : Form
    {
        private User m_LoggedInUser;
        private FacebookBackend m_FacebookEnd;

        public FacebookForm(User i_LoggedIngUser, FacebookBackend i_FacebookEnd)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoggedIngUser;
            this.m_FacebookEnd = i_FacebookEnd;
            this.loadPictureAndStatus();
        }

        private void loadPictureAndStatus()
        {
            picture_smallPictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            if (this.m_LoggedInUser.Statuses.Count > 0)
            {
                textBoxStatus.Text = this.m_LoggedInUser.Statuses[0].Message;
            }
        }

        private void FindFriendsCheckin_Click(object sender, EventArgs e)
        {
            FindCheckinByLocationForm findCheckin = new FindCheckinByLocationForm(this.m_LoggedInUser);
            findCheckin.ShowDialog();
        }

        private void buttonSuggestFriends_Click(object sender, EventArgs e)
        {
            SuggestFriendsForm suggestFriend = new SuggestFriendsForm(this.m_LoggedInUser, this.m_FacebookEnd);
            suggestFriend.ShowDialog();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            this.m_LoggedInUser.PostStatus(textBoxStatus.Text);
        }

        private void fetchNewsFeed()
        {
            StringBuilder postInfo = null;

            foreach (Post post in this.m_LoggedInUser.NewsFeed)
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
            new Thread(this.fetchFriends).Start();
        }

        private void fetchFriends()
        {
            var allFriends = this.m_LoggedInUser.Friends;

            if (!this.listBoxFriends.InvokeRequired)
            {
                this.listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
            else
            {
                this.listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Thread(this.fetchEvents).Start();
        }

        private void fetchEvents()
        {
            var allEvents = this.m_LoggedInUser.Events;
            if (!this.listBoxEvents.InvokeRequired)
            {
                this.listBoxEvents.Invoke(new Action(() => this.eventBindingSource.DataSource = allEvents));
            }
            else
            {
                this.listBoxEvents.Invoke(new Action(() => this.eventBindingSource.DataSource = allEvents));
            }
        }

        private void fetchCheckins()
        {
            var allCheckins = this.m_LoggedInUser.Checkins;
            this.listBoxCheckins.Invoke(new Action(() =>
            {
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    this.listBoxCheckins.Items.Add(checkin);
                }
            }));
        }

        private void linkLabelCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.listBoxCheckins.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            new Thread(this.fetchCheckins).Start();
        }

        private void linkLabelNewsFedds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxNewsFeed.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            this.fetchNewsFeed();
        }
    }
}

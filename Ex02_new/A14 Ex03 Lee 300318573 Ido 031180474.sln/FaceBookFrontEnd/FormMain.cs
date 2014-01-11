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
using System.Threading;

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
            new Thread(fetchFriends).Start();
        }

        private void fetchFriends()
        {
            var allFriends = m_LoggedInUser.Friends;
            
            if (!listBoxFriends.InvokeRequired)
            {
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
            else
            {
                listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Thread(fetchEvents).Start();
        }

        private void fetchEvents()
        {
            var allEvents = m_LoggedInUser.Events;
            if (!listBoxEvents.InvokeRequired)
            {
                listBoxEvents.Invoke(new Action(() => eventBindingSource.DataSource = allEvents));
            }
            else
            {
                listBoxEvents.Invoke(new Action(() => userBindingSource.DataSource = allEvents));
            }
        }

       
        private void fetchCheckins()
        {
            var allCheckins = m_LoggedInUser.Checkins;
            listBoxCheckins.Invoke(new Action(() =>
            {
                foreach (Checkin checkin in m_LoggedInUser.Checkins)
                {
                    listBoxCheckins.Items.Add(checkin);
                }

            }));
        }

        private void linkLabelCheckins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxCheckins.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            new Thread(fetchCheckins).Start();
        }

        private void linkLabelNewsFedds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxNewsFeed.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            fetchNewsFeed();
        }
    }
}

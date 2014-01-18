using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FaceBookBackEnd;
using FindTagsAround;

namespace FaceBookFrontEnd
{
    public partial class SuggestFriendsForm : Form
    {
        private User m_LoggedInUser;
        private FacebookBackend m_Fb;
        private Utilities m_Util;
        private ErrorProvider m_ErrorProvider;
        private ConcurrentQueue<User> m_EventsSuggestionsUsersQ;
        private ConcurrentQueue<User> m_PhotosSuggestionsUsersQ;

        public SuggestFriendsForm(User i_LoginUser, FacebookBackend i_Fb)
        {
            this.InitializeComponent();
            this.m_LoggedInUser = i_LoginUser;
            this.m_Fb = i_Fb;
            this.m_Util = new Utilities();
            this.m_ErrorProvider = new ErrorProvider();
        }

        private bool validateControls(Func<string, bool> isValid, params Control[] ControlsToValidate)
        {
            bool isControlsValid = true;
            
            foreach (var control in ControlsToValidate)
            {
                isControlsValid = isValid(control.Text);
                
                if (!isControlsValid)
                {
                    this.m_ErrorProvider.SetError(control, Utilities.Sr_FillFieldNumber);
                }
                else
                {
                   this.m_ErrorProvider.SetError(control, string.Empty);
                   this.m_ErrorProvider.Clear();
                }
            }
            
            return isControlsValid;
        }

        private void buttonSuggestByPhotos_Click(object sender, EventArgs e)
        {
            this.listBoxSuggestedByPhotos.Items.Clear();
            pictureBoxFriendByPhoto.Image = null;
            Cursor.Current = Cursors.WaitCursor;
            
            this.suggestFriendsByPhotos();
        }

        private void suggestFriendsByPhotos()
        {
            bool isValid = this.validateControls(this.m_Util.isValidNunber, textBoxMaxResults);
            
            if (isValid)
            {
                this.m_PhotosSuggestionsUsersQ = this.m_Fb.RegisterForRecommendations(eRecommendationSource.Photos, this.getFromQueueToPhotosListBox);
                Task t1 = Task.Factory.StartNew(() =>
                {
                    m_Fb.GetSuggestionsAsync<Photo, int>(
                    eRecommendationSource.Photos,
                    m_LoggedInUser,
                    (Photo photo) => photo.Tags != null ? photo.Tags.Count : 0);
                });
            }
        }

        private void suggestFriendsByEvents()
        {
            bool isValid = this.validateControls(this.m_Util.isValidNunber, textBoxMaxResults);
            
            if (isValid)
            {
                this.m_EventsSuggestionsUsersQ = this.m_Fb.RegisterForRecommendations(eRecommendationSource.Events, this.getFromQueueToEventeListBox);
                Task t1 = Task.Factory.StartNew(() =>
                {
                    m_Fb.GetSuggestionsAsync<Event, int>(
                    eRecommendationSource.Events,
                    m_LoggedInUser,
                    (Event i_Event) => i_Event.AttendingUsers != null ? i_Event.AttendingUsers.Count : 0);
                });
            }
        }

        private void getFromQueueToEventeListBox()
        {
            User UserFromQ;
            if (this.m_EventsSuggestionsUsersQ.TryDequeue(out UserFromQ))
            {
                this.listBoxSuggestedByEvent.SafeInvoke(
                    new Action(
                    () => this.listBoxSuggestedByEvent.Items.Add(UserFromQ)),
                    false);
            }
        }

        private void getFromQueueToPhotosListBox()
        {
            User UserFromQ;
            if (this.m_PhotosSuggestionsUsersQ.TryDequeue(out UserFromQ))
            {
                this.listBoxSuggestedByPhotos.SafeInvoke(
                    new Action(
                    () => this.listBoxSuggestedByPhotos.Items.Add(UserFromQ)),
                    false);
            }
        }

        private void buttonSuggestedByEvent_Click(object sender, EventArgs e)
        {
            this.listBoxSuggestedByEvent.Items.Clear();
            pictureBoxFriendByEvent.Image = null;
            Cursor.Current = Cursors.WaitCursor;
            
            this.suggestFriendsByEvents();   
        }

        private void listBoxSuggestedByPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxSuggestedByPhotos.SelectedItems.Count == 1)
            {
                User selectedFriend = this.listBoxSuggestedByPhotos.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriendByPhoto.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }

        private void listBoxSuggestedByEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxSuggestedByEvent.SelectedItems.Count == 1)
            {
                User selectedFriend = this.listBoxSuggestedByEvent.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriendByEvent.LoadAsync(selectedFriend.PictureNormalURL);
                }
            }
        }
    }
}

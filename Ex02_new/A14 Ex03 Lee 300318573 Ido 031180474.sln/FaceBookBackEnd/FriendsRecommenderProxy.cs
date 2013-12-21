using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using FacebookWrapper.ObjectModel;

namespace FaceBookBackEnd
{
    internal class FriendsRecommenderProxy : IFriendSuggestionsProvider
    {
        private IFriendsRecommender m_PhotosFriendsRecommender;
        private IFriendsRecommender m_EventsFriendsRecommender;

        public FriendsRecommenderProxy()
        {
            m_PhotosFriendsRecommender = null;
            m_EventsFriendsRecommender = null;
        }

        public void GetSuggestionsAsync<T, TKey>(
            eRecommendationSource i_Source, FacebookWrapper.ObjectModel.User i_LoggedInUser, Func<T, TKey> i_OrderByFunc)
        {
            if (i_Source == eRecommendationSource.Photos)
            {
                createPhotosFriendsRecommenderIfNeeded();
                m_PhotosFriendsRecommender.GetSuggestionsAsync<T, TKey>(
                    i_LoggedInUser, i_OrderByFunc);
            }
            else if (i_Source == eRecommendationSource.Events)
            {
                createEventsFriendsRecommenderIfNeeded();
                m_EventsFriendsRecommender.GetSuggestionsAsync<T, TKey>(
                    i_LoggedInUser,
                    i_OrderByFunc
                        );
            }
            else
            {
                throw new Exception("unknown source");
            }
        }

        public ConcurrentQueue<User> RegisterForRecommendations(eRecommendationSource i_Source, Action i_Callback)
        {
            ConcurrentQueue<User> q;
            if (i_Source == eRecommendationSource.Photos)
            {
                createPhotosFriendsRecommenderIfNeeded();
                m_PhotosFriendsRecommender.UserRecommendedDelegetas += i_Callback;
                q = m_PhotosFriendsRecommender.SuggestionsQ;
            }
            else if (i_Source == eRecommendationSource.Events)
            {
                createEventsFriendsRecommenderIfNeeded();
                m_EventsFriendsRecommender.UserRecommendedDelegetas += i_Callback;
                q = m_EventsFriendsRecommender.SuggestionsQ;
            }
            else
            {
                throw new Exception("unknown source");
            }
            return q;
        }

        private void createEventsFriendsRecommenderIfNeeded()
        {
            if (m_EventsFriendsRecommender == null)
            {
                m_EventsFriendsRecommender = new EventsFriendsRecommender();
            }
        }

        private void createPhotosFriendsRecommenderIfNeeded()
        {
            if (m_PhotosFriendsRecommender == null)
            {
                m_PhotosFriendsRecommender = new PhotosFriendsRecommender();
            }
        }
    }
}

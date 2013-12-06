using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBookBackEnd
{
    internal class FriendsRecommenderProxy : IFriendSuggestionsProvider
    {
        private IFriendsRecommender m_CheckInsFriendsRecommender;
        private IFriendsRecommender m_PhotosFriendsRecommender;
        private IFriendsRecommender m_EventsFriendsRecommender;

        public FriendsRecommenderProxy()
        {
            m_CheckInsFriendsRecommender = null;
            m_PhotosFriendsRecommender = null;
            m_EventsFriendsRecommender = null;
        }

        public List<FacebookWrapper.ObjectModel.User> GetSuggestions<T, TKey>(eRecommendationSource i_Source, FacebookWrapper.ObjectModel.User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc)
        {
            if (i_Source == eRecommendationSource.Checkins)
            {
                if (m_CheckInsFriendsRecommender == null)
                {
                    m_CheckInsFriendsRecommender = new CheckInsFriendsRecommender();
                }
                return m_CheckInsFriendsRecommender.GetSuggestions<T, TKey>(
                    i_LoggedInUser,
                    i_MaxResults,
                    i_OrderByFunc
                        );
            }
            else if (i_Source == eRecommendationSource.Photos)
            {
                if (m_PhotosFriendsRecommender == null)
                {
                    m_PhotosFriendsRecommender = new PhotosFriendsRecommender();
                }
                return m_PhotosFriendsRecommender.GetSuggestions<T, TKey>(
                    i_LoggedInUser,
                    i_MaxResults,
                    i_OrderByFunc
                        );
            }
            else if (i_Source == eRecommendationSource.Events)
            {
                if (m_EventsFriendsRecommender == null)
                {
                    m_EventsFriendsRecommender = new EventsFriendsRecommender();
                }
                return m_EventsFriendsRecommender.GetSuggestions<T, TKey>(
                    i_LoggedInUser,
                    i_MaxResults,
                    i_OrderByFunc
                        );
            }
            else
            {
                throw new Exception("unknown source");
            }
        }
    }
}

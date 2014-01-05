using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Concurrent;

namespace FaceBookBackEnd
{
    public class FacebookBackend : IAuthenticator, IFriendSuggestionsProvider
    {
        private static FacebookBackend s_Instance = null;
        private static object s_LockObj = new Object();

        private LogIner m_LogIner = new LogIner();
        private IFriendSuggestionsProvider m_CheckInsFriendsRecommenderProxy = new FriendsRecommenderProxy();

        private FacebookBackend() { }

        public static FacebookBackend Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookBackend();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LogIn()
        {
            return m_LogIner.LogIn();
        }

        public List<User> GetSuggestions<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc)
        {
            return m_CheckInsFriendsRecommenderProxy.GetSuggestions<T, TKey>(i_Source, i_LoggedInUser, i_MaxResults, i_OrderByFunc);
        }

        public void GetSuggestionsAsync<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, Func<T, TKey> i_OrderByFunc)
        {
            m_CheckInsFriendsRecommenderProxy.GetSuggestionsAsync<T, TKey>(i_Source, i_LoggedInUser, i_OrderByFunc);
        }

        public ConcurrentQueue<User> RegisterForRecommendations(eRecommendationSource i_Source, Action d)
        {
            return m_CheckInsFriendsRecommenderProxy.RegisterForRecommendations(i_Source, d);
        }
    }
}

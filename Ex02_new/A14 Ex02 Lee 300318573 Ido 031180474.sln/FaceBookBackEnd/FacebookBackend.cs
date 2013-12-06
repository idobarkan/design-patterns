using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;

namespace FaceBookBackEnd
{
    public class FacebookBackend : IAuthenticator, IFriendSuggestionsProvider
    {
        private LogIner m_LogIner = new LogIner();
        private IFriendSuggestionsProvider m_CheckInsFriendsRecommenderProxy = new FriendsRecommenderProxy();

        public User LogIn()
        {
            return m_LogIner.LogIn();
        }

        public List<User> GetSuggestions<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc)
        {
            return m_CheckInsFriendsRecommenderProxy.GetSuggestions<T, TKey>(i_Source, i_LoggedInUser, i_MaxResults, i_OrderByFunc);
        }
    }
}

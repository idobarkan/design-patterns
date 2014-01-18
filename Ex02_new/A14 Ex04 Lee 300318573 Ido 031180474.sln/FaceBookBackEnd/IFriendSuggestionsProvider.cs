using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using FacebookWrapper.ObjectModel;

namespace FaceBookBackEnd
{
    public interface IFriendSuggestionsProvider
    {
        void GetSuggestionsAsync<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, Func<T, TKey> i_OrderByFunc);
        
        ConcurrentQueue<User> RegisterForRecommendations(eRecommendationSource i_Source, Action i_Callback);
    }
}

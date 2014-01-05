using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Collections.Concurrent;

namespace FaceBookBackEnd
{
    public interface IFriendSuggestionsProvider
    {
        List<User> GetSuggestions<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc);
        void GetSuggestionsAsync<T, TKey>(eRecommendationSource i_Source, User i_LoggedInUser, Func<T, TKey> i_OrderByFunc);
        ConcurrentQueue<User> RegisterForRecommendations(eRecommendationSource i_Source, Action d);
    }
}

using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Collections.Concurrent;

namespace FaceBookBackEnd
{
    interface IFriendsRecommender
    {
        List<User> GetSuggestions<T, TKey>(User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc);
        void GetSuggestionsAsync<T, TKey>(User i_LoggedInUser, Func<T, TKey> i_OrderByFunc);
        event Action UserRecommendedDelegetas;
        ConcurrentQueue<User> SuggestionsQ { get; }
    }
}

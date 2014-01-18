using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using FacebookWrapper.ObjectModel;

namespace FaceBookBackEnd
{
    public interface IFriendsRecommender
    {
        void GetSuggestionsAsync<T, TKey>(User i_LoggedInUser, Func<T, TKey> i_OrderByFunc);
        
        event Action UserRecommendedDelegetas;
        
        ConcurrentQueue<User> SuggestionsQ { get; }
    }
}

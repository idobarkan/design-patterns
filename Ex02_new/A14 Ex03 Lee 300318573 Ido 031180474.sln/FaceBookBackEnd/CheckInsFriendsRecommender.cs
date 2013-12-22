using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Linq.Expressions;

namespace FaceBookBackEnd
{
    internal class CheckInsFriendsRecommender : IFriendsRecommender
    {
        private DateTime m_lastTimeCheckinsFetched { get; set; }
        private List<Checkin> m_cachedUserCheckins;

        public CheckInsFriendsRecommender()
        {
            m_lastTimeCheckinsFetched = DateTime.MinValue;
            m_cachedUserCheckins = new List<Checkin>();
        }

        public List<User> GetSuggestions<T, TKey>(User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc)
        {
            fetchCheckinsIfNeeded(i_LoggedInUser);

            var sortedCheckinsByCreateTime = m_cachedUserCheckins.Select(x => x)
                                                .OrderBy<Checkin, TKey>(i_OrderByFunc as Func<Checkin, TKey>)
                                                .Reverse();
            return getFriendSuggestionsFromCheckins(i_LoggedInUser, sortedCheckinsByCreateTime, i_MaxResults);
        }

        private void fetchCheckinsIfNeeded(User i_LoggedInUser)
        {
            if (DateTime.Now - m_lastTimeCheckinsFetched > TimeSpan.FromMinutes(2))
            {
                m_cachedUserCheckins = new List<Checkin>(i_LoggedInUser.Checkins);
                m_lastTimeCheckinsFetched = DateTime.Now;
            }
        }

        private List<User> getFriendSuggestionsFromCheckins(
            User i_LoggedInUser, IEnumerable<Checkin> checkins, int i_MaxResults)
        {
            var suggestedUsers = new List<User>();
            var alreadySuggestedUsersIds = new HashSet<string>(i_LoggedInUser.Friends.Select(f => f.Id));
            alreadySuggestedUsersIds.Add(i_LoggedInUser.Id);
            foreach (var checkin in checkins)
            {
                try
                {
                    if (checkin.TaggedUsers != null)
                    {
                        foreach (var taggedUser in checkin.TaggedUsers)
                        {
                            if (!alreadySuggestedUsersIds.Contains(taggedUser.Id))
                            {
                                suggestedUsers.Add(taggedUser);
                                alreadySuggestedUsersIds.Add(taggedUser.Id);
                            }
                        }
                    }
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
                {
                    // this is sometimes thrown from facebook Dll for an unknown reason
                }
            }
            return suggestedUsers.Select(x => x).Take(i_MaxResults).ToList();
        }
    }
}

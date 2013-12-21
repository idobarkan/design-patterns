using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Linq.Expressions;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace FaceBookBackEnd
{
    internal class EventsFriendsRecommender : IFriendsRecommender
    {
        private DateTime m_lastTimeEventsFetched { get; set; }
        private List<Event> m_cachedUserEvents;
        public ConcurrentQueue<User> SuggestionsQ { get; private set;}

        private Action userRecommendedDelegetas;

        public event Action UserRecommendedDelegetas
        {
            add
            {
                userRecommendedDelegetas = null;
                userRecommendedDelegetas += value;
            }
            remove
            {
                userRecommendedDelegetas -= value;
            }
        }

        public EventsFriendsRecommender()
        {
            m_lastTimeEventsFetched = DateTime.MinValue;
            m_cachedUserEvents = new List<Event>();
            SuggestionsQ = new ConcurrentQueue<User>();
        }

        public void GetSuggestionsAsync<T, TKey>(User i_LoggedInUser, Func<T, TKey> i_OrderByFunc)
        {
            fetchEventsIfNeeded(i_LoggedInUser);

            IOrderedEnumerable<Event> sortedEventsByUpdateTime = m_cachedUserEvents
                                            .OrderByDescending<Event, TKey>(i_OrderByFunc as Func<Event, TKey>);

            getFriendSuggestionsFromEventsAsync(i_LoggedInUser, sortedEventsByUpdateTime);
        }

        private void getFriendSuggestionsFromEventsAsync(
            User i_LoggedInUser, IEnumerable<Event> events)
        {
            var alreadySuggestedUsersIds = new HashSet<string>(i_LoggedInUser.Friends.Select(f => f.Id));
            alreadySuggestedUsersIds.Add(i_LoggedInUser.Id);
            foreach (var event_ in events)
            {
                foreach (var user in 
                    event_.AttendingUsers.Concat(event_.InvitedUsers))
                {
                    if (!alreadySuggestedUsersIds.Contains(user.Id))
                    {
                        enqueueUserAndNotify(user);
                        alreadySuggestedUsersIds.Add(user.Id);
                    }
                }
            }
        }

        private void enqueueUserAndNotify(User user)
        {
            SuggestionsQ.Enqueue(user);
            if (userRecommendedDelegetas != null)
            {
                userRecommendedDelegetas.Invoke();
            }
        }

        private void fetchEventsIfNeeded(User i_LoggedInUser)
        {
            if (cachedEventsAreStale)
            {
                m_cachedUserEvents = new List<Event>(i_LoggedInUser.Events);
                m_lastTimeEventsFetched = DateTime.Now;
            }
        }

        private bool cachedEventsAreStale
        {
            get
            {
                return DateTime.Now - m_lastTimeEventsFetched > TimeSpan.FromMinutes(2);
            }
        }

        private List<User> getFriendSuggestionsFromEvents(
            User i_LoggedInUser, IEnumerable<Event> events, int i_MaxResults)
        {
            var suggestedUsers = new List<User>();
            var alreadySuggestedUsersIds = new HashSet<string>(i_LoggedInUser.Friends.Select(f => f.Id));
            alreadySuggestedUsersIds.Add(i_LoggedInUser.Id);
            foreach (var event_ in events)
            {
                foreach (var user in event_.AttendingUsers)
                {
                    if (!alreadySuggestedUsersIds.Contains(user.Id))
                    {
                        suggestedUsers.Add(user);
                        alreadySuggestedUsersIds.Add(user.Id); 
                    } 
                }
            }
            return suggestedUsers.Take(i_MaxResults).ToList();
        }
    }
}

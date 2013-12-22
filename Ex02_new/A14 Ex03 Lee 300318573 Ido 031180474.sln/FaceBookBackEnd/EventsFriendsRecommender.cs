﻿// -----------------------------------------------------------------------
// <copyright file="PhotosFriendsRecommender.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FaceBookBackEnd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;
    using FacebookWrapper;
    using System.Linq.Expressions;

    internal class EventsFriendsRecommender : IFriendsRecommender
    {
        private DateTime m_lastTimeEventsFetched { get; set; }
        private List<Event> m_cachedUserEvents;

        public EventsFriendsRecommender()
        {
            m_lastTimeEventsFetched = DateTime.MinValue;
            m_cachedUserEvents = new List<Event>();
        }

        public List<User> GetSuggestions<T, TKey>(User i_LoggedInUser, int i_MaxResults, Func<T, TKey> i_OrderByFunc)
        {
            fetchEventsIfNeeded(i_LoggedInUser);

            var sortedPhotosByUpdateTime = m_cachedUserEvents.Select(x => x)
                                            .OrderBy<Event, TKey>(i_OrderByFunc as Func<Event, TKey>)
                                            .Reverse();

            return getFriendSuggestionsFromEvents(i_LoggedInUser, sortedPhotosByUpdateTime, i_MaxResults);
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
            return suggestedUsers.Select(x => x).Take(i_MaxResults).ToList();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Collections.Concurrent;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FaceBookBackEnd
{
    internal class PhotosFriendsRecommender : IFriendsRecommender
    {
        private DateTime m_lastTimePhotosFetched { get; set; }

        private List<Photo> m_cachedUserPhotos;

        public ConcurrentQueue<User> SuggestionsQ { get; private set; }

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

        public PhotosFriendsRecommender()
        {
            m_lastTimePhotosFetched = DateTime.MinValue;
            m_cachedUserPhotos = new List<Photo>();
            SuggestionsQ = new ConcurrentQueue<User>();
        }

        public void GetSuggestionsAsync<T, TKey>(User i_LoggedInUser, Func<T, TKey> i_OrderByFunc)
        {
            fetchPhotosIfNeeded(i_LoggedInUser);

            IEnumerable<Photo> sortedPhotosByUpdateTime = m_cachedUserPhotos
                .OrderByDescending<Photo, TKey>(i_OrderByFunc as Func<Photo, TKey>);

            getFriendSuggestionsFromPhotosAsync(i_LoggedInUser, sortedPhotosByUpdateTime);
        }

        private List<Photo> getAllPhotos(User i_LoggedInUser)
        {
            List<Photo> aggregatedPhotos = new List<Photo>();

            foreach (var album in i_LoggedInUser.Albums)
            {
                foreach (var photo in album.Photos)
                {
                    aggregatedPhotos.Add(photo);
                }
            }

            return aggregatedPhotos;
        }

        private void fetchPhotosIfNeeded(User i_LoggedInUser)
        {
            if (cachedPhotosAreStale)
            {
                m_cachedUserPhotos = getAllPhotos(i_LoggedInUser);
                m_lastTimePhotosFetched = DateTime.Now;
            }
        }

        private bool cachedPhotosAreStale
        {
            get
            {
                return DateTime.Now - m_lastTimePhotosFetched > TimeSpan.FromMinutes(2);
            }
        }

        private List<User> getFriendSuggestionsFromPhotos(
            User i_LoggedInUser, IEnumerable<Photo> photos, int i_MaxResults)
        {
            var suggestedUsers = new List<User>();
            var alreadySuggestedUsersIds = new HashSet<string>(i_LoggedInUser.Friends.Select(f => f.Id));
            alreadySuggestedUsersIds.Add(i_LoggedInUser.Id);
            foreach (var photo in photos)
            {
                if (photo.Tags != null)
                {
                    foreach (var tag in photo.Tags)
                    {
                        if (!alreadySuggestedUsersIds.Contains(tag.User.Id))
                        {
                            suggestedUsers.Add(tag.User);
                            alreadySuggestedUsersIds.Add(tag.User.Id);
                        }
                    }
                }
            }

            return suggestedUsers.Take(i_MaxResults).ToList();
        }

        private void getFriendSuggestionsFromPhotosAsync(
            User i_LoggedInUser, IEnumerable<Photo> photos)
        {
            var alreadySuggestedUsersIds = new HashSet<string>(i_LoggedInUser.Friends.Select(f => f.Id));
            alreadySuggestedUsersIds.Add(i_LoggedInUser.Id);
            foreach (var photo in photos)
            {
                if (photo.Tags != null)
                {
                    foreach (var tag in photo.Tags)
                    {
                        if (!alreadySuggestedUsersIds.Contains(tag.User.Id))
                        {
                            enqueueUserAndNotify(tag.User);
                            alreadySuggestedUsersIds.Add(tag.User.Id);
                        }
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
    }
}

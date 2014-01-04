using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FindTagsAround
{
    public class FacebookCheckInVicinityProvider : ICheckInVicinityProvider
    {
        public List<Checkin> getAllUserFriendsRecentTags(
            User i_LoggedInUser, DateTime i_Oldest, eRecommendationSortKey i_Sortby, int i_Max_count)
        {
            List<Checkin> aggregatedCheckins = new List<Checkin>();
            foreach (User friend in i_LoggedInUser.Friends)
            {
                foreach (Checkin checkIn in friend.Checkins)
                {
                    if (checkIn.CreatedTime > i_Oldest)
                    {
                        aggregatedCheckins.Add(checkIn);
                    }
                }
            }
            if (i_Sortby == eRecommendationSortKey.CreatedTime)
            {
                return aggregatedCheckins.OrderBy(x => x.CreatedTime)
                    .Take(i_Max_count)
                    .ToList();
            }
            else if (i_Sortby == eRecommendationSortKey.CommentsCount)
            {
                return aggregatedCheckins
                    .OrderBy(x => x.Comments.Count)
                    .Take(i_Max_count)
                    .ToList();
            }
            else
            {
                return aggregatedCheckins.ToList();
            }
        }
    }
}

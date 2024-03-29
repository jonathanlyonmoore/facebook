﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisharoo.FisharooCore.Core.Domain
{
    public partial class AlertType
    {
        public enum AlertTypes
        {
            AccountCreated = 1,
            ProfileCreated = 2,
            AccountModified = 3,
            ProfileModified = 4,
            NewAvatar = 5,
            AddedFriend = 6,
            AddedPicture = 7,
            FriendAdded = 8,
            FriendRequest = 9,
            StatusUpdate = 10,
            NewBlogPost = 11,
            UpdatedBlogPost = 12,
            NewBoardPost = 13,
            NewBoardThread = 14
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDev.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime DandT { get; set; }
        public String Author { get; set; }
        public string Content { get; set; }
        //link to announcement db
        public int AnnouncementId { get; set; }
        //link announcement to user
        public virtual ApplicationUser User { get; set; }
    }
}
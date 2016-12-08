﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDev.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime DandT { get; set; }
        public String Author { get; set; }
        public string Content { get; set; }
        //link announcement to user
        public virtual ApplicationUser User { get; set; }
    }
}
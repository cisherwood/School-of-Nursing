﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _420Project.Models
{
    public class UserEvent
    {
        [Key]
        public int UserEventId { get; set; }

        public int EventId { get; set; }

        public string UserId { get; set; }

        public virtual Event Event { get; set; }

    }
}
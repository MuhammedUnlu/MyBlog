﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Domain.Entities
{
    public class User : BaseEntity
    {
        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }



        public User Author { get; set; }
        public User Category { get; set; }
    }
}
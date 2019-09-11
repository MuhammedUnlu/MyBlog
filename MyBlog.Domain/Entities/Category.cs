using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Domain.Entities
{
    public class User : BaseEntity
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public ICollection<User> Posts { get; set; }
    }
}

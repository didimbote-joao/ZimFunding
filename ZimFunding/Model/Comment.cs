﻿namespace ZimFunding.Model
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

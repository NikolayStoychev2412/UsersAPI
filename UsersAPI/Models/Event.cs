﻿namespace UsersAPI.Models
{
    public class Event
    {
        public int Id { get; set; }

        public DateTime EndDate { get; set; }

        public int Duration { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string Organizer { get; set; }

        public DateTime StartDate { get; set; }
    }
}

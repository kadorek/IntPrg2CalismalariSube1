﻿namespace Web1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Attenders { get; set; }
    }
}

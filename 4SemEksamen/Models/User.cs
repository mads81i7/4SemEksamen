﻿namespace _4SemEksamen.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public string RefreshToken { get; set; }
    }
}

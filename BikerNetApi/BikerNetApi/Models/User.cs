﻿namespace BikerNetApi.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? Location { get; set; }
    }
}

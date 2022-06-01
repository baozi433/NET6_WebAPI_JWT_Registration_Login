﻿namespace NET6_WebAPI_JWT_Registration_Login.Models
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}

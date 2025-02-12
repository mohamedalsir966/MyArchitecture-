﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class AuthDto
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public string Email22222 { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        //public DateTime? ExpiresOn { get; set; }

        [JsonIgnore]
        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiration { get; set; }
    }
    public class Users
    {
        public List<AuthDto> users { get; set; }
    }
}

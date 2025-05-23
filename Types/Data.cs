﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunDraw.Types
{
    public class Data
    {
        public UserData user = new UserData();
        public string accessToken = "";
        public string refreshToken = "";
    }

    public class UserData
    {
        public string id = "";
        public string username = "";
        public string email = "";
        public DateTime createdAt;
        public string avatar = "";
    }

    public class TokenData
    {
        public string accessToken = "";
    }
    public class UserProfile
    {
        public string Username { get; set; } = "";
        public string ID { get; set; } = "";
        public DateTime JoinedDate { get; set; }
        public string Email { get; set; } = "";
    }
    public class PlayerList
    {
        public string id { get; set; } = "";
        public int score { get; set; } = 0;
        public string name { get; set; } = "";
    }
    public enum DrawCommand
    {
        CLEAR,
        PENCIL,
        ERASER
    }
}

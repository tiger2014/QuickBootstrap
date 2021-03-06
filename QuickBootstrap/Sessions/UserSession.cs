﻿using System;

namespace QuickBootstrap.Sessions
{
    [Serializable]
    public class UserSession
    {
        public string UserName { get; set; }

        public string UserNick { get; set; }

        public string LoginIpAddress { get; set; }

        public DateTime LoginDateTime { get; set; }

        public int DepartmentId { get; set; }

        public int RoleId { get; set; }
    }
}
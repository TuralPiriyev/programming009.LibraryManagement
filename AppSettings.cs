﻿using programming009.LibraryManagement.Core.Domain.Enums;

namespace programming009.LibraryManagement.Settings
{
    public class AppSettings
    {
        public string DbHost { get; set; }
        public int DbPort { get; set; }
        public DatabaseType DbType { get; set; }
        public string DbName { get; set; }
        public bool WindowsAuthentication { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
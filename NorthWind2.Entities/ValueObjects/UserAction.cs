﻿namespace NorthWind2.Entities.ValueObjects
{
    public class UserAction (string user, string description)
    {
        public DateTime CreateDateTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;
    }
}

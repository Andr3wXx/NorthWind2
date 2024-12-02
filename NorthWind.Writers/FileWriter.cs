﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NorthWind.Writers
{
    internal class FileWriter : IUserActionWriter
    {
        public void Writer(UserAction action)
        {
            File.AppendAllText("AppLogs.txt",
                string.Format("FileWriter: {0}, {1}, {2}",
                action.CreateDateTime, action.User, action.Description));
        }
    }
}
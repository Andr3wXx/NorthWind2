using NorthWind2.Entities.Interfaces;
using NorthWind2.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
    public class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
           Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
                action.CreateDateTime, action.User, action.Description);
        }
    }
}

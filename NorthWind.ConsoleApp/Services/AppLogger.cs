using NorthWind2.Entities.Interfaces;
using NorthWind2.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NorthWind.ConsoleApp.Services
{
    internal class AppLogger(IEnumerable <IUserActionWriter> writer)
    {
        public void WriteLog(string message)
        {
            UserAction Log = new UserAction("System", message);
            foreach(var Writer  in writer) 
            Writer.Writer(Log);
        }
    }
}

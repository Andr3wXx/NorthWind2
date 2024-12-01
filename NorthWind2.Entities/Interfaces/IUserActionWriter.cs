using NorthWind2.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind2.Entities.Interfaces
{
    public interface IUserActionWriter
    {
        void Write(UserAction action);
    }
}

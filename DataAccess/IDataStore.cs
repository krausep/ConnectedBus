using ConnectedBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataStore
    {
        void Write<T>(T data) where T : IHaveAnId;
        T Read<T>(string key);
    }
}

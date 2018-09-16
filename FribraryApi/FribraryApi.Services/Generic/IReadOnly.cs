using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FribraryApi.Services.Generic
{
    public interface IReadOnly<T> where T : class
    {
        IQueryable<T> GetAll();
        T Get(int id);
    }
}

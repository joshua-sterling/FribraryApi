using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryApi.Services.Generic
{
    public interface IReadWrite<T> : IReadOnly<T> where T : class
    {
        void Post(T entity);
    }
}

using FribraryAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FribraryApi.Services.Generic.Impl
{
    public class ReadWrite<T> : ReadOnly<T>, IReadWrite<T> where T : class
    {
        public ReadWrite(FribraryApiContext context) : base(context) { }

        public virtual void Post(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}

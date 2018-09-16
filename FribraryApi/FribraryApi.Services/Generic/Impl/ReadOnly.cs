using FribraryAPI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FribraryApi.Services.Generic.Impl
{
    public abstract class ReadOnly<T> : IReadOnly<T> where T : class
    {

        protected FribraryApiContext _context;

        public ReadOnly(FribraryApiContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll() {

            return _context.Set<T>();
        }

        public virtual T Get (int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}

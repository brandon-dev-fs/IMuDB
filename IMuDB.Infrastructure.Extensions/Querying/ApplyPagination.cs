using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace IMuDB.Infrastructure.Extensions.Querying
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplyPagination<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            int offset = (pageNumber - 1) * pageSize;
            return query.Skip(offset).Take(pageSize);
        }
    }
}

using System;
using System.Linq;
using System.Linq.Expressions;
using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.Core.Interfaces
{
    public interface IRepo<T>
    {
        T Get(int id);
        IQueryable<T> GetAll(bool showDeleted = false);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate, bool showDeleted = false);
        T Insert(T o);
        void Save();
        void Delete(T o, bool hard);
        void Restore(T o);
        void Attach(BaseEntity b);
        void DeAttach(BaseEntity b);
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.Core.Interfaces
{
    public interface ICrudService<T> where T : BaseEntity, new()
    {
        int Update(T item);
        void Save();
        void Delete(int id, bool hard = false);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Where(Expression<Func<T, bool>> func, bool showDeleted = false);
        void Restore(int id);
        void Attach(BaseEntity t);
    }
}
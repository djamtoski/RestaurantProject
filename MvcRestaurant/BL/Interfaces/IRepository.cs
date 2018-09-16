using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IRepository<T>
    {
        void Insert(T entity);

        void Delete(int id);

        void Delete(T entity);

        IQueryable<T> GetAll();

        T GetById(int id);

        bool Exists(int id);

        void Update(T entity);
    }
}

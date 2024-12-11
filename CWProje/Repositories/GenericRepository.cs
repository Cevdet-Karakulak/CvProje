using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using CWProje.Models.Entity;

namespace CWProje.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        CwProjeEntities db = new CwProjeEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T p) 
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void Tdelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T Tget(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Tupdate(T p)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>> where)
        {  
            return db.Set<T>().FirstOrDefault(where); 
        }
       
    }
}
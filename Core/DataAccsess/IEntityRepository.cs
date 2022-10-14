using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccsess
{
    //Burad T IEntity implementine aid olan deyerleri hemcinin Ientitiy ozunude ala biler. Bizde esas meqsed odur ki IEntity aid olan klaslari alsin. Interface new-lene bilmediyi ucun ,new() edirik ki new-lene bilen elementleri alsin. Belelikle implement ve implemente aid klaslari yox yalniz imlemente aid olan klaslari burada nezere alacaq.
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        T Get(Expression<Func<T,bool>> filter);
        IList<T> Getlist(Expression<Func<T, bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

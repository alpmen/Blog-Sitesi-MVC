using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IRepository<T>
    {
        //Tek tek tablo adlarını yazmak yerine T değerini gönderiyoruz, bu T değeri entity yerini tutuyor.
        List<T> List();
        void Insert(T p);
        void Delete(T p);

        //Tek bir değer döndürür (ör ID'si 5 olan yazar)
        T Get(Expression<Func<T, bool>> filter);
        void Update(T p);

        //Liste döndürür (ör yazarlar veya ismi Alp olan yazarlar)
        List<T> List(Expression<Func<T, bool>> filter); //Şartlı arama için kullanılacak fonksiyon
    }
}

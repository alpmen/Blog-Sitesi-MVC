using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal: IRepository<Category>
    {
       //Repository interfacesinden kalıtım al ve T değeri olarak category parametresini geç
    }
}

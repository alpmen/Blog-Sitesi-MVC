using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentServices
    {
        List<Content> GetList();
        void ContentAddBL(Content content);


        //Başlık id sine göre o başlıkta yer alan içerikleri döndürür.
        List<Content> GetListByHeadingID(int id);
        Content GetByID(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}

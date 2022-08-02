using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutManager : IAboutServices
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void AboutAddBL(About about)
        {
            aboutDal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            aboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            aboutDal.Update(about);
        }

        public About GetByID(int id)
        {
            return aboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return aboutDal.List();
        }
    }
}

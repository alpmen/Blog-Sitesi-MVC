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
    public class MessageManager: IMessageServices
    {
        IMessageDal messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            this.messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetList()
        {
            return messageDal.List(x=>x.ReceiverMail=="admin@mail.com");
        }

        public void MessageAddBL(Message message)
        {
            messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            messageDal.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            messageDal.Update(message);
        }
    }
}

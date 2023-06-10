using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Absract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendInbox(string p);
        void MessageAdd(Message message);
        Message GetByiD(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}

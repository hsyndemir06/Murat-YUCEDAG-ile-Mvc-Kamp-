using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Absract
{
    public interface IContentService
    {
        List<Content> GetList(string p);
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingiD(int id);
        void ContentAdd(Content content);
        Content GetByiD(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}

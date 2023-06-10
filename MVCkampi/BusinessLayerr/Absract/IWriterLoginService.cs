using EntityLayerr.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerr.Absract
{
    public interface IWriterLoginService
    {
        Writer GetWriter(string username, string password);
    }
}

using Line_Production.USAPReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production.Business
{
    public static class USAPHelper
    {
        public static USAPReference.USAPWebServiceSoapClient usapservice = new USAPReference.USAPWebServiceSoapClient();
        public static BCLBFLMEntity GetBoxInfo(string mathung)
        {
            var bc = usapservice.GetByBcNo(mathung);
            return bc;
        }
    }
}

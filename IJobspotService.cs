using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Jobspot.Wcf
{
    [ServiceContract]
    public interface IJobspotService
    {
        [OperationContract]
        [WebInvoke(Method="GET",
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "Test")]
        string Test();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Jobspot.Wcf
{
    public class JobspotService : IJobspotService
    {
        public string Test()
        {
            return "Hello World";
        }
    }
}

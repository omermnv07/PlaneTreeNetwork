using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Core.Utilities.Common
{
    public class WcfProxy<T>
    {
        //http://localhost:55499/{0}.svc   0 yazılan yere servicelerimizi gönderiyoruz. örn(ICustomerService vs.vs.)
        public static T CreatChannel()
        {
            string basedress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(basedress, typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding,address);

            return channel.CreateChannel();
        }
    }
}

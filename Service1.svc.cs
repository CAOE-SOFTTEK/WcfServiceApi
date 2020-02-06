using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Service1> videos = new List<Service1>();
        YouTubeService ytb = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = "AIzaSyC265U8n9gvpl4bFiW0Kl_eyMMSTe-7QPQ",
            ApplicationName = "Rockola"
        });
    }
}

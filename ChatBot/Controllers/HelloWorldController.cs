using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace ChatBot.Controllers
{
    public class HelloWorldController : TwilioController
    {
        [HttpPost]
        public TwiMLResult Index(SmsRequest request)
        {
            var response = new MessagingResponse();
            response.Message("Hello World");
            return TwiML(response);
        }
    }
}
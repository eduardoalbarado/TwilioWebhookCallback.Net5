using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;
using Twilio.TwiML;

namespace TwilioWebhookCallback.Net5.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WebhookController : TwilioController
    {
        /// <summary>
        /// Return a Twilio empty response
        /// </summary>
        /// <remarks>
        /// Return a basic Twilio Empty Response
        /// </remarks>
        /// <response code="200">Return a Twilio XML.</response> 
        [HttpPost]
        public TwiMLResult Index(SmsRequest request)
        {
            var response = new MessagingResponse();

            return TwiML(response);
        }
    }
}

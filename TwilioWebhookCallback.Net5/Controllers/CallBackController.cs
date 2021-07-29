using Microsoft.AspNetCore.Http;
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
    public class CallBackController : TwilioController
    {
        /// <summary>
        /// This method is for receive SMS Status from Twilio
        /// </summary>
        /// <remarks>This method is for receive SMS Status from Twilio</remarks>
        /// <param name="SmsSid">SmsSid message</param>
        /// <param name="SmsStatus">Status message. For instance "sent"</param>
        /// <param name="MessageStatus">For instance "sent"</param>
        /// <param name="To">To phone number</param>
        /// <param name="MessageSid">guid as parameter</param>
        /// <param name="AccountSid">Twilio Account Sid</param>
        /// <param name="From">From phone number</param>
        /// <param name="ApiVersion">Page number - defaults to 0</param>
        /// <response code="200">Handled</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Index(String SmsSid, String SmsStatus, String MessageStatus, String To, String MessageSid, String AccountSid, String From, String ApiVersion)
        {
            // Add your business logic

            return Content("Handled");
        }
    }
}

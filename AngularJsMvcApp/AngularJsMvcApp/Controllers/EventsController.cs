using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = System.Xml.Formatting;
using AngularJsMvcApp.Models;
using System.Net;

namespace AngularJsMvcApp.Controllers
{
    public class EventsController : Controller
    {
        EventsRepository eventsRepository = new EventsRepository();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult GetTalkDetails()
        { 
            var setting = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver()};
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(eventsRepository.GetTalks(),setting),
                ContentType = "application/json"
            };
            return jsonResult;

        }
        public ActionResult GetSpeakerDetails()
        {
            //var jsonResult = eventsRepository.GetSpeakers().ToList();
            //return Json(jsonResult);
            var setting = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(eventsRepository.GetSpeakers(), setting),
                ContentType = "application/json"
            };
            return jsonResult;
            
        }
        [HttpPost]
        public ActionResult AddTalk(TalkVM talk)
        {
            eventsRepository.AddTalk(talk);
            return new HttpStatusCodeResult(HttpStatusCode.OK, "Item added");
        }
	}
}
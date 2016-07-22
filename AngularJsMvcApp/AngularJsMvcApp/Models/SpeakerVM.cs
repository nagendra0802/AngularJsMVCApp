using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJsMvcApp.Models
{
    public class SpeakerVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Expertise { get; set; }
        public string TalksDelivered { get; set; }
    }
}
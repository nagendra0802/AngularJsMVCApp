﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJsMvcApp.Models
{
    public class EventsRepository
    {

        static TalkVM[] talks = new[]
            {
                new TalkVM {Id = "T001", Name="Real Time Web Applications with SignalR",Speaker= "Brij Bhushan Mishra", Venue= "Hall 1", Duration= "45" },
                new TalkVM { Id= "T002", Name= "Power of Node.js", Speaker= "Dhananjay Kumar", Venue= "Hall 2", Duration= "45" },
                new TalkVM { Id= "T003", Name= "Getting started with AngularJS", Speaker= "Brij Bhushan Mishra", Venue= "Hall 1", Duration= "60" },
                new TalkVM { Id= "T004", Name= "Microsoft Azure - Your cloud destination", Speaker= "Gaurav", Venue= "Hall 1", Duration= "45" },
                new TalkVM { Id= "T005", Name= "Test", Speaker= "Gaurav", Venue= "Hall 5", Duration= "25" }
            };


        public TalkVM[] GetTalks()
        {
            return talks;
        }
        public SpeakerVM[] GetSpeakers()
        {
            var speakers = new[]
            {
                new SpeakerVM { Id= "S001", Name= "Brij Bhushan Mishra", Expertise= "Client Script, ASP.NET", TalksDelivered= "28" },
                new SpeakerVM { Id= "S002", Name= "Dhananjay Kumar", Expertise= "Node.js, WCF", TalksDelivered= "54" },
                new SpeakerVM { Id= "S003", Name= "Gaurav", Expertise= "Microsoft Azure", TalksDelivered= "68" }
            };
            return speakers;
        }
        public void AddTalk(TalkVM talk)
        {
            talks = talks.Concat(new[] { talk }).ToArray();
        }
    }
}
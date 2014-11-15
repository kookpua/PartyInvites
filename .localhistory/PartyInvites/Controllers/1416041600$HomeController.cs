﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "good morning" : "good aftetnoon";
            return View();
        }

        public ActionResult RsvpForm()
        {
            return View();
        }
        public ActionResult RsvpForm()
        {
            return View("Thanks",GuestResponse);
        }
    }
}

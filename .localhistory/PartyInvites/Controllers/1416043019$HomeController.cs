using System;
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

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "good morning" : "good aftetnoon";
            return View();
        }

        /// <summary>
        /// 非js验证
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
                return View("Thanks", guestResponse);
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult RsvpForm1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm1(GuestResponse guestResponse)
        {
            //if (ModelState.IsValid)
            return View("Thanks", guestResponse);
            //else
            //{
            //    return View();
            //}
        }
    }
}

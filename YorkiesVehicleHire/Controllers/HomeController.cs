﻿// ***********************************************************************
// Assembly         : YorkiesVehicleHire
// Author           : Faisal
// Created          : 05-02-2018
//
// Last Modified By : Faisal
// Last Modified On : 05-08-2018
// ***********************************************************************
// <copyright file="HomeController.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YorkiesVehicleHire.Controllers
{
    /// <summary>
    /// Class HomeController.
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    [AllowAnonymous]
    [RequireHttps]  //This attribute forces all requests to use HTTPS
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Abouts this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Contacts this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
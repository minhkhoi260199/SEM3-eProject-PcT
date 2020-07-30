﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("policy")]
    public class PolicyController : Controller
    {
        private DatabaseContext db;
        public PolicyController(DatabaseContext _db)
        {
            db = _db;
        }

        //View policies
        [Route("")]
        [Route("index")]
        public IActionResult Index(int id)
        {
            ViewBag.policies = db.Medicals.Find(id).Policies.ToList();
            return View("Index");
        }

    }
}
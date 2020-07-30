﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/companies")]
    public class CompaniesController : Controller
    {
        private ICompanyDetailsResponsitory icompanyDetailsResponsitory;
        private IMedicalsResponsitory imedicalsResponsitory;
        private IPoliciesResponsitory ipoliciesResponsitory;

        public CompaniesController(ICompanyDetailsResponsitory _icompanyDetailsResponsitory, IMedicalsResponsitory _imedicalsResponsitory, IPoliciesResponsitory _ipoliciesResponsitory)
        {
            icompanyDetailsResponsitory = _icompanyDetailsResponsitory;
            imedicalsResponsitory = _imedicalsResponsitory;
            ipoliciesResponsitory = _ipoliciesResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).ToList();

            var html = "";
            var count = 0;
            foreach (var company in companies)
            {
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + company.CompanyName + "</td>" +
                    "<td>" + company.Address + "</td>" +
                    "<td>" + company.Phone + "</td>" +
                    "<td><a href='"+ company.CompanyUrl + "'>" + company.CompanyUrl + "</a></td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail(" + company.Id.ToString() + ")' style='font-weight:bold'>More Details</a>" +
                    "</td></tr>";
                if (count < companies.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }
            return Json(new[] { new
                {
                    status = true,
                    data = html
                }});
        }

        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            var company = await icompanyDetailsResponsitory.GetById(id);
            return View("detail", company);
        }

        [Route("edit")]
        public async Task<IActionResult> Edit(CompanyDetails company)
        {
            var oldCompany = await icompanyDetailsResponsitory.GetById(company.Id);
            if (ModelState.IsValid)
            {
                await icompanyDetailsResponsitory.Update(company.Id, company);
                return RedirectToAction("index", "companies");
            }
            return View("detail", company);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(CompanyDetails company)
        {
            if (ModelState.IsValid)
            {
                await icompanyDetailsResponsitory.Create(company);
                return RedirectToAction("index", "companies");
            }
            foreach (var modelStateKey in ModelState.Keys)
            {
                var modelStateVal = ModelState[modelStateKey];
                foreach (var error in modelStateVal.Errors)
                {
                    var key = modelStateKey;
                    var errorMessage = error.ErrorMessage;
                    Debug.WriteLine(key);
                    Debug.WriteLine(errorMessage);
                }
            }
            Debug.WriteLine("LOI");
            return View("create");
        }
    }
}
﻿using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public interface ICompanyDetailsResponsitory : IGenericRepository<CompanyDetails>
    {
        public List<CompanyDetails> SearchName(string name);
    }
}

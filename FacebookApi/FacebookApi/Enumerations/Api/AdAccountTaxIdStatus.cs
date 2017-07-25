﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApi.Enums.Api
{
    public enum AdAccountTaxIdStatus
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// VAT not required- US/CA
        /// </summary>
        VAT_Not_Required = 1,

        /// <summary>
        /// VAT information required
        /// </summary>
        VAT_Information_Required = 2,

        /// <summary>
        /// VAT information submitted
        /// </summary>
        VAT_Information_Submitted = 3,

        /// <summary>
        /// Offline VAT validation failed
        /// </summary>
        Offline_VAT_Validation_Failed = 4,

        /// <summary>
        /// Account is a personal account
        /// </summary>
        Personal_Account = 5
    }
}
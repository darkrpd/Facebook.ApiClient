﻿using FacebookApi.Enums;
using FacebookApi.IApiEngine;

namespace FacebookApi.ApiEngine
{
    public class ApiRequestParameter : IApiRequestParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public ApiRequestParameterType Type { get; set; }
    }
}
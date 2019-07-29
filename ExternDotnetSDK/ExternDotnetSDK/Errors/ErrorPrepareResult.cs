﻿using System.Net;
using ExternDotnetSDK.Common;
using ExternDotnetSDK.Drafts.Check;
using ExternDotnetSDK.Drafts.Prepare;
using ExternDotnetSDK.JsonConverters;
using Newtonsoft.Json;

namespace ExternDotnetSDK.Errors
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class ErrorPrepareResult : Error, IPrepareResult
    {
        public ErrorPrepareResult(string message, Urn id)
        {
            StatusCode = HttpStatusCode.BadRequest;
            Message = message;
            Id = id;
        }

        public CheckResultData CheckResult { get; set; }
        public Link[] Links { get; set; }
        public PrepareStatus Status { get; set; }
    }
}
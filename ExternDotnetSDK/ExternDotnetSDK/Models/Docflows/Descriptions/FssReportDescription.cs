﻿using System;
using Kontur.Extern.Client.Models.JsonConverters;
using Newtonsoft.Json;

namespace Kontur.Extern.Client.Models.Docflows.Descriptions
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class FssReportDescription : DocflowDescription
    {
        public FormVersion FormVersion { get; set; }
        public string RegistrationNumber { get; set; }
        public string FssId { get; set; }
        public string FssStageDescription { get; set; }
        public string FssStageErrorCode { get; set; }
        public string FssStageErrorExtend { get; set; }
        public string FssStageType { get; set; }
        public string FssStageStatus { get; set; }
        public DateTime? FssStageDate { get; set; }
        public DateTime? PeriodBegin { get; set; }
        public DateTime? PeriodEnd { get; set; }
    }
}
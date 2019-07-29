﻿using System.Runtime.Serialization;
using ExternDotnetSDK.JsonConverters;
using Newtonsoft.Json;

namespace ExternDotnetSDK.Drafts.Meta
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class AdditionalInfo
    {
        /// <summary>Тема письма</summary>
        [DataMember]
        public string Subject { get; set; }
    }
}
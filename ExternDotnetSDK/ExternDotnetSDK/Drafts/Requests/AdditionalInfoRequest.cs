﻿using System.Runtime.Serialization;
using ExternDotnetSDK.JsonConverters;
using Newtonsoft.Json;

namespace ExternDotnetSDK.Drafts.Requests
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class AdditionalInfoRequest
    {
        /// <summary>Тема письма</summary>
        [DataMember]
        public string Subject { get; set; }

        /// <summary>Сертификаты, используемые для подписания</summary>
        [DataMember]
        public string[] AdditionalCertificates { get; set; }
    }
}
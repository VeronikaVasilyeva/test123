﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using ExternDotnetSDK.Common;
using ExternDotnetSDK.Drafts.Meta;
using ExternDotnetSDK.DraftsBuilders.Builders.Data;
using ExternDotnetSDK.JsonConverters;
using Newtonsoft.Json;

namespace ExternDotnetSDK.DraftsBuilders.Builders
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class DraftsBuilderMeta
    {
        [Required]
        [DataMember]
        public Sender Sender { get; set; }

        [Required]
        [DataMember]
        public AccountInfo Payer { get; set; }

        [Required]
        [DataMember]
        public RecipientInfo Recipient { get; set; }

        [Required]
        [DataMember]
        public Urn BuilderType { get; set; }

        [Required]
        [DataMember]
        public DraftsBuilderData BuilderData { get; set; }
    }
}
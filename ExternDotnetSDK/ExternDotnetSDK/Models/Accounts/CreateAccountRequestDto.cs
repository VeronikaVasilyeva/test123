﻿using System.ComponentModel.DataAnnotations;
using Kontur.Extern.Client.Models.JsonConverters;
using Newtonsoft.Json;

namespace Kontur.Extern.Client.Models.Accounts
{
    [JsonObject(NamingStrategyType = typeof (KebabCaseNamingStrategy))]
    public class CreateAccountRequestDto
    {
        [Required]
        public string Inn { get; set; }

        public string Kpp { get; set; }

        [Required]
        public string OrganizationName { get; set; }
    }
}
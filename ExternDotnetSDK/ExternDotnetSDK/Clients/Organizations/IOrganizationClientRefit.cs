﻿using System;
using System.Threading.Tasks;
using ExternDotnetSDK.Organizations;
using Refit;

namespace ExternDotnetSDK.Clients.Organizations
{
    internal interface IOrganizationClientRefit
    {
        [Get("/v1/{accountId}/organizations?inn={inn}&kpp={kpp}&skip={skip}&take={take}")]
        Task<OrganizationBatch> GetAllOrganizations(Guid accountId, string inn = null, string kpp = null, int skip = 0, int take = 1000);

        [Get("/v1/{accountId}/organizations/{orgId}")]
        Task<Organization> GetOrganization(Guid accountId, Guid orgId);

        [Put("/v1/{accountId}/organizations/{orgId}")]
        Task<Organization> UpdateOrganization(Guid accountId, Guid orgId, [Body] UpdateOrganizationRequestDto request);

        [Post("/v1/{accountId}/organizations")]
        Task<Organization> CreateOrganization(Guid accountId, [Body] CreateOrganizationRequestDto request);

        [Delete("/v1/{accountId}/organizations/{orgId}")]
        Task DeleteOrganization(Guid accountId, Guid orgId);
    }
}
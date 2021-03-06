﻿// Copyright (c) Brock Allen, Dominick Baier, Michele Leroux Bustamante. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
//using PolicyServer.Runtime.Client;

namespace KlipperApi.DataAccess.PolicyRequirements
{
    public class LeaveApplicationRequirementHandler : AuthorizationHandler<LeaveApplicationRequirement>
    {
        //private readonly IPolicyServerRuntimeClient _client;

        public LeaveApplicationRequirementHandler(/*IPolicyServerRuntimeClient client*/)
        {
            //_client = client;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, LeaveApplicationRequirement requirement)
        {
            //var user = context.User; var allowed = false;

            //if (await _client.HasPermissionAsync(user, "ApproveLeave"))
            //{
            //    if (requirement.Amount <= 10) allowed = true;
            //    else allowed = await _client.IsInRoleAsync(user, "TeamLeader");
            //    context.Succeed(requirement);
            //}
        }
    }
}
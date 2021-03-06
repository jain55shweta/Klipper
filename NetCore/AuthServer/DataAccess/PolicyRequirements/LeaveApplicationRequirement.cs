﻿// Copyright (c) Brock Allen, Dominick Baier, Michele Leroux Bustamante. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Authorization;

namespace AuthServer.DataAccess.PolicyRequirements
{
    public class LeaveApplicationRequirement : IAuthorizationRequirement
    {
        public string MedicationName { get; set; }
        public int Amount { get; set; }
    }
}

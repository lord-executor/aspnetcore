// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Identity.DefaultUI.WebSite;
using Identity.DefaultUI.WebSite.Data;

namespace Microsoft.AspNetCore.Identity.FunctionalTests.IdentityUserTests
{
    public class Bootstrap3AuthorizationTests : AuthorizationTests<ApplicationUserStartup, ApplicationDbContext>
    {
        public Bootstrap3AuthorizationTests(ServerFactory<ApplicationUserStartup, ApplicationDbContext> serverFactory) : base(serverFactory)
        {
            serverFactory.BootstrapFrameworkVersion = "V4";
        }
    }
}
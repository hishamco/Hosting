// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Hosting.Internal;
using Xunit;

namespace Microsoft.AspNet.Hosting.Tests
{
    public class HostingUtilitiesTests
    {
        [Fact]
        public void ReadWebRootFromProjectJson()
        {
            var root = HostingUtilities.GetWebRoot(".");
            Assert.True(root.EndsWith("testroot"));
        }
    }
}
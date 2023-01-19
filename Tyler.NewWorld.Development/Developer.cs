// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

using System.Runtime.InteropServices;

namespace Tyler.NewWorld.Development.Private {
    public static class Developer {
        // If true, all actions provided by the library will be audited.
        public static bool ShouldAudit { get; set; } = false;
    }
}
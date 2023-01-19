// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

namespace Tyler.NewWorld.Development.Private {
    using System;
    
    public sealed class Audit {
        public AuditLevel Level { get; set; } = AuditLevel.Unknown;
        public string Origin { get; set; } = "Unknown";
        public string Target { get; set; } = "NewWorld";
        public string Message { get; set; } = "";
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
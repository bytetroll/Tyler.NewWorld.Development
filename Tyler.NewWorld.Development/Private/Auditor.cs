// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

namespace Tyler.NewWorld.Development.Private {
    public sealed class Auditor {
        public delegate void OnAuditRequest(Audit audit) {
            
        }

        private ILogger GetAuditorLog(Audit audit) {
            switch (audit.Origin) {
                case "NewWorld" {
                    
                }
            }
        }
    }
}
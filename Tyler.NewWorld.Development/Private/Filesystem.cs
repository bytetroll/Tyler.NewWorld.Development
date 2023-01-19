// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 


namespace Tyler.NewWorld.Development.Private {
    using System;
    using System.IO;
    
    internal static class Filesystem {
        public static string KnownPath_Drive = "C:";
        public static string KnownPath_Home = $"{Drive}/NwDevelopment";
        public static string KnownPath_OverrideFile = $"{Home}/NwDevelopment.yaml";
        
        public static bool DoesOverrideFileExist() {
            return File.Exists(KnownPath_OverrideFile);
        }
        
    }
}
// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

using Tyler.NewWorld.Development.Private;

namespace Tyler.NewWorld.Development {
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    public static class DeveloperConsole {
        private static IList<DeveloperConsoleCommand<object> registeredCommands;

        public static void Define(DeveloperConsoleCommand<object> cmd) {
            if (Developer.ShouldAudit) {
                
            }
            
            registeredCommands.Add(cmd);
        }

        public static void Define(string name, DeveloperConsoleCommandType type, object value, object valueFallback,
        string help = "") {
            registeredCommands.Add(new DeveloperConsoleCommand<object> {
                Name = name,
                Type = type,
                Value = value,
                ValueFallback = valueFallback,
                Help = help
            });
        }

        public static void Undefine(string name) {
            DeveloperConsoleCommand cmd = 
                registeredCommands.Select(x => 
                    x.Name == name
            ).FirstOrDefault();
            registeredCommands.Remove(cmd);
        }
    }
}
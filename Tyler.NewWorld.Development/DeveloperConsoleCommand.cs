// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

namespace Tyler.NewWorld.Development {
    public sealed class DeveloperConsoleCommand<T> {
        public string Name { get; set; } = "Unknown";
        public DeveloperConsoleCommandType Type { get; set; } = DeveloperConsoleCommandType.Unknown;
        public T Value { get; set; } = default;
        public T ValueFallback { get; set; } = default;
        public string Help { get; set; } = default;
    }
}
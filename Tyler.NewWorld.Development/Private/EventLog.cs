// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

namespace Tyler.NewWorld.Development.Private {
    using System;
    using System.Text;

    using System.Diagnostics;

    public sealed class EventLog {
        public void Information(string message) {
            // @Todo: Finish information implementation.
        }

        public void Warning(string message) {
            // @Todo: Finish warning implementation.
        }

        public void Error(string message) {
            // @Todo: Finish error implementation.
        }

        public void Exception(Exception ex) {
            // @Todo: Finish exception implementation.
        }

        public void Debug(string message) {
            // @Todo: Finish debug implementation.
        }
        
        private void Write(string source, string message) {
            // @Todo: Finish Windows event log implementation.
        }
    }
}
// Copyright (C) 2023 Tyler Technologies, Inc.  All rights reserved. 

namespace Tyler.NewWorld.Development{
    using System;
    
    public enum DeveloperConsoleCommandType : int {
        Unknown = 0x00000000,
        Byte = 0x00000001,
        Short = 0x00000010,
        ShortUnsigned = 0x00000011,
        Integer = 0x00000100,
        IntegerUnsigned = 0x00000101,
        Long = 0x00000110,
        LongUnsigned = 0x00000111,
        Float = 0x00001000,
        Double = 0x00001001,
        Decimal = 0x00001010,
        Character = 0x00001011,
        Boolean = 0x00001100,
        Object = 0x00001101,
        String = 0x00001110,
        DateTime = 0x00001111

    }
}
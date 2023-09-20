// generated from <Windows SDK Path>\um\wincodecsdk.h
using System;

namespace DirectN
{
    [Flags]
    public enum WICPersistOptions
    {
        WICPersistOptionDefault = 0x00000000,
        WICPersistOptionLittleEndian = 0x00000000,
        WICPersistOptionBigEndian = 0x00000001,
        WICPersistOptionStrictFormat = 0x00000002,
        WICPersistOptionNoCacheStream = 0x00000004,
        WICPersistOptionPreferUTF8 = 0x00000008,
        WICPersistOptionMask = 0x0000FFFF,
    }
}

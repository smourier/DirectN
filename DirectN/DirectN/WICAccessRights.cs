using System;

namespace DirectN
{
    [Flags]
    public enum WICAccessRights
    {
        GENERIC_READ = unchecked((int)0x80000000),
        GENERIC_WRITE = 0x40000000,
        GENERIC_EXECUTE = 0x20000000,
        GENERIC_ALL = 0x10000000,

        GENERIC_READ_WRITE = GENERIC_READ | GENERIC_WRITE
    }
}

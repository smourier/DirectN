// generated from <Windows SDK Path>\um\gameinput.h
using System;

namespace DirectN
{
    [Flags]
    public enum GameInputRawDeviceReportItemFlags
    {
        GameInputDefaultItem = 0x00000000,
        GameInputConstantItem = 0x00000001,
        GameInputArrayItem = 0x00000002,
        GameInputRelativeItem = 0x00000004,
        GameInputWraparoundItem = 0x00000008,
        GameInputNonlinearItem = 0x00000010,
        GameInputStableItem = 0x00000020,
        GameInputNullableItem = 0x00000040,
        GameInputVolatileItem = 0x00000080,
        GameInputBufferedItem = 0x00000100,
    }
}

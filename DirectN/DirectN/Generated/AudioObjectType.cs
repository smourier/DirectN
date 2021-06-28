// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudioclient.h(110,1)
using System;

namespace DirectN
{
    [Flags]
    public enum AudioObjectType
    {
        AudioObjectType_None = 0x00000000,
        AudioObjectType_Dynamic = 0x00000001,
        AudioObjectType_FrontLeft = 0x00000002,
        AudioObjectType_FrontRight = 0x00000004,
        AudioObjectType_FrontCenter = 0x00000008,
        AudioObjectType_LowFrequency = 0x00000010,
        AudioObjectType_SideLeft = 0x00000020,
        AudioObjectType_SideRight = 0x00000040,
        AudioObjectType_BackLeft = 0x00000080,
        AudioObjectType_BackRight = 0x00000100,
        AudioObjectType_TopFrontLeft = 0x00000200,
        AudioObjectType_TopFrontRight = 0x00000400,
        AudioObjectType_TopBackLeft = 0x00000800,
        AudioObjectType_TopBackRight = 0x00001000,
        AudioObjectType_BottomFrontLeft = 0x00002000,
        AudioObjectType_BottomFrontRight = 0x00004000,
        AudioObjectType_BottomBackLeft = 0x00008000,
        AudioObjectType_BottomBackRight = 0x00010000,
        AudioObjectType_BackCenter = 0x00020000,
    }
}

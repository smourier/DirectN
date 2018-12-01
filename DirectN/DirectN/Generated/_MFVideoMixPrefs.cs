// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(1081,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _MFVideoMixPrefs
    {
        MFVideoMixPrefs_ForceHalfInterlace = 0x00000001,
        MFVideoMixPrefs_AllowDropToHalfInterlace = 0x00000002,
        MFVideoMixPrefs_AllowDropToBob = 0x00000004,
        MFVideoMixPrefs_ForceBob = 0x00000008,
        MFVideoMixPrefs_EnableRotation = 0x00000010,
        MFVideoMixPrefs_Mask = 0x0000001F,
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(428,1)
using System;

namespace DirectN
{
    [Flags]
    public enum MFVideoRenderPrefs
    {
        MFVideoRenderPrefs_DoNotRenderBorder = 0x00000001,
        MFVideoRenderPrefs_DoNotClipToDevice = 0x00000002,
        MFVideoRenderPrefs_AllowOutputThrottling = 0x00000004,
        MFVideoRenderPrefs_ForceOutputThrottling = 0x00000008,
        MFVideoRenderPrefs_ForceBatching = 0x00000010,
        MFVideoRenderPrefs_AllowBatching = 0x00000020,
        MFVideoRenderPrefs_ForceScaling = 0x00000040,
        MFVideoRenderPrefs_AllowScaling = 0x00000080,
        MFVideoRenderPrefs_DoNotRepaintOnStop = 0x00000100,
        MFVideoRenderPrefs_Mask = 0x000001FF,
    }
}

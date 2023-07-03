// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(7493,9)
using System;

namespace DirectN
{
    [Flags]
    public enum KS
    {
        KS_VideoControlFlag_FlipHorizontal = 0x00000001,
        KS_VideoControlFlag_FlipVertical = 0x00000002,
        KS_Obsolete_VideoControlFlag_ExternalTriggerEnable = 0x00000010,
        KS_Obsolete_VideoControlFlag_Trigger = 0x00000020,
        KS_VideoControlFlag_ExternalTriggerEnable = 0x00000004,
        KS_VideoControlFlag_Trigger = 0x00000008,
        KS_VideoControlFlag_IndependentImagePin = 0x00000040,
        KS_VideoControlFlag_StillCapturePreviewFrame = 0x00000080,
        KS_VideoControlFlag_StartPhotoSequenceCapture = 0x00000100,
        KS_VideoControlFlag_StopPhotoSequenceCapture = 0x00000200,
    }
}

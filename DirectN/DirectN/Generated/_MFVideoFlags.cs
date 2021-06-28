// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(2738,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _MFVideoFlags
    {
        MFVideoFlag_PAD_TO_Mask = 0x00000003,
        MFVideoFlag_PAD_TO_None = 0x00000000,
        MFVideoFlag_PAD_TO_4x3 = 0x00000001,
        MFVideoFlag_PAD_TO_16x9 = 0x00000002,
        MFVideoFlag_SrcContentHintMask = 0x0000001C,
        MFVideoFlag_SrcContentHintNone = 0x00000000,
        MFVideoFlag_SrcContentHint16x9 = 0x00000004,
        MFVideoFlag_SrcContentHint235_1 = 0x00000008,
        MFVideoFlag_AnalogProtected = 0x00000020,
        MFVideoFlag_DigitallyProtected = 0x00000040,
        MFVideoFlag_ProgressiveContent = 0x00000080,
        MFVideoFlag_FieldRepeatCountMask = 0x00000700,
        MFVideoFlag_FieldRepeatCountShift = 0x00000008,
        MFVideoFlag_ProgressiveSeqReset = 0x00000800,
        MFVideoFlag_PanScanEnabled = 0x00020000,
        MFVideoFlag_LowerFieldFirst = 0x00040000,
        MFVideoFlag_BottomUpLinearRep = 0x00080000,
        MFVideoFlags_DXVASurface = 0x00100000,
        MFVideoFlags_RenderTargetSurface = 0x00400000,
        MFVideoFlags_ForceQWORD = 0x7FFFFFFF,
    }
}

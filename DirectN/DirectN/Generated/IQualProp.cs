// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\amvideo.h(92,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1bd0ecb0-f8e2-11ce-aac6-0020af0b99a3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IQualProp
    {
        [PreserveSig]
        HRESULT get_FramesDroppedInRenderer(/* THIS_ _Out_ */ out int pcFrames);
        
        [PreserveSig]
        HRESULT get_FramesDrawn(/* THIS_ _Out_ */ out int pcFramesDrawn);
        
        [PreserveSig]
        HRESULT get_AvgFrameRate(/* THIS_ _Out_ */ out int piAvgFrameRate);
        
        [PreserveSig]
        HRESULT get_Jitter(/* THIS_ _Out_ */ out int iJitter);
        
        [PreserveSig]
        HRESULT get_AvgSyncOffset(/* THIS_ _Out_ */ out int piAvg);
        
        [PreserveSig]
        HRESULT get_DevSyncOffset(/* THIS_ _Out_ */ out int piDev);
    }
}

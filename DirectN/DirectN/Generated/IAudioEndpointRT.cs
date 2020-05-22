// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(322,5)
using System;
using System.Runtime.InteropServices;
using HNSTIME = System.Int64;

namespace DirectN
{
    [Guid("dfd2005f-a6e5-4d39-a265-939ada9fbb4d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointRT
    {
        [PreserveSig]
        void GetCurrentPadding(/* [out] */ out HNSTIME pPadding, /* [out] */ out AE_CURRENT_POSITION pAeCurrentPosition);
        
        [PreserveSig]
        void ProcessingComplete();
        
        [PreserveSig]
        HRESULT SetPinInactive();
        
        [PreserveSig]
        HRESULT SetPinActive();
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(15126,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("f185fe76-e64e-11d2-b76e-00c04fb6bd3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMPushSource : IAMLatency
    {
        // IAMLatency
        [PreserveSig]
        new HRESULT GetLatency(/* [annotation][in] _Out_ */ ref REFERENCE_TIME prtLatency);
        
        // IAMPushSource
        [PreserveSig]
        HRESULT GetPushSourceFlags(/* [annotation][out] _Out_ */ out uint pFlags);
        
        [PreserveSig]
        HRESULT SetPushSourceFlags(/* [in] */ uint Flags);
        
        [PreserveSig]
        HRESULT SetStreamOffset(/* [in] */ long rtOffset);
        
        [PreserveSig]
        HRESULT GetStreamOffset(/* [annotation][out] _Out_ */ out REFERENCE_TIME prtOffset);
        
        [PreserveSig]
        HRESULT GetMaxStreamOffset(/* [annotation][out] _Out_ */ out REFERENCE_TIME prtMaxOffset);
        
        [PreserveSig]
        HRESULT SetMaxStreamOffset(/* [in] */ long rtMaxOffset);
    }
}

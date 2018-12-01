// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(18797,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aada05a8-5a4e-4729-af0b-cea27aed51e2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRSurfaceAllocatorNotify
    {
        [PreserveSig]
        HRESULT AdviseSurfaceAllocator(/* [in] */ ulong dwUserID, /* [in] */ IVMRSurfaceAllocator lpIVRMSurfaceAllocator);
        
        [PreserveSig]
        HRESULT SetDDrawDevice(/* [in] */ IntPtr lpDDrawDevice, /* [in] */ IntPtr hMonitor);
        
        [PreserveSig]
        HRESULT ChangeDDrawDevice(/* [in] */ IntPtr lpDDrawDevice, /* [in] */ IntPtr hMonitor);
        
        [PreserveSig]
        HRESULT RestoreDDrawSurfaces();
        
        [PreserveSig]
        HRESULT NotifyEvent(/* [in] */ int EventCode, /* [in] */ long Param1, /* [in] */ long Param2);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint clrBorder);
    }
}

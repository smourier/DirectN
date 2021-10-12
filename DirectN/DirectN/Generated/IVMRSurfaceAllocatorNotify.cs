// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(19800,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW7 = DirectN.IDirectDraw7;

namespace DirectN
{
    [ComImport, Guid("aada05a8-5a4e-4729-af0b-cea27aed51e2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRSurfaceAllocatorNotify
    {
        [PreserveSig]
        HRESULT AdviseSurfaceAllocator(/* [in] */ IntPtr dwUserID, /* [in] */ IVMRSurfaceAllocator lpIVRMSurfaceAllocator);
        
        [PreserveSig]
        HRESULT SetDDrawDevice(/* [in] */ LPDIRECTDRAW7 lpDDrawDevice, /* [in] */ IntPtr hMonitor);
        
        [PreserveSig]
        HRESULT ChangeDDrawDevice(/* [in] */ LPDIRECTDRAW7 lpDDrawDevice, /* [in] */ IntPtr hMonitor);
        
        [PreserveSig]
        HRESULT RestoreDDrawSurfaces();
        
        [PreserveSig]
        HRESULT NotifyEvent(/* [in] */ int EventCode, /* [in] */ IntPtr Param1, /* [in] */ IntPtr Param2);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint clrBorder);
    }
}

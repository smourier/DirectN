// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(19673,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [ComImport, Guid("31ce832e-4484-458b-8cca-f4d7e3db0b52"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRSurfaceAllocator
    {
        [PreserveSig]
        HRESULT AllocateSurface(/* [in] */ IntPtr dwUserID, /* [in] */ ref tagVMRALLOCATIONINFO lpAllocInfo, /* [out][in] */ ref uint lpdwActualBuffers, /* [out] */ out LPDIRECTDRAWSURFACE7 lplpSurface);
        
        [PreserveSig]
        HRESULT FreeSurface(/* [in] */ IntPtr dwID);
        
        [PreserveSig]
        HRESULT PrepareSurface(/* [in] */ IntPtr dwUserID, /* [in] */ LPDIRECTDRAWSURFACE7 lpSurface, /* [in] */ uint dwSurfaceFlags);
        
        [PreserveSig]
        HRESULT AdviseNotify(/* [in] */ IVMRSurfaceAllocatorNotify lpIVMRSurfAllocNotify);
    }
}

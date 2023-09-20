// generated from <Windows SDK Path>\um\strmif.h
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

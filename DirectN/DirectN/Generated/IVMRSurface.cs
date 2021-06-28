// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(20431,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [ComImport, Guid("a9849bbe-9ec8-4263-b764-62730f0d15d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRSurface
    {
        [PreserveSig]
        HRESULT IsSurfaceLocked();
        
        [PreserveSig]
        HRESULT LockSurface(/* [out] */ out IntPtr lpSurface);
        
        [PreserveSig]
        HRESULT UnlockSurface();
        
        [PreserveSig]
        HRESULT GetSurface(/* [out] */ out LPDIRECTDRAWSURFACE7 lplpSurface);
    }
}

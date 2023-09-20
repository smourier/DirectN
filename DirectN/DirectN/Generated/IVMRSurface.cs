// generated from <Windows SDK Path>\um\strmif.h
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

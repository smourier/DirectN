// generated from <Windows SDK Path>\um\wmpservices.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("afb6b76b-1e20-4198-83b3-191db6e0b149"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPServices
    {
        [PreserveSig]
        HRESULT GetStreamTime(/* [retval][out] */ out long prt);
        
        [PreserveSig]
        HRESULT GetStreamState(/* [retval][out] */ out WMPServices_StreamState pState);
    }
}

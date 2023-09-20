// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cf4b1f99-4de2-4e49-a363-252740d99bc1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMRegisterCallback
    {
        [PreserveSig]
        HRESULT Advise(/* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT Unadvise(/* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
    }
}

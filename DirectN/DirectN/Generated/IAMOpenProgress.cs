// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8e1c39a1-de53-11cf-aa63-0080c744528d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMOpenProgress
    {
        [PreserveSig]
        HRESULT QueryProgress(/* [annotation][out] _Out_ */ out long pllTotal, /* [annotation][out] _Out_ */ out long pllCurrent);
        
        [PreserveSig]
        HRESULT AbortOperation();
    }
}

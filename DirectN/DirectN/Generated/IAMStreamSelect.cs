// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using LCID = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("c1960960-17f5-11d1-abe1-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMStreamSelect
    {
        [PreserveSig]
        HRESULT Count(/* [annotation][out] _Out_ */ out uint pcStreams);
        
        [PreserveSig]
        HRESULT Info(/* [in] */ int lIndex, /* optional(_AMMediaType) */ IntPtr ppmt, /* optional(DWORD) */ IntPtr pdwFlags, /* optional(LCID) */ IntPtr plcid, /* optional(DWORD) */ IntPtr pdwGroup, /* optional(LPWSTR) */ out IntPtr ppszName, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
        
        [PreserveSig]
        HRESULT Enable(/* [in] */ int lIndex, /* [in] */ uint dwFlags);
    }
}

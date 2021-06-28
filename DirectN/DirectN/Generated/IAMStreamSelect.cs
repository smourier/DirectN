// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(14213,5)
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

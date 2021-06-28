// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(8622,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a0638c2b-6465-4395-9ae7-a321a9fd2856"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAudioPolicy
    {
        [PreserveSig]
        HRESULT SetGroupingParam(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidClass);
        
        [PreserveSig]
        HRESULT GetGroupingParam(/* [annotation][out] _Out_ */ out Guid pguidClass);
        
        [PreserveSig]
        HRESULT SetDisplayName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName);
        
        [PreserveSig]
        HRESULT GetDisplayName(/* [annotation][out] _Outptr_ */ out IntPtr pszName);
        
        [PreserveSig]
        HRESULT SetIconPath(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [PreserveSig]
        HRESULT GetIconPath(/* [annotation][out] _Outptr_ */ out IntPtr pszPath);
    }
}

// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("de9d91d2-70b4-4f41-836c-25fcd39626d3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDisplayAdaptationControl
    {
        [PreserveSig]
        HRESULT DoesSupportChangingMaxLuminance(/* optional(WICPixelFormatGUID) */ IntPtr pguidDstFormat, /* [out] __RPC__out */ out bool pfIsSupported);
        
        [PreserveSig]
        HRESULT SetDisplayMaxLuminance(/* [in] */ float fLuminanceInNits);
        
        [PreserveSig]
        HRESULT GetDisplayMaxLuminance(/* [retval][out] __RPC__out */ out float pfLuminanceInNits);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(24978,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fcc152b6-f372-11d0-8e00-00c04fd7c08b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdGraphBuilder
    {
        [PreserveSig]
        HRESULT GetFiltergraph(/* [annotation][out] _Out_ */ out IGraphBuilder ppGB);
        
        [PreserveSig]
        HRESULT GetDvdInterface(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ out IntPtr ppvIF);
        
        [PreserveSig]
        HRESULT RenderDvdVideoVolume(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string lpcwszPathName, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_strmif_0000_0138_0001 pStatus);
    }
}

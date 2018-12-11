// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\videoacc.h(118,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("256a6a21-fbad-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoAcceleratorNotify
    {
        [PreserveSig]
        HRESULT GetUncompSurfacesInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out][in] _Inout_ */ ref _tag_AMVAUncompBufferInfo pUncompBufferInfo);
        
        [PreserveSig]
        HRESULT SetUncompSurfacesInfo(/* [in] */ uint dwActualUncompSurfacesAllocated);
        
        [PreserveSig]
        HRESULT GetCreateVideoAcceleratorData(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out] _Out_ */ out uint pdwSizeMiscData, /* [annotation][out] _Outptr_result_bytebuffer_(*pdwSizeMiscData) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppMiscData);
    }
}

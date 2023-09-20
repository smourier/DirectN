// generated from <Windows SDK Path>\um\videoacc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("256a6a21-fbad-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoAcceleratorNotify
    {
        [PreserveSig]
        HRESULT GetUncompSurfacesInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out][in] _Inout_ */ ref _tag_AMVAUncompBufferInfo pUncompBufferInfo);
        
        [PreserveSig]
        HRESULT SetUncompSurfacesInfo(/* [in] */ uint dwActualUncompSurfacesAllocated);
        
        [PreserveSig]
        HRESULT GetCreateVideoAcceleratorData(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out] _Out_ */ out uint pdwSizeMiscData, /* [annotation][out] _Outptr_result_bytebuffer_(*pdwSizeMiscData) */ out IntPtr ppMiscData);
    }
}

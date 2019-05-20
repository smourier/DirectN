// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmpservices.h(577,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bfb377e5-c594-4369-a970-de896d5ece74"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPGraphCreation
    {
        [PreserveSig]
        HRESULT GraphCreationPreRender(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pFilterGraph, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pReserved);
        
        [PreserveSig]
        HRESULT GraphCreationPostRender(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pFilterGraph);
        
        [PreserveSig]
        HRESULT GetGraphCreationFlags(/* [out] */ out uint pdwFlags);
    }
}

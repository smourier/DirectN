// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(11420,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12SwapChainAssistant
    {
        [PreserveSig]
        _LUID GetLUID();
        
        [PreserveSig]
        HRESULT GetSwapChainObject([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetCurrentResourceAndCommandQueue([MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource, [MarshalAs(UnmanagedType.LPStruct)] Guid riidQueue, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvQueue);
        
        [PreserveSig]
        HRESULT InsertImplicitSync();
    }
}

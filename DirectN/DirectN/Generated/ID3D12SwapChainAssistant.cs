// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [ComImport, Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12SwapChainAssistant
    {
        [PreserveSig]
        void GetLUID(out _LUID size);
        
        [PreserveSig]
        HRESULT GetSwapChainObject([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetCurrentResourceAndCommandQueue([MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource, [MarshalAs(UnmanagedType.LPStruct)] Guid riidQueue, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvQueue);
        
        [PreserveSig]
        HRESULT InsertImplicitSync();
    }
}

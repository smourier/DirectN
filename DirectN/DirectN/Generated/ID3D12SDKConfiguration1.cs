// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8aaf9303-ad25-48b9-9a57-d9c37e009d9f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12SDKConfiguration1 : ID3D12SDKConfiguration
    {
        // ID3D12SDKConfiguration
        [PreserveSig]
        new HRESULT SetSDKVersion(uint SDKVersion, /* _In_z_ */ [MarshalAs(UnmanagedType.LPStr)] string SDKPath);
        
        // ID3D12SDKConfiguration1
        [PreserveSig]
        HRESULT CreateDeviceFactory(uint SDKVersion, /* _In_ */ [MarshalAs(UnmanagedType.LPStr)] string SDKPath, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvFactory);
        
        [PreserveSig]
        void FreeUnusedSDKs();
    }
}

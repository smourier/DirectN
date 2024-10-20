// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("61f307d3-d34e-4e7c-8374-3ba4de23cccb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DeviceFactory
    {
        [PreserveSig]
        HRESULT InitializeFromGlobalState();
        
        [PreserveSig]
        HRESULT ApplyToGlobalState();
        
        [PreserveSig]
        HRESULT SetFlags(D3D12_DEVICE_FACTORY_FLAGS flags);
        
        [PreserveSig]
        D3D12_DEVICE_FACTORY_FLAGS GetFlags();
        
        [PreserveSig]
        HRESULT GetConfigurationInterface([MarshalAs(UnmanagedType.LPStruct)] Guid clsid, [MarshalAs(UnmanagedType.LPStruct)] Guid iid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT EnableExperimentalFeatures(int NumFeatures, /* _In_reads_(NumFeatures) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] pIIDs, /* optional(void) */ IntPtr pConfigurationStructs, /* _In_reads_opt_(NumFeatures) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pConfigurationStructSizes);
        
        [PreserveSig]
        HRESULT CreateDevice(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object adapter, D3D_FEATURE_LEVEL FeatureLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
    }
}

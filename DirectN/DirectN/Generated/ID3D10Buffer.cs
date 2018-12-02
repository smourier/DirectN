// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(1691,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b7e4c02-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Buffer : ID3D10Resource
    {
        // ID3D10DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Out_ */ out ID3D10Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D10Resource
        [PreserveSig]
        new void GetType(/* [annotation] _Out_ */ out D3D10_RESOURCE_DIMENSION rType);
        
        [PreserveSig]
        new void SetEvictionPriority(/* [annotation] _In_ */ uint EvictionPriority);
        
        [PreserveSig]
        new uint GetEvictionPriority();
        
        // ID3D10Buffer
        [PreserveSig]
        HRESULT Map(/* [annotation] _In_ */ D3D10_MAP MapType, /* [annotation] _In_ */ uint MapFlags, /* [annotation] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppData);
        
        [PreserveSig]
        void Unmap();
        
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D10_BUFFER_DESC pDesc);
    }
}

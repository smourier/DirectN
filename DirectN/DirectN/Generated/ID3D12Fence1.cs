// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(4711,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("433685fe-e22b-4ca0-a8db-b5b4f4dd0e4a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Fence1 : ID3D12Fence
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12Pageable
        
        // ID3D12Fence
        [PreserveSig]
        new ulong GetCompletedValue();
        
        [PreserveSig]
        new HRESULT SetEventOnCompletion(ulong Value, IntPtr hEvent);
        
        [PreserveSig]
        new HRESULT Signal(ulong Value);
        
        // ID3D12Fence1
        [PreserveSig]
        D3D12_FENCE_FLAGS GetCreationFlags();
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(14226,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dbb84c27-36ce-4fc9-b801-f048c46ac570"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12MetaCommand : ID3D12Pageable
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
        
        // ID3D12MetaCommand
        [PreserveSig]
        ulong GetRequiredParameterResourceSize(/* _In_ */ D3D12_META_COMMAND_PARAMETER_STAGE Stage, /* _In_ */ uint ParameterIndex);
    }
}

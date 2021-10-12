// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7224,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ClassLinkage : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11ClassLinkage
        [PreserveSig]
        HRESULT GetClassInstance(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pClassInstanceName, /* [annotation] _In_ */ uint InstanceIndex, /* [annotation] _COM_Outptr_ */ out ID3D11ClassInstance ppInstance);
        
        [PreserveSig]
        HRESULT CreateClassInstance(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string pClassTypeName, /* [annotation] _In_ */ uint ConstantBufferOffset, /* [annotation] _In_ */ uint ConstantVectorOffset, /* [annotation] _In_ */ uint TextureOffset, /* [annotation] _In_ */ uint SamplerOffset, /* [annotation] _COM_Outptr_ */ out ID3D11ClassInstance ppInstance);
    }
}

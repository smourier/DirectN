// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(6813,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a6cd7faa-b0b7-4a2f-9436-8662a65797cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ClassInstance : ID3D11DeviceChild
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
        
        // ID3D11ClassInstance
        [PreserveSig]
        void GetClassLinkage(/* [annotation] _Outptr_ */ out ID3D11ClassLinkage ppLinkage);
        
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_CLASS_INSTANCE_DESC pDesc);
        
        [PreserveSig]
        void GetInstanceName(/* [annotation] _Out_writes_opt_(*pBufferLength) */ [MarshalAs(UnmanagedType.LPStr)] string pInstanceName, /* [annotation] _Inout_ */ IntPtr pBufferLength);
        
        [PreserveSig]
        void GetTypeName(/* [annotation] _Out_writes_opt_(*pBufferLength) */ [MarshalAs(UnmanagedType.LPStr)] string pTypeName, /* [annotation] _Inout_ */ IntPtr pBufferLength);
    }
}

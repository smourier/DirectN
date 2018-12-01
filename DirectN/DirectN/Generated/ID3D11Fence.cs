// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(3945,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("affde9d1-1df7-4bb7-8a34-0f46251dab80"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Fence : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11Fence
        [PreserveSig]
        HRESULT CreateSharedHandle(/* [annotation] _In_opt_ */ ref _SECURITY_ATTRIBUTES pAttributes, /* [annotation] _In_ */ uint dwAccess, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName, /* [annotation] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pHandle);
        
        [PreserveSig]
        ulong GetCompletedValue();
        
        [PreserveSig]
        HRESULT SetEventOnCompletion(/* [annotation] _In_ */ ulong Value, /* [annotation] _In_ */ IntPtr hEvent);
    }
}

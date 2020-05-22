// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(14611,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d6f12dd6-76fb-406e-8961-4296eefc0409"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ProtectedResourceSession1 : ID3D12ProtectedResourceSession
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
        
        // ID3D12ProtectedSession
        [PreserveSig]
        new HRESULT GetStatusFence([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        new D3D12_PROTECTED_SESSION_STATUS GetSessionStatus();
        
        // ID3D12ProtectedResourceSession
        [PreserveSig]
        new void GetDesc(out D3D12_PROTECTED_RESOURCE_SESSION_DESC size);
        
        // ID3D12ProtectedResourceSession1
        [PreserveSig]
        D3D12_PROTECTED_RESOURCE_SESSION_DESC1 GetDesc1();
    }
}

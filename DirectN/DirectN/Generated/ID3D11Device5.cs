// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_4.h(950,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8ffde202-a0e7-45df-9e01-e837801b5ea0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device5 : ID3D11Device4
    {
        // ID3D11Device4
        [PreserveSig]
        new HRESULT RegisterDeviceRemovedEvent(/* [annotation] _In_ */ IntPtr hEvent, /* [annotation] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        new void UnregisterDeviceRemoved(/* [annotation] _In_ */ uint dwCookie);
        
        // ID3D11Device5
        [PreserveSig]
        HRESULT OpenSharedFence(/* [annotation] _In_ */ IntPtr hFence, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, /* [annotation] _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        HRESULT CreateFence(/* [annotation] _In_ */ ulong InitialValue, /* [annotation] _In_ */ D3D11_FENCE_FLAG Flags, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, /* [annotation] _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
    }
}

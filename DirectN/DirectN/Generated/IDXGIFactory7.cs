// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(1117,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a4966eed-76db-44da-84c1-ee9a7afb20a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory7 : IDXGIFactory6
    {
        // IDXGIFactory6
        [PreserveSig]
        new HRESULT EnumAdapterByGpuPreference(/* [annotation] _In_ */ uint Adapter, /* [annotation] _In_ */ DXGI_GPU_PREFERENCE GpuPreference, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
        
        // IDXGIFactory7
        [PreserveSig]
        HRESULT RegisterAdaptersChangedEvent(/* [annotation][in] _In_ */ IntPtr hEvent, /* [annotation][out] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        HRESULT UnregisterAdaptersChangedEvent(/* [annotation][in] _In_ */ uint dwCookie);
    }
}

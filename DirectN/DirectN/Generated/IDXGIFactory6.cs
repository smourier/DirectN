// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(750,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c1b6694f-ff09-44a9-b03c-77900a0a1d17"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory6
    {
        [PreserveSig]
        HRESULT EnumAdapterByGpuPreference(/* [annotation] _In_ */ uint Adapter, /* [annotation] _In_ */ DXGI_GPU_PREFERENCE GpuPreference, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
    }
}

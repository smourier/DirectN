// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_4.h(857,5)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [Guid("1bc6ea02-ef36-464f-bf0c-21ca39e5168a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIFactory4
    {
        [PreserveSig]
        HRESULT EnumAdapterByLuid(/* [annotation] _In_ */ LUID AdapterLuid, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
        
        [PreserveSig]
        HRESULT EnumWarpAdapter(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
    }
}

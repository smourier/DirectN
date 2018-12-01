// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1733,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7bfef914-2d75-4bad-be87-e18ddb077b6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device6 : ID2D1Device5
    {
        // ID2D1Device2
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext2 deviceContext2);
        
        [PreserveSig]
        new void FlushDeviceContexts(/* _In_ */ ref ID2D1Bitmap bitmap);
        
        [PreserveSig]
        new HRESULT GetDxgiDevice(/* _COM_Outptr_ */ out IDXGIDevice dxgiDevice);
        
        // ID2D1Device3
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext3 deviceContext3);
        
        // ID2D1Device4
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext4 deviceContext4);
        
        [PreserveSig]
        new void SetMaximumColorGlyphCacheMemory(ulong maximumInBytes);
        
        [PreserveSig]
        new ulong GetMaximumColorGlyphCacheMemory();
        
        // ID2D1Device5
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext5 deviceContext5);
        
        // ID2D1Device6
        [PreserveSig]
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext6 deviceContext6);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1479,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d7bdb159-5683-4a46-bc9c-72dc720b858b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device4 : ID2D1Device3
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
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext4 deviceContext4);
        
        [PreserveSig]
        void SetMaximumColorGlyphCacheMemory(ulong maximumInBytes);
        
        [PreserveSig]
        ulong GetMaximumColorGlyphCacheMemory();
    }
}

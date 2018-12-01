// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1187,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("852f2087-802c-4037-ab60-ff2e7ee6fc01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device3 : ID2D1Device2
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
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext3 deviceContext3);
    }
}

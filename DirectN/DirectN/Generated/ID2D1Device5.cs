// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d2d1_3.h(1651,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d55ba0a4-6405-4694-aef5-08ee1a4358b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device5 : ID2D1Device4
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Device
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext deviceContext);
        
        [PreserveSig]
        new HRESULT CreatePrintControl(/* _In_ */ IWICImagingFactory wicFactory, /* _In_ */ IPrintDocumentPackageTarget documentTarget, /* optional(D2D1_PRINT_CONTROL_PROPERTIES) */ IntPtr printControlProperties, /* _COM_Outptr_ */ out ID2D1PrintControl printControl);
        
        [PreserveSig]
        new void SetMaximumTextureMemory(ulong maximumInBytes);
        
        [PreserveSig]
        new ulong GetMaximumTextureMemory();
        
        [PreserveSig]
        new void ClearResources(uint millisecondsSinceUse);
        
        // ID2D1Device1
        [PreserveSig]
        new D2D1_RENDERING_PRIORITY GetRenderingPriority();
        
        [PreserveSig]
        new void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority);
        
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext1 deviceContext1);
        
        // ID2D1Device2
        [PreserveSig]
        new HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext2 deviceContext2);
        
        [PreserveSig]
        new void FlushDeviceContexts(/* _In_ */ ID2D1Bitmap bitmap);
        
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
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext5 deviceContext5);
    }
}

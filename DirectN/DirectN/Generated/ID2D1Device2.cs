// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(962,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a resource domain whose objects and device contexts can be used together. This interface performs all the same functions as the existing ID2D1Device1 interface. It also enables the creation of ID2D1DeviceContext2 objects.
    /// </summary>
    [ComImport, Guid("a44472e1-8dfb-4e60-8492-6e2861c9ca8b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device2 : ID2D1Device1
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
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext2 deviceContext2);
        
        [PreserveSig]
        void FlushDeviceContexts(/* _In_ */ ID2D1Bitmap bitmap);
        
        [PreserveSig]
        HRESULT GetDxgiDevice(/* _COM_Outptr_ */ out IDXGIDevice dxgiDevice);
    }
}

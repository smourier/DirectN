// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(2164,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The device defines a resource domain whose objects and device contexts can be used together.
    /// </summary>
    [ComImport, Guid("47dd575d-ac05-4cdd-8049-9b02cd16f44c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Device : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Device
        [PreserveSig]
        HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, /* _COM_Outptr_ */ out ID2D1DeviceContext deviceContext);
        
        [PreserveSig]
        HRESULT CreatePrintControl(/* _In_ */ IWICImagingFactory wicFactory, /* _In_ */ IPrintDocumentPackageTarget documentTarget, /* optional(D2D1_PRINT_CONTROL_PROPERTIES) */ IntPtr printControlProperties, /* _COM_Outptr_ */ out ID2D1PrintControl printControl);
        
        [PreserveSig]
        void SetMaximumTextureMemory(ulong maximumInBytes);
        
        [PreserveSig]
        ulong GetMaximumTextureMemory();
        
        [PreserveSig]
        void ClearResources(uint millisecondsSinceUse);
    }
}

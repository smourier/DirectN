// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfsharingengine.h(817,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cfa0ae8e-7e1c-44d2-ae68-fc4c148a6354"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFImageSharingEngine
    {
        [PreserveSig]
        HRESULT SetSource(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pStream);
        
        [PreserveSig]
        HRESULT GetDevice(/* [annotation][out] _Out_ */ out DEVICE_INFO pDevice);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}

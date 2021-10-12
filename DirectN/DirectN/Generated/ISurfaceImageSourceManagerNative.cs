// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\windows.ui.xaml.media.dxinterop.h(630,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4c8798b7-1d88-4a0f-b59b-b93f600de8c8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISurfaceImageSourceManagerNative
    {
        [PreserveSig]
        HRESULT FlushAllSurfacesWithDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object device);
    }
}

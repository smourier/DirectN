// generated from <Windows SDK Path>\um\windows.ui.xaml.media.dxinterop.h
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

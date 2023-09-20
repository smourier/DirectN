// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("604d33d7-cf23-41d5-8224-5bbbb1a87475"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoRendererEffectControl
    {
        [PreserveSig]
        HRESULT OnAppServiceConnectionEstablished(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAppServiceConnection);
    }
}

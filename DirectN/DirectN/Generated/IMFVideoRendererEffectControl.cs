// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(4071,5)
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

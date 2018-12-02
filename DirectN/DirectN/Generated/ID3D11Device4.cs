// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_4.h(129,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8992ab71-02e6-4b8d-ba48-b056dcda42c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device4
    {
        [PreserveSig]
        HRESULT RegisterDeviceRemovedEvent(/* [annotation] _In_ */ IntPtr hEvent, /* [annotation] _Out_ */ out uint pdwCookie);
        
        [PreserveSig]
        void UnregisterDeviceRemoved(/* [annotation] _In_ */ uint dwCookie);
    }
}

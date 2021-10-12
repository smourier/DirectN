// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\windows.ui.xaml.media.dxinterop.h(262,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dbf2e947-8e6c-4254-9eee-7738f71386c9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVirtualSurfaceUpdatesCallbackNative
    {
        [PreserveSig]
        HRESULT UpdatesNeeded();
    }
}

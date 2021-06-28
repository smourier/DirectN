// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(4648,5)
using System;
using System.Runtime.InteropServices;
using PFNProgressNotification = System.IntPtr;

namespace DirectN
{
    [ComImport, Guid("64c1024e-c3cf-4462-8078-88c2b11c46d9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapCodecProgressNotification
    {
        [PreserveSig]
        HRESULT RegisterProgressNotification(/* optional(PFNProgressNotification) */ IntPtr pfnProgressNotification, /* optional(LPVOID) */ IntPtr pvData, /* [in] */ uint dwProgressFlags);
    }
}

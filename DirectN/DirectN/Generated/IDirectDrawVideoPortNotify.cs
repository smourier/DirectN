// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(218,1)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTNOTIFY = DirectN._DDVIDEOPORTNOTIFY;

namespace DirectN
{
    [ComImport, Guid("a655fb94-0589-4e57-b333-567a89468c88"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawVideoPortNotify
    {
        [PreserveSig]
        HRESULT AcquireNotification(IntPtr unnamed__0, ref LPDDVIDEOPORTNOTIFY unnamed__1);
        
        [PreserveSig]
        HRESULT ReleaseNotification(IntPtr unnamed__0);
    }
}

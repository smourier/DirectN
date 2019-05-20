// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dvp.h(218,1)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTNOTIFY = DirectN._DDVIDEOPORTNOTIFY;

namespace DirectN
{
    [Guid("a655fb94-0589-4e57-b333-567a89468c88"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawVideoPortNotify
    {
        [PreserveSig]
        HRESULT AcquireNotification(IntPtr __unnamed_0, ref LPDDVIDEOPORTNOTIFY __unnamed_1);
        
        [PreserveSig]
        HRESULT ReleaseNotification(IntPtr __unnamed_0);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(1679,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9f8496be-5b9a-41b9-a9e8-f21cd80596c2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMVideoForceKeyFrame
    {
        [PreserveSig]
        HRESULT SetKeyFrame();
    }
}

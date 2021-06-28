// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(3899,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a3d8cec0-7e5a-11cf-bbc5-00805f6cef20"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMovieSetup
    {
        [PreserveSig]
        HRESULT Register();
        
        [PreserveSig]
        HRESULT Unregister();
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(18927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c56e9858-dbf3-4f6b-8119-384af2060deb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPinFlowControl
    {
        [PreserveSig]
        HRESULT Block(/* [in] */ uint dwBlockFlags, /* [in] */ IntPtr hEvent);
    }
}

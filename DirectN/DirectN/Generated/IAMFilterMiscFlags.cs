// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(15326,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2dd74950-a890-11d1-abe8-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMFilterMiscFlags
    {
        [PreserveSig]
        uint GetMiscFlags();
    }
}

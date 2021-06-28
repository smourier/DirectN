// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(14361,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8389d2d0-77d7-11d1-abe6-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMResourceControl
    {
        [PreserveSig]
        HRESULT Reserve(/* [in] */ uint dwFlags, /* [annotation][in] _Reserved_ */ IntPtr pvReserved);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(15228,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4d5466b0-a49c-11d1-abe8-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMClockAdjust
    {
        [PreserveSig]
        HRESULT SetClockDelta(/* [in] */ long rtDelta);
    }
}

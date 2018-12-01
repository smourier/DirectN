// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(14445,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4d5466b0-a49c-11d1-abe8-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMClockAdjust
    {
        [PreserveSig]
        HRESULT SetClockDelta(/* [in] */ long rtDelta);
    }
}

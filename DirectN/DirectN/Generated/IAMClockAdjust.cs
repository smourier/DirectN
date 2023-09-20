// generated from <Windows SDK Path>\um\strmif.h
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

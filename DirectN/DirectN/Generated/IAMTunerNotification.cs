// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("211a8760-03ac-11d1-8d13-00aa00bd8339"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTunerNotification
    {
        [PreserveSig]
        HRESULT OnEvent(/* [in] */ tagAMTunerEventType Event);
    }
}

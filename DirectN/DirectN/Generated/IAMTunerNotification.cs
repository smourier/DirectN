// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(11319,5)
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

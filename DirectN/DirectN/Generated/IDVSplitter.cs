// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(16574,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("92a3a302-da7c-4a1f-ba7e-1802bb5d2d02"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDVSplitter
    {
        [PreserveSig]
        HRESULT DiscardAlternateVideoFrames(/* [in] */ int nDiscard);
    }
}

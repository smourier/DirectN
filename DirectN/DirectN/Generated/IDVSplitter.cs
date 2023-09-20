// generated from <Windows SDK Path>\um\strmif.h
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

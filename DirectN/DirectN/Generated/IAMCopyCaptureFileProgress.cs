// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("670d1d20-a068-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMCopyCaptureFileProgress
    {
        [PreserveSig]
        HRESULT Progress(/* [in] */ int iProgress);
    }
}

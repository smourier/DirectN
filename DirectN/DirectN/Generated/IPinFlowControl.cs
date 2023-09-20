// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c56e9858-dbf3-4f6b-8119-384af2060deb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPinFlowControl
    {
        [PreserveSig]
        HRESULT Block(/* [in] */ uint dwBlockFlags, /* [in] */ IntPtr hEvent);
    }
}

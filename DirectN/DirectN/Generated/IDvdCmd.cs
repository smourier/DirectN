// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5a4a97e4-94ee-4a55-9751-74b5643aa27d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdCmd
    {
        [PreserveSig]
        HRESULT WaitForStart();
        
        [PreserveSig]
        HRESULT WaitForEnd();
    }
}

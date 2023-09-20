// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a3d8cec0-7e5a-11cf-bbc5-00805f6cef20"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMovieSetup
    {
        [PreserveSig]
        HRESULT Register();
        
        [PreserveSig]
        HRESULT Unregister();
    }
}

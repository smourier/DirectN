// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ade0fd60-d19d-11d2-abf6-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGraphConfigCallback
    {
        [PreserveSig]
        HRESULT Reconfigure(IntPtr pvContext, uint dwFlags);
    }
}

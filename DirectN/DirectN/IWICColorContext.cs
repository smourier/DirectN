using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3C613A02-34B2-44ea-9A7C-45AEA9C6FD6D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICColorContext
    {
        [PreserveSig]
        HRESULT InitializeFromFilename([MarshalAs(UnmanagedType.LPWStr)] string wzFilename);

        [PreserveSig]
        HRESULT InitializeFromMemory(IntPtr pbBuffer, int cbBufferSize);

        [PreserveSig]
        HRESULT InitializeFromExifColorSpace(int value);

        [PreserveSig]
        HRESULT GetType(out WICColorContextType pType);

        [PreserveSig]
        HRESULT GetProfileBytes(int cbBuffer, IntPtr pbBuffer, out int pcbActual);

        [PreserveSig]
        HRESULT GetExifColorSpace(out int pValue);
    }
}

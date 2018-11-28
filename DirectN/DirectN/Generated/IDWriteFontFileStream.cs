using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontFileStream
    {
        [PreserveSig]
        HRESULT ReadFileFragment(out int fragmentStart, long fileOffset, long fragmentSize, out IntPtr fragmentContext);

        [PreserveSig]
        void ReleaseFileFragment(IntPtr fragmentContext);

        [PreserveSig]
        HRESULT GetFileSize(out long fileSize);

        [PreserveSig]
        HRESULT GetLastWriteTime(out long lastWriteTime);
    }
}

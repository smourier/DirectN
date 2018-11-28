using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000123-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapLock
    {
        [PreserveSig]
        HRESULT GetSize(out int puiWidth, out int puiHeight);

        [PreserveSig]
        HRESULT GetStride(out int pcbStride);

        [PreserveSig]
        HRESULT GetDataPointer(out uint pcbBufferSize, out IntPtr ppbData);

        [PreserveSig]
        HRESULT GetPixelFormat(out Guid pPixelFormat);
    }
}

using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3d4c0c61-18a4-41e4-bd80-481a4fc9f464"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICDdsFrameDecode
    {
        [PreserveSig]
        HRESULT GetSizeInBlocks(out int pWidthInBlocks, out int pHeightInBlocks);

        [PreserveSig]
        HRESULT GetFormatInfo(ref WICDdsFormatInfo pFormatInfo);

        [PreserveSig]
        HRESULT CopyBlocks(WICRect prcBoundsInBlocks, int cbStride, int cbBufferSize, IntPtr pbBuffer);
    }
}

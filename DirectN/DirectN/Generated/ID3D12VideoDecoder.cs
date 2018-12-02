// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(577,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c59b6bdc-7720-4074-a136-17a156037470"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDecoder
    {
        [PreserveSig]
        D3D12_VIDEO_DECODER_DESC GetDesc();
    }
}

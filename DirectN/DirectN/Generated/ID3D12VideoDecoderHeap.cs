// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(321,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0946b7c9-ebf6-4047-bb73-8683e27dbb1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDecoderHeap
    {
        [PreserveSig]
        D3D12_VIDEO_DECODER_HEAP_DESC GetDesc();
    }
}

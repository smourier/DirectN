// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(954,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("304fdb32-bede-410a-8545-943ac6a46138"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoProcessor
    {
        [PreserveSig]
        uint GetNodeMask();
        
        [PreserveSig]
        uint GetNumInputStreamDescs();
        
        [PreserveSig]
        HRESULT GetInputStreamDescs(uint NumInputStreamDescs, /* _Out_writes_(NumInputStreamDescs) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs);
        
        [PreserveSig]
        D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC GetOutputStreamDesc();
    }
}

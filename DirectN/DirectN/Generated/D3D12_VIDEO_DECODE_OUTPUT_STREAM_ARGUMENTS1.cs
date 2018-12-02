// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1874,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS1
    {
        public IntPtr pOutputTexture2D;
        public uint OutputSubresource;
        public D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1 ConversionArguments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM[][] Histograms;
    }
}

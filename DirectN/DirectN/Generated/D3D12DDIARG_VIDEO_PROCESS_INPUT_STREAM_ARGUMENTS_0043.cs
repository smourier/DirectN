// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11381,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS_0043
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_0020[] InputStream;
        public D3D12DDI_VIDEO_PROCESS_TRANSFORM_0032 Transform;
        public D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_FLAGS_0020 Flags;
        public D3D12DDI_VIDEO_PROCESS_INPUT_STREAM_RATE_INFO_0032 RateInfo;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public int[] FilterLevels;
        public D3D12DDI_VIDEO_PROCESS_ALPHA_BLENDING_0020 AlphaBlending;
        public D3D12DDI_VIDEO_FIELD_TYPE_0020 FieldType;
    }
}

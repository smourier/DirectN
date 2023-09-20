// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_4DDIARG_VIDEODECODERBEGINFRAME_RS4_0
    {
        public D3D11_1DDI_HVIDEODECODEROUTPUTVIEW hOutputView;
        public IntPtr pContentKey;
        public uint ContentKeySize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public D3DWDDM2_4DDI_VIDEO_DECODER_HISTOGRAM_RS4_0[] Histograms;
    }
}

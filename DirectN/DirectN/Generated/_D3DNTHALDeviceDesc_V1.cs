// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(56,9)
using System;
using System.Runtime.InteropServices;
using D3DLIGHTINGCAPS = DirectN._D3DLIGHTINGCAPS;
using D3DPRIMCAPS = DirectN._D3DPrimCaps;
using D3DTRANSFORMCAPS = DirectN._D3DTRANSFORMCAPS;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHALDeviceDesc_V1
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dcmColorModel;
        public uint dwDevCaps;
        public D3DTRANSFORMCAPS dtcTransformCaps;
        public bool bClipping;
        public D3DLIGHTINGCAPS dlcLightingCaps;
        public D3DPRIMCAPS dpcLineCaps;
        public D3DPRIMCAPS dpcTriCaps;
        public uint dwDeviceRenderBitDepth;
        public uint dwDeviceZBufferBitDepth;
        public uint dwMaxBufferSize;
        public uint dwMaxVertexCount;
    }
}

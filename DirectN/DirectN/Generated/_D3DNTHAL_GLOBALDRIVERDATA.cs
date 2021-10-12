// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dnthal.h(167,9)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_GLOBALDRIVERDATA
    {
        public uint dwSize;
        public _D3DNTHALDeviceDesc_V1 hwCaps;
        public uint dwNumVertices;
        public uint dwNumClipVertices;
        public uint dwNumTextureFormats;
        public IntPtr lpTextureFormats;
    }
}

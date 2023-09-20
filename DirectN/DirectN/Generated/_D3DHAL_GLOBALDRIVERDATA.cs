// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_GLOBALDRIVERDATA
    {
        public uint dwSize;
        public _D3DDeviceDesc_V1 hwCaps;
        public uint dwNumVertices;
        public uint dwNumClipVertices;
        public uint dwNumTextureFormats;
        public IntPtr lpTextureFormats;
    }
}

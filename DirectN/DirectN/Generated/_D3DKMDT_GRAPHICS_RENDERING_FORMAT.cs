// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_GRAPHICS_RENDERING_FORMAT
    {
        public _D3DKMDT_2DREGION PrimSurfSize;
        public _D3DKMDT_2DREGION VisibleRegionSize;
        public uint Stride;
        public _D3DDDIFORMAT PixelFormat;
        public _D3DKMDT_COLOR_BASIS ColorBasis;
        public _D3DKMDT_PIXEL_VALUE_ACCESS_MODE PixelValueAccessMode;
    }
}

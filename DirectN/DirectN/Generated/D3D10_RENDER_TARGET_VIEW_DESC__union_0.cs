// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(3014,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_RENDER_TARGET_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] __bits;
        public D3D10_BUFFER_RTV Buffer => InteropRuntime.GetBits<D3D10_BUFFER_RTV>(__bits, 0, 64);
        public D3D10_TEX1D_RTV Texture1D => InteropRuntime.GetBits<D3D10_TEX1D_RTV>(__bits, 0, 32);
        public D3D10_TEX1D_ARRAY_RTV Texture1DArray => InteropRuntime.GetBits<D3D10_TEX1D_ARRAY_RTV>(__bits, 0, 96);
        public D3D10_TEX2D_RTV Texture2D => InteropRuntime.GetBits<D3D10_TEX2D_RTV>(__bits, 0, 32);
        public D3D10_TEX2D_ARRAY_RTV Texture2DArray => InteropRuntime.GetBits<D3D10_TEX2D_ARRAY_RTV>(__bits, 0, 96);
        public D3D10_TEX2DMS_RTV Texture2DMS => InteropRuntime.GetBits<D3D10_TEX2DMS_RTV>(__bits, 0, 32);
        public D3D10_TEX2DMS_ARRAY_RTV Texture2DMSArray => InteropRuntime.GetBits<D3D10_TEX2DMS_ARRAY_RTV>(__bits, 0, 64);
        public D3D10_TEX3D_RTV Texture3D => InteropRuntime.GetBits<D3D10_TEX3D_RTV>(__bits, 0, 96);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7641,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS1
    {
        public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
        public bool MinMaxFiltering;
        public bool ClearViewAlsoSupportsDepthOnlyFormats;
        public bool MapOnDefaultBuffers;
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7721,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_DISPLAYABLE
    {
        public bool DisplayableTexture;
        public D3D11_SHARED_RESOURCE_TIER SharedResourceTier;
    }
}

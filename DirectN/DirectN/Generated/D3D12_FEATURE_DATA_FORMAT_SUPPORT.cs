// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2187,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_FORMAT_SUPPORT
    {
        public DXGI_FORMAT Format;
        public D3D12_FORMAT_SUPPORT1 Support1;
        public D3D12_FORMAT_SUPPORT2 Support2;
    }
}

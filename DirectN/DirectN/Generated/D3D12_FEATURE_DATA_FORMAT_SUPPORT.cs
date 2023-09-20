// generated from <Windows SDK Path>\um\d3d12.h
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

// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(3480,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC
    {
        public DXGI_FORMAT Format;
        public D3D_SRV_DIMENSION ViewDimension;
        public D3D11_SHADER_RESOURCE_VIEW_DESC__union_0 __union_2;
    }
}

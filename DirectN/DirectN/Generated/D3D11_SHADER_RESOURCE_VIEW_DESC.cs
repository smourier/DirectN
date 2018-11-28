using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_SHADER_RESOURCE_VIEW_DESC
    {
        [FieldOffset(0)]
        public DXGI_FORMAT Format;
        [FieldOffset(4)]
        public D3D11_SRV_DIMENSION ViewDimension;
        [FieldOffset(8)]
        public D3D11_BUFFER_SRV Buffer;
        [FieldOffset(8)]
        public D3D11_TEX1D_SRV Texture1D;
        [FieldOffset(8)]
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray;
        [FieldOffset(8)]
        public D3D11_TEX2D_SRV Texture2D;
        [FieldOffset(8)]
        public D3D11_TEX2D_ARRAY_SRV Texture2DArray;
        [FieldOffset(8)]
        public D3D11_TEX2DMS_SRV Texture2DMS;
        [FieldOffset(8)]
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        [FieldOffset(8)]
        public D3D11_TEX3D_SRV Texture3D;
        [FieldOffset(8)]
        public D3D11_TEXCUBE_SRV TextureCube;
        [FieldOffset(8)]
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
        [FieldOffset(8)]
        public D3D11_BUFFEREX_SRV BufferEx;
    }
}

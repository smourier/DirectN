// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(542,13)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_HDR_METADATA_HDR10 HDRMetaDataHDR10 { get => InteropRuntime.Get<_D3DDDI_HDR_METADATA_HDR10>(__bits, 0, 224); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DDDI_HDR_METADATA_HDR10>(value, __bits, 0, 224); } }
        public D3DDDI_HDR_METADATA_HDR10PLUS HDRMetaDataHDR10Plus { get => InteropRuntime.Get<D3DDDI_HDR_METADATA_HDR10PLUS>(__bits, 0, 576); set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3DDDI_HDR_METADATA_HDR10PLUS>(value, __bits, 0, 576); } }
    }
}

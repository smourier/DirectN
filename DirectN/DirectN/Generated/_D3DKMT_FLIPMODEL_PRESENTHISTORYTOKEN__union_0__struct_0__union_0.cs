// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_HDR_METADATA_HDR10 HDRMetaDataHDR10 {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<_D3DDDI_HDR_METADATA_HDR10>(__bits, 0, 224);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<_D3DDDI_HDR_METADATA_HDR10>(value, __bits, 0, 224); } }
        public D3DDDI_HDR_METADATA_HDR10PLUS HDRMetaDataHDR10Plus {  [MethodImpl(MethodImplOptions.AggressiveInlining)] get => InteropRuntime.Get<D3DDDI_HDR_METADATA_HDR10PLUS>(__bits, 0, 576);  [MethodImpl(MethodImplOptions.AggressiveInlining)] set { if (__bits == null) __bits = new byte[72]; InteropRuntime.Set<D3DDDI_HDR_METADATA_HDR10PLUS>(value, __bits, 0, 576); } }
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1537,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0 Map { get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0>(value, __bits, 0, 320); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1 MapProtect { get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1>(__bits, 0, 448); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1>(value, __bits, 0, 448); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2 Unmap { get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2>(value, __bits, 0, 192); } }
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3 Copy { get => InteropRuntime.Get<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[56]; InteropRuntime.Set<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3>(value, __bits, 0, 192); } }
    }
}

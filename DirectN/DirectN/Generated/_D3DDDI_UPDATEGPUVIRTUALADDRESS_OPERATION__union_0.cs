// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1381,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public byte[] __bits;
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0 Map => InteropRuntime.GetBits<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_0>(__bits, 0, 320);
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1 MapProtect => InteropRuntime.GetBits<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1>(__bits, 0, 448);
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2 Unmap => InteropRuntime.GetBits<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_2>(__bits, 0, 192);
        public _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3 Copy => InteropRuntime.GetBits<_D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_3>(__bits, 0, 192);
    }
}

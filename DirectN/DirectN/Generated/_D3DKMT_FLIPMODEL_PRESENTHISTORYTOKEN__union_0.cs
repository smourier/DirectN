// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(535,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 152)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMT_SCATTERBLTS ScatterBlts { get => InteropRuntime.Get<_D3DKMT_SCATTERBLTS>(__bits, 0, 768); set { if (__bits == null) __bits = new byte[152]; InteropRuntime.Set<_D3DKMT_SCATTERBLTS>(value, __bits, 0, 768); } }
        public _D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0 __field_1 { get => InteropRuntime.Get<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0>(__bits, 0, 1216); set { if (__bits == null) __bits = new byte[152]; InteropRuntime.Set<_D3DKMT_FLIPMODEL_PRESENTHISTORYTOKEN__union_0__struct_0>(value, __bits, 0, 1216); } }
    }
}

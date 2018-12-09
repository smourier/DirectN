// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(458,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_Fixed32__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA2_Fixed32__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA2_Fixed32__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<_DXVA2_Fixed32__union_0__struct_0>(value, __bits, 0, 32); }
        public int ll { get => InteropRuntime.GetInt32(__bits, 0, 32); set => InteropRuntime.SetInt32(value, __bits, 0, 32); }
    }
}

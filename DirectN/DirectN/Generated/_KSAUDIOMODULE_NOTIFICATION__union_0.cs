// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(8080,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSAUDIOMODULE_NOTIFICATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _KSAUDIOMODULE_NOTIFICATION__union_0__struct_0 ProviderId { get => InteropRuntime.Get<_KSAUDIOMODULE_NOTIFICATION__union_0__struct_0>(__bits, 0, 320); set => InteropRuntime.Set<_KSAUDIOMODULE_NOTIFICATION__union_0__struct_0>(value, __bits, 0, 320); }
        public long Alignment { get => InteropRuntime.GetInt64(__bits, 0, 64); set => InteropRuntime.SetInt64(value, __bits, 0, 64); }
    }
}

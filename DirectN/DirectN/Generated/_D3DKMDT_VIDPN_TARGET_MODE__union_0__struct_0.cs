// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(621,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_TARGET_MODE__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DKMDT_MODE_PREFERENCE Preference { get => InteropRuntime.Get<_D3DKMDT_MODE_PREFERENCE>(__bits, 0, 2); set => InteropRuntime.Set<_D3DKMDT_MODE_PREFERENCE>(value, __bits, 0, 2); }
        // a field here has no name.
    }
}

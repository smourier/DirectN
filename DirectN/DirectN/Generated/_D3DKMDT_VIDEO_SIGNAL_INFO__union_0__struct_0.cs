// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(545,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDEO_SIGNAL_INFO__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING ScanLineOrdering { get => InteropRuntime.Get<_D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING>(__bits, 0, 3); set => InteropRuntime.Set<_D3DDDI_VIDEO_SIGNAL_SCANLINE_ORDERING>(value, __bits, 0, 3); }
        public uint VSyncFreqDivider { get => InteropRuntime.GetUInt32(__bits, 3, 6); set => InteropRuntime.SetUInt32(value, __bits, 3, 6); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 9, 23); set => InteropRuntime.SetUInt32(value, __bits, 9, 23); }
    }
}

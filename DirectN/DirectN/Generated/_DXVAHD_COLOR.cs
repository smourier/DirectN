// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxvahd.h(275,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_COLOR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVAHD_COLOR_RGBA RGB { get => InteropRuntime.Get<_DXVAHD_COLOR_RGBA>(__bits, 0, 128); set => InteropRuntime.Set<_DXVAHD_COLOR_RGBA>(value, __bits, 0, 128); }
        public _DXVAHD_COLOR_YCbCrA YCbCr { get => InteropRuntime.Get<_DXVAHD_COLOR_YCbCrA>(__bits, 0, 128); set => InteropRuntime.Set<_DXVAHD_COLOR_YCbCrA>(value, __bits, 0, 128); }
    }
}

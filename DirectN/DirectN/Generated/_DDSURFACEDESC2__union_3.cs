// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddraw.h(2288,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSURFACEDESC2__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DDCOLORKEY ddckCKDestOverlay { get => InteropRuntime.Get<_DDCOLORKEY>(__bits, 0, 64); set => InteropRuntime.Set<_DDCOLORKEY>(value, __bits, 0, 64); }
        public uint dwEmptyFaceColor { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}

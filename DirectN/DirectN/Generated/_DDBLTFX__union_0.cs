// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(287,5)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDBLTFX__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint dwZDestConst => InteropRuntime.GetUInt32(__bits, 0, 32);
        public IntPtr lpDDSZBufferDest => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
    }
}

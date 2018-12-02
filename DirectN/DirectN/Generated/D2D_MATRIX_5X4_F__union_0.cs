// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dcommon.h(373,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_MATRIX_5X4_F__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
        public byte[] __bits;
        public float[] m => InteropRuntime.GetArray<float>(__bits, 0, 640);
    }
}

// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(3277,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_CLUSTER_METRICS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public float width => InteropRuntime.GetSingle(__bits, 0, 32);
        public ushort length => InteropRuntime.GetUInt16(__bits, 32, 16);
        public ushort canWrapLineAfter => InteropRuntime.GetUInt16(__bits, 48, 1);
        public ushort isWhitespace => InteropRuntime.GetUInt16(__bits, 49, 1);
        public ushort isNewline => InteropRuntime.GetUInt16(__bits, 50, 1);
        public ushort isSoftHyphen => InteropRuntime.GetUInt16(__bits, 51, 1);
        public ushort isRightToLeft => InteropRuntime.GetUInt16(__bits, 52, 1);
        public ushort padding => InteropRuntime.GetUInt16(__bits, 53, 11);
    }
}

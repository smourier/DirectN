// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(3277,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_CLUSTER_METRICS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float width { get => InteropRuntime.GetSingle(__bits, 0, 32); set => InteropRuntime.SetSingle(value, __bits, 0, 32); }
        public ushort length { get => InteropRuntime.GetUInt16(__bits, 32, 16); set => InteropRuntime.SetUInt16(value, __bits, 32, 16); }
        public ushort canWrapLineAfter { get => InteropRuntime.GetUInt16(__bits, 48, 1); set => InteropRuntime.SetUInt16(value, __bits, 48, 1); }
        public ushort isWhitespace { get => InteropRuntime.GetUInt16(__bits, 49, 1); set => InteropRuntime.SetUInt16(value, __bits, 49, 1); }
        public ushort isNewline { get => InteropRuntime.GetUInt16(__bits, 50, 1); set => InteropRuntime.SetUInt16(value, __bits, 50, 1); }
        public ushort isSoftHyphen { get => InteropRuntime.GetUInt16(__bits, 51, 1); set => InteropRuntime.SetUInt16(value, __bits, 51, 1); }
        public ushort isRightToLeft { get => InteropRuntime.GetUInt16(__bits, 52, 1); set => InteropRuntime.SetUInt16(value, __bits, 52, 1); }
        public ushort padding { get => InteropRuntime.GetUInt16(__bits, 53, 11); set => InteropRuntime.SetUInt16(value, __bits, 53, 11); }
    }
}

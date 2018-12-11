// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(944,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float expansionMinimum { get => InteropRuntime.GetSingle(__bits, 0, 32); set => InteropRuntime.SetSingle(value, __bits, 0, 32); }
        public float expansionMaximum { get => InteropRuntime.GetSingle(__bits, 32, 32); set => InteropRuntime.SetSingle(value, __bits, 32, 32); }
        public float compressionMaximum { get => InteropRuntime.GetSingle(__bits, 64, 32); set => InteropRuntime.SetSingle(value, __bits, 64, 32); }
        public uint expansionPriority { get => InteropRuntime.GetUInt32(__bits, 96, 8); set => InteropRuntime.SetUInt32(value, __bits, 96, 8); }
        public uint compressionPriority { get => InteropRuntime.GetUInt32(__bits, 104, 8); set => InteropRuntime.SetUInt32(value, __bits, 104, 8); }
        public uint allowResidualExpansion { get => InteropRuntime.GetUInt32(__bits, 112, 1); set => InteropRuntime.SetUInt32(value, __bits, 112, 1); }
        public uint allowResidualCompression { get => InteropRuntime.GetUInt32(__bits, 113, 1); set => InteropRuntime.SetUInt32(value, __bits, 113, 1); }
        public uint applyToLeadingEdge { get => InteropRuntime.GetUInt32(__bits, 114, 1); set => InteropRuntime.SetUInt32(value, __bits, 114, 1); }
        public uint applyToTrailingEdge { get => InteropRuntime.GetUInt32(__bits, 115, 1); set => InteropRuntime.SetUInt32(value, __bits, 115, 1); }
        public uint reserved { get => InteropRuntime.GetUInt32(__bits, 116, 12); set => InteropRuntime.SetUInt32(value, __bits, 116, 12); }
    }
}

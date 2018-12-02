// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(944,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_JUSTIFICATION_OPPORTUNITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public float expansionMinimum => InteropRuntime.GetSingle(__bits, 0, 32);
        public float expansionMaximum => InteropRuntime.GetSingle(__bits, 32, 32);
        public float compressionMaximum => InteropRuntime.GetSingle(__bits, 64, 32);
        public uint expansionPriority => InteropRuntime.GetUInt32(__bits, 96, 8);
        public uint compressionPriority => InteropRuntime.GetUInt32(__bits, 104, 8);
        public uint allowResidualExpansion => InteropRuntime.GetUInt32(__bits, 112, 1);
        public uint allowResidualCompression => InteropRuntime.GetUInt32(__bits, 113, 1);
        public uint applyToLeadingEdge => InteropRuntime.GetUInt32(__bits, 114, 1);
        public uint applyToTrailingEdge => InteropRuntime.GetUInt32(__bits, 115, 1);
        public uint reserved => InteropRuntime.GetUInt32(__bits, 116, 12);
    }
}

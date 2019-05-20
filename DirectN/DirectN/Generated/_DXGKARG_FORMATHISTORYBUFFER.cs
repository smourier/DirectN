// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7686,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_FORMATHISTORYBUFFER
    {
        public IntPtr pHistoryBuffer;
        public uint HistoryBufferSize;
        public IntPtr pFormattedBuffer;
        public uint FormattedBufferSize;
        public uint NumTimestamps;
        public _DXGKARG_HISTORYBUFFERPRECISION Precision;
        public uint Offset;
    }
}

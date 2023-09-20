// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
